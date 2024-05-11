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

        }
    }
}
