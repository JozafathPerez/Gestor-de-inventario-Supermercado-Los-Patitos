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



    }
}
