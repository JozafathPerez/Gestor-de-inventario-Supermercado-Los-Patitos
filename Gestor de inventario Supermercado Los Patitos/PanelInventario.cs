using Gestor_de_inventario__Super_Los_Patitos_;
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
    public partial class PanelInventario : Form
    {
        private Conexion conexion;
        public PanelInventario()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void BT_agregarProducto_Click(object sender, EventArgs e)
        {

            // Crear una instancia del formulario secundario
            DialogoAgregarProducto actualizarForm = new DialogoAgregarProducto();

            // Mostrar el formulario secundario como una ventana emergente
            DialogResult resultado = actualizarForm.ShowDialog();

            // Actualizar la vista de datos u realizar otras acciones necesarias
            actualizarDataView();
        }

        private void BT_realizarAjuste_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario secundario
            DialogoRealizarAjuste actualizarForm = new DialogoRealizarAjuste();

            // Mostrar el formulario secundario como una ventana emergente
            DialogResult resultado = actualizarForm.ShowDialog();

            // Actualizar la vista de datos u realizar otras acciones necesarias
            actualizarDataView();
        }
        public void actualizarDataView()
        {

        }
    }
}
