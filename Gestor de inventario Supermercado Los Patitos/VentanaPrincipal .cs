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
    public partial class VentanaPrincipal : Form
    {
        bool sidebarExpand;
        private Button ultimoBoton = null;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        // Función para cambiar el color del botón y restaurar el color del último botón presionado
        private void CambiarColorBoton(Button botonPresionado)
        {
            if (ultimoBoton != null)
            {
                ultimoBoton.BackColor = Color.FromArgb(19, 45, 70); // Restaurar color del último botón
            }

            botonPresionado.BackColor = Color.FromArgb(1, 195, 141); // Cambiar color del botón presionado
            ultimoBoton = botonPresionado; // Actualizar el último botón presionado
        }

        // Funcion para controlar el menu de hambuergesa
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // si la barra lateral está expandida, minimizar
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                    ImagenPatito.Visible = false;
                }
            }
            else
            {
                ImagenPatito.Visible = true;
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }


        private void BT_reporteria_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(BT_reporteria);
            if (sidebarExpand)
            {
                menuButton_Click(sender, e);
            }
            cargarForm(new PanelReporteria());

        }

        private void BT_ventas_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(BT_ventas);
            if (sidebarExpand)
            {
                menuButton_Click(sender, e);
            }
            cargarForm(new PanelVentas());
        }

        private void BT_inventario_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(BT_inventario);
            if (sidebarExpand)
            {
                menuButton_Click(sender, e);
            }
            cargarForm(new PanelInventario());
        }

        private void BT_empleados_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(BT_empleados);
            if (sidebarExpand)
            {
                menuButton_Click(sender, e);
            }
            cargarForm(new PanelEmpleados());
        }

        // Función para cargar los Forms (los sub-menus) y colocarlos en el PanelAreaDeTrabajo
        // También remueve lo que estaba antes en el panel!!
        public void cargarForm(object Form)
        {
            if (this.PanelAreaDeTrabajo.Controls.Count > 0)
                this.PanelAreaDeTrabajo.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PanelAreaDeTrabajo.Controls.Add(f);
            this.PanelAreaDeTrabajo.Tag = f;
            f.Show();
        }


    }
}
