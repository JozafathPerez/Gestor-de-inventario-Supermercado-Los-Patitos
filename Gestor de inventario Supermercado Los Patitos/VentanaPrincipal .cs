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
    public partial class VentanaPrincipal : Form
    {
        bool sidebarExpand;
        private Button ultimoBoton = null;
        private Conexion conexion;
        private int idTrabajador;

        VentanaInicioSesion view;

        public VentanaPrincipal(VentanaInicioSesion pView,int idTrabajador)
        {
            this.view = pView;
            InitializeComponent();
            this.idTrabajador = idTrabajador;
            conexion = new Conexion();
            sidebarExpand = true;

            int idRol = ObtenerIdRol(idTrabajador);

            if (idRol != 1) { BT_empleados.Visible = false; }

        }
        public int ObtenerIdRol(int idTrabajador)
        {
            // Verifica si el idEmpleado es igual a 1 para administrador
            string query = "SELECT idRol FROM Personal WHERE idTrabajador = @idTrabajador";

            using (SqlCommand command = new SqlCommand(query, conexion.ConectarBD))
            {
                command.Parameters.AddWithValue("@idTrabajador", idTrabajador);
                conexion.abrir();

                try
                {
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int idRol))
                    {
                        return idRol;
                    }
                    else
                    {  
                        return -1; 
                    }
                }
                finally
                {
                    conexion.cerrar();
                }
            }
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
            cargarForm(new PanelVentas(this.idTrabajador));
        }

        private void BT_inventario_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(BT_inventario);
            if (sidebarExpand)
            {
                menuButton_Click(sender, e);
            }
            cargarForm(new PanelInventario(idTrabajador));
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

		private void cerrarVentana(object sender, FormClosedEventArgs e) {
            String mensaje = "¿Desea cerrar la aplicación?";
            DialogResult resultado = MessageBox.Show(mensaje, "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
		}
	}
}
