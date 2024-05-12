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
            BT_realizarAjuste.Visible = false;
            BT_agregarProducto.Visible = false;
        }

        private void BT_agregarProducto_Click(object sender, EventArgs e)
        {
            MostrarBotones(false, true, true, false);
        }

        private void BT_realizarAjuste_Click(object sender, EventArgs e)
        {
            MostrarBotones(true, false, false, true);
            
        }
        private void BT_vistaAjuste_Click(object sender, EventArgs e)
        {
            MostrarBotones(true, false, false, true);
            cargarForm(new DialogoRealizarAjuste());
        }

        private void BT_vistaAgregar_Click(object sender, EventArgs e)
        {
            MostrarBotones(false, true, true, false);
            cargarForm(new DialogoAgregarProducto());
        }

        public void actualizarDataView()
        {

        }
        private void MostrarBotones(bool vistaAgregar, bool vistaAjuste, bool agregarProducto, bool realizarAjuste)
        {
            BT_vistaAgregar.Visible = vistaAgregar;
            BT_vistaAjuste.Visible = vistaAjuste;
            BT_agregarProducto.Visible = agregarProducto;
            BT_realizarAjuste.Visible = realizarAjuste;
        }


        public void cargarForm(object Form)
        {
            if (this.PanelAreaInventario.Controls.Count > 0)
                this.PanelAreaInventario.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PanelAreaInventario.Controls.Add(f);
            this.PanelAreaInventario.Tag = f;
            f.Show();
        }


    }
}
