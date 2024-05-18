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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestor_de_inventario_Supermercado_Los_Patitos
{
    public partial class VentanaPrincipal : Form
    {
        bool sidebarExpand;
        private System.Windows.Forms.Button ultimoBoton = null;
        private Conexion conexion;
        private int idTrabajador;
        private System.Windows.Forms.ToolTip toolTip1;
        private bool cerrar = false;

        VentanaInicioSesion view;

        public VentanaPrincipal(VentanaInicioSesion pView,int idTrabajador)
        {
            this.view = pView;
            InitializeComponent();
            this.idTrabajador = idTrabajador;
            conexion = new Conexion();
            sidebarExpand = true;
            InicializarToolTip();

            int idRol = ObtenerIdRol(idTrabajador);

            if (idRol != 1) { 
                BT_empleados.Enabled = false; 
                if (idRol == 2)
                {
                    BT_reporteria.Enabled = false;
                    BT_inventario.Enabled = false;
                }
                else if (idRol == 3)
                {
                    BT_reporteria.Enabled = false;
                    BT_ventas.Enabled = false;
                }
                else if (idRol == 4) {
                    BT_ventas.Enabled = false;
                    BT_inventario.Enabled = false;
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        private void InicializarToolTip()
        {
            toolTip1 = new System.Windows.Forms.ToolTip();

            // Establecer los parámetros del ToolTip
            toolTip1.AutoPopDelay = 5000; // Tiempo que permanece visible el ToolTip
            toolTip1.InitialDelay = 100; // Tiempo que tarda en aparecer el ToolTip
            toolTip1.ReshowDelay = 500;   // Tiempo que tarda en volver a aparecer el ToolTip si el cursor se mueve fuera y luego vuelve a la imagen
            toolTip1.ShowAlways = true;   // Permitir que el ToolTip se muestre siempre, incluso si el control no está habilitado
        }

        /// <summary>
        /// Obtiene el rol del trabajador registrado
        /// </summary>
        /// <param name="idTrabajador"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Función para cambiar el color del botón y restaurar el color del último botón presionado
        /// </summary>
        /// <param name="botonPresionado"></param>
        private void CambiarColorBoton(System.Windows.Forms.Button botonPresionado)
        {
            if (ultimoBoton != null)
            {
                ultimoBoton.BackColor = Color.FromArgb(19, 45, 70); // Restaurar color del último botón
            }

            botonPresionado.BackColor = Color.FromArgb(1, 195, 141); // Cambiar color del botón presionado
            ultimoBoton = botonPresionado; // Actualizar el último botón presionado
        }

        /// <summary>
        /// Funcion para controlar el sidebar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_reporteria_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(BT_reporteria);
            if (sidebarExpand)
            {
                menuButton_Click(sender, e);
            }
            cargarForm(new PanelReporteria());

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_ventas_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(BT_ventas);
            if (sidebarExpand)
            {
                menuButton_Click(sender, e);
            }
            cargarForm(new PanelVentas(this.idTrabajador));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_inventario_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(BT_inventario);
            if (sidebarExpand)
            {
                menuButton_Click(sender, e);
            }
            cargarForm(new PanelInventario(idTrabajador));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_empleados_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(BT_empleados);
            if (sidebarExpand)
            {
                menuButton_Click(sender, e);
            }
            cargarForm(new PanelEmpleados());
        }

        /// <summary>
        /// Maneja el evento Click del botón buttonHistrial.
        /// Se ejecuta al hacer clic en el botón "Historial" y realiza acciones relacionadas.
        /// </summary>
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

        private void prepararCerrado(object sender, FormClosingEventArgs e)
        {
            if (this.cerrar) { Application.Exit(); } else {
                String mensaje = "¿Desea cerrar la aplicación?";
                DialogResult resultado = MessageBox.Show(mensaje, "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    this.cerrar = true;
                    Application.Exit();
                }
                else { e.Cancel = true; }
            }
        }

        private void menuButton_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.menuButton, "Menú");
        }
    }
}
