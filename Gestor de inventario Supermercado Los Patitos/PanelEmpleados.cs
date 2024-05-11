using Gestor_de_inventario__Super_Los_Patitos_;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestor_de_inventario_Supermercado_Los_Patitos
{
    public partial class PanelEmpleados : Form
    {
        Conexion c;
        public PanelEmpleados()
        {
            InitializeComponent();
            c = new Conexion();
        }

        private void PanelEmpleados_Load(object sender, EventArgs e)
        {
            CargarPersonal();
            CargarRoles();
        }

        private void CargarPersonal()
        {
            try
            {
                c.abrir();
                string consulta = "SELECT p.idTrabajador AS Identificacion," +
                    "p.fechaNacim AS Nacimiento," +
                    "p.nombre AS Nombre," +
                    "p.apellidoPat AS Apellido_Paterno," +
                    "p.apellidoMat AS Apellido_Materno," +
                    "p.direccion AS Direccion," +
                    "p.email AS Correo," +
                    "p.contrasenia AS Contraseña," +
                    "p.numTel AS Telefono," +
                    "p.genero AS Genero," +
                    "r.nombre AS Rol," +
                    "p.estado AS Estado " +
                    "FROM Personal p " +
                    "JOIN Roles r ON p.idRol = r.idRol;";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, c.ConectarBD);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                DGVPersonal.DataSource = tabla;
                c.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarRoles()
        {
            try
            {
                c.abrir();
                string consulta = "SELECT nombre FROM Roles";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, c.ConectarBD);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                foreach (DataRow row in tabla.Rows) { comboBoxRol.Items.Add(row["nombre"]); }
                c.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string identificacion = textIdentificacion.Text;
            string nombre = textNombre.Text;
            string apellido1 = textApellido1.Text;
            string apellido2 = textApellido2.Text;
            string email = textEmail.Text;
            string contrasenia = textContra.Text;
            string telefono = textTelefono.Text;
            string genero = comboBoxGenero.SelectedItem.ToString().Substring(0, 1);
            string rol = comboBoxRol.SelectedItem.ToString();
            bool estado = checkActivo.Checked;
            string direccion = textDireccion.Text;
            DateTime fechaNacimiento = dateNacimiento.Value;

            int idRol = ObtenerIdRol(rol);

            if (idRol == -1)
            {
                MessageBox.Show("El rol seleccionado no existe en la base de datos.");
                return;
            }

            string query = "INSERT INTO Personal (idTrabajador, fechaNacim, nombre, apellidoPat, apellidoMat, direccion, email, contrasenia, numTel, genero, idRol, estado) " +
                           "VALUES (@idTrabajador, @fechaNacim, @nombre, @apellidoPat, @apellidoMat, @direccion, @email, @contrasenia, @numTel, @genero, @idRol, @estado)";

            using (SqlCommand command = new SqlCommand(query, c.ConectarBD))
            {
                try
                {
                    c.abrir();
                    command.Parameters.AddWithValue("@idTrabajador", identificacion);
                    command.Parameters.AddWithValue("@fechaNacim", fechaNacimiento);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellidoPat", apellido1);
                    command.Parameters.AddWithValue("@apellidoMat", apellido2);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@contrasenia", contrasenia);
                    command.Parameters.AddWithValue("@numTel", telefono);
                    command.Parameters.AddWithValue("@genero", genero);
                    command.Parameters.AddWithValue("@idRol", idRol);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@direccion", direccion);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro de personal insertado correctamente.");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar el registro de personal.");
                    }
                    c.cerrar();
                    CargarPersonal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el registro de personal: " + ex.Message);
                }
            }
        }

        private void LimpiarCampos()
        {
            textIdentificacion.Text = "";
            textNombre.Text = "";
            textApellido1.Text = "";
            textApellido2.Text = "";
            textEmail.Text = "";
            textContra.Text = "";
            textTelefono.Text = "";
            comboBoxGenero.SelectedIndex = -1;
            comboBoxRol.SelectedIndex = -1;
            checkActivo.Checked = false;
            dateNacimiento.Value = DateTime.Today;
        }

        private int ObtenerIdRol(string nombreRol)
        {
            string query = "SELECT idRol FROM Roles WHERE nombre = @nombre";
            int idRol = -1;
            using (SqlCommand command = new SqlCommand(query, c.ConectarBD))
            {
                command.Parameters.AddWithValue("@nombre", nombreRol);
                try
                {
                    c.abrir();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        idRol = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el ID del rol: " + ex.Message);
                }
            }
            c.cerrar();
            return idRol;
        }
    }
}
