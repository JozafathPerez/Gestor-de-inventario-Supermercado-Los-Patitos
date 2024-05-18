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
    public partial class DialogHistorialAjustes : Form
    {
        private Conexion conexion;
        public DialogHistorialAjustes()
        {
            InitializeComponent();
            conexion = new Conexion();

        }

        private void DialogHistorialAjustes_Load(object sender, EventArgs e)
        {
            try
            {
                // Query para seleccionar los datos de la tabla Bitacora y unir con la tabla Personal
                string query = "SELECT b.IdAjuste, p.nombre AS 'Nombre del trabajador', b.fechaHora AS 'Fecha del ajuste', b.motivo AS 'Razón' " +
                               "FROM BitacoraAjuste b " +
                               "INNER JOIN Personal p ON b.idTrabajador = p.idTrabajador";

                // Crear una instancia de SqlDataAdapter y DataTable para obtener los datos
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conexion.ConectarBD))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Asignar el DataTable al DataGridView
                    dataGridView1.DataSource = table;
                    // Ocultar la columna IdAjuste si no quieres que sea visible en el DataGridView
                    dataGridView1.Columns["IdAjuste"].Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial de ajustes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // Verificar que hay una fila seleccionada
            if (dataGridView1.CurrentRow != null)
            {
                // Obtener el IdAjuste de la fila seleccionada
                int idAjuste = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdAjuste"].Value);

                // Crear una instancia del formulario secundario pasando el IdAjuste
                DialogoHistorialProductosAjustados dialogoHistorial = new DialogoHistorialProductosAjustados(idAjuste);

                // Mostrar el formulario como un cuadro de diálogo modal
                dialogoHistorial.ShowDialog();
            }
        }


    }
}
