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
    public partial class DialogoHistorialProductosAjustados : Form
    {
        private Conexion conexion;
        private int idAjuste;
        public DialogoHistorialProductosAjustados(int idAjuste)
        {
            InitializeComponent();
            conexion = new Conexion();
            this.idAjuste = idAjuste;
        }

        private void DialogoHistorialProductosAjustados_Load(object sender, EventArgs e)
        {
            try
            {
                // Consulta SQL para seleccionar los productos ajustados con el nombre del producto
                string query = "SELECT p.nombre AS 'Nombre Producto', pa.cantidad AS Cantidad " +
                               "FROM ProductosAjustados pa " +
                               "INNER JOIN Productos p ON pa.codigoProd = p.codigoProd " +
                               "WHERE pa.IdAjuste = @IdAjuste";

                // Crear una instancia de SqlDataAdapter y DataTable para obtener los datos
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conexion.ConectarBD))
                {
                    // Agregar el parámetro @IdAjuste a la consulta
                    adapter.SelectCommand.Parameters.AddWithValue("@IdAjuste", idAjuste);

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Asignar el DataTable al DataGridView (asegúrate de tener un DataGridView en el formulario)
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos ajustados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
