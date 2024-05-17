using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_inventario_Supermercado_Los_Patitos
{
    public partial class DialogoRealizarAjuste : Form
    {
        public DialogoRealizarAjuste()
        {
            InitializeComponent();
            labelID.Text = "";
            labelProducto.Text = "";
        }

        private void buttonRealizarAjuste_Click(object sender, EventArgs e)
        {
            // Verificar si los campos están vacíos
            if (labelID.Text == "")
            {
                MessageBox.Show("Por favor, Seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los valores de nombre, precio y cantidad
            int codigo = Convert.ToInt32(labelID.Text);
            string nombre = labelProducto.Text;
            decimal precio = numericPrecio.Value;
            decimal cantidad = numericCantidad.Value;

            // Agregar los datos a dataGridSeleccionados
            dataGridSeleccionados.Rows.Add(codigo, nombre, precio, cantidad);
            LimpiarEntradas();
        }



        private void LimpiarEntradas()
        {
            labelProducto.Text = "";
            labelID.Text = "";
            numericPrecio.Value = 0; 
            numericCantidad.Value = 0;
            textBoxRazon.Text = "";
        }

        private void dataGridSeleccionados_DoubleClick(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila
            if (dataGridSeleccionados.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridSeleccionados.SelectedRows[0];

                // Obtener el índice de la fila seleccionada
                int indiceFila = filaSeleccionada.Index;

                // Eliminar la fila seleccionada del DataGridView
                dataGridSeleccionados.Rows.RemoveAt(indiceFila);
            }
        }
    }
}
