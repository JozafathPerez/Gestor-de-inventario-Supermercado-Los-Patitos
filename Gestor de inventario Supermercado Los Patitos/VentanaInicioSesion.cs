using Gestor_de_inventario__Super_Los_Patitos_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_inventario_Supermercado_Los_Patitos
{
    public partial class VentanaInicioSesion : Form
    {
        private Conexion conexion;
        public VentanaInicioSesion()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void VentanaInicioSesion_Load(object sender, EventArgs e)
        {
            TEXT_cuenta.Text = "Correo";
            TEXT_contrasena.Text = "Contraseña";
            TEXT_contrasena.PasswordChar = '\0';
        }

        private void BT_inicioSesion_Click(object sender, EventArgs e)
        {
            string cuenta = TEXT_cuenta.Text;
            string contrasena = TEXT_contrasena.Text;

            bool credencialesValidas = VerificarCredenciales(cuenta, contrasena);
            if (!credencialesValidas)
            {
                MessageBox.Show("Cuenta o contraseña incorrectos. Inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool estadoPesonal = VerificarEstado(cuenta);
            if (!estadoPesonal)
            {
                MessageBox.Show("El usuario se encuentra inactivo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();

            conexion.abrir();
            string query = "SELECT idTrabajador FROM Personal WHERE email = @CorreoUsuario AND contrasenia = @contrasena";

            SqlCommand command = new SqlCommand(query, conexion.ConectarBD);
            command.Parameters.AddWithValue("@CorreoUsuario", cuenta);
            command.Parameters.AddWithValue("@contrasena", contrasena);

            int idPersonal = (int)command.ExecuteScalar();
            conexion.cerrar();

            VentanaPrincipal formularioSecundario = new VentanaPrincipal(this, idPersonal);

            // Muestra el formulario secundario
            formularioSecundario.Show();

        }

        private bool VerificarEstado(string cuenta)
        {
            bool estado = false;

            try
            {
                conexion.abrir();

                string query = "SELECT estado FROM Personal WHERE email = @cuenta";
                using (SqlCommand command = new SqlCommand(query, conexion.ConectarBD))
                {
                    command.Parameters.AddWithValue("@cuenta", cuenta);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        estado = Convert.ToBoolean(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el estado del trabajador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrar();
            }

            return estado;
        }




    private bool VerificarCredenciales(string CorreoUsuario, string contrasena)
        {
            // Nombre del procedimiento almacenado
            string SP_verificarCredenciales = "VerificarCredenciales";

            SqlCommand command = new SqlCommand(SP_verificarCredenciales, conexion.ConectarBD);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@correo", CorreoUsuario);
            command.Parameters.AddWithValue("@contrasenia", contrasena);

            try
            {
                conexion.abrir();
                // Ejecutar el procedimiento almacenado y obtener el resultado
                object result = command.ExecuteScalar();

                // El resultado es un string, por lo que debemos convertirlo a bool
                return result != null && result.ToString() == "true";
            }
            catch
            {
                return false;
            }
            finally
            {
                conexion.cerrar();
            }
        }


        private void TEXT_cuenta_Enter(object sender, EventArgs e)
        {
            if (TEXT_cuenta.Text == "Correo")
            {
                TEXT_cuenta.Text = "";
            }
        }

        private void TEXT_cuenta_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TEXT_cuenta.Text))
            {
                TEXT_cuenta.Text = "Correo";
            }
        }

        private void TEXT_contrasena_Enter(object sender, EventArgs e)
        {
            if (TEXT_contrasena.Text == "Contraseña")
            {
                TEXT_contrasena.Text = "";
                TEXT_contrasena.PasswordChar = '*';
            }
        }

        private void TEXT_contrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TEXT_contrasena.Text))
            {
                TEXT_contrasena.Text = "Contraseña";
                TEXT_contrasena.PasswordChar = '\0';
            }
        }

		public void cerrarVentana(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
	}
}
