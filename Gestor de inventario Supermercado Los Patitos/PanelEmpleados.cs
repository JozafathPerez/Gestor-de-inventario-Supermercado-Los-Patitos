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

            if (string.IsNullOrWhiteSpace(identificacion) || string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido1) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(contrasenia) || string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(genero) || string.IsNullOrWhiteSpace(rol) ||
                string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (!EsFormatoCorreoValido(email))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.");
                return;
            }

            if (!EsNumeroValido(telefono))
            {
                MessageBox.Show("El número de teléfono debe contener solo números.");
                return;
            }

            if (!EsNumeroValido(identificacion))
            {
                MessageBox.Show("La identificación debe contener solo números.");
                return;
            }

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

        private bool EsFormatoCorreoValido(string correo)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(correo);
                return addr.Address == correo;
            }
            catch
            {
                return false;
            }
        }

        private bool EsNumeroValido(string cadena)
        {
            foreach (char c in cadena)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
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
                    c.cerrar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el ID del rol: " + ex.Message);
                }
            }
            return idRol;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string identificacion = textIdentificacion.Text;
            string nombre = textNombre.Text;
            string apellido1 = textApellido1.Text;
            string apellido2 = textApellido2.Text;
            string direccion = textDireccion.Text;
            string email = textEmail.Text;
            string contrasenia = textContra.Text;
            string telefono = textTelefono.Text;
            string genero = comboBoxGenero.SelectedItem.ToString();
            string nombreRol = comboBoxRol.SelectedItem.ToString();
            bool estado = checkActivo.Checked;
            DateTime fechaNacimiento = dateNacimiento.Value;

            if (string.IsNullOrWhiteSpace(identificacion) || string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido1) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(contrasenia) || string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(genero) || string.IsNullOrWhiteSpace(nombreRol) ||
                string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (!EsFormatoCorreoValido(email))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.");
                return;
            }

            if (!EsNumeroValido(telefono))
            {
                MessageBox.Show("El número de teléfono debe contener solo números.");
                return;
            }

            if (!EsNumeroValido(identificacion))
            {
                MessageBox.Show("La identificación debe contener solo números.");
                return;
            }

            int idRol = ObtenerIdRol(nombreRol);

            if (idRol == -1)
            {
                MessageBox.Show("El rol seleccionado no existe en la base de datos.");
                return;
            }

            string query = "UPDATE Personal SET fechaNacim = @fechaNacim, nombre = @nombre, apellidoPat = @apellidoPat, " +
                           "apellidoMat = @apellidoMat, direccion = @direccion, email = @email, " +
                           "contrasenia = @contrasenia, numTel = @numTel, genero = @genero, idRol = @idRol, estado = @estado " +
                           "WHERE idTrabajador = @idTrabajador";

            using (SqlCommand command = new SqlCommand(query, c.ConectarBD))
            {
                try
                {
                    c.abrir();

                    command.Parameters.AddWithValue("@fechaNacim", fechaNacimiento);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellidoPat", apellido1);
                    command.Parameters.AddWithValue("@apellidoMat", apellido2);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@contrasenia", contrasenia);
                    command.Parameters.AddWithValue("@numTel", telefono);
                    command.Parameters.AddWithValue("@genero", genero);
                    command.Parameters.AddWithValue("@idRol", idRol);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@idTrabajador", identificacion);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro de personal modificado correctamente.");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el registro de personal. Verifique la identificación.");
                    }
                    c.cerrar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el registro de personal: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string identificacion = textIdentificacion.Text;

            if (string.IsNullOrEmpty(identificacion))
            {
                MessageBox.Show("Ingrese la identificación del personal a eliminar.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este registro de personal?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string query = "DELETE FROM Personal WHERE idTrabajador = @idTrabajador";

            using (SqlCommand command = new SqlCommand(query, c.ConectarBD))
            {
                try
                {
                    c.abrir();
                    command.Parameters.AddWithValue("@idTrabajador", identificacion);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro de personal eliminado correctamente.");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún registro de personal con esa identificación.");
                    }
                    c.cerrar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro de personal: " + ex.Message);
                }
            }
        }


    }
}
