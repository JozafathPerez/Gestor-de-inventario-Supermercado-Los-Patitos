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
    public partial class VentanaInicioSesion : Form
    {
        private Conexion conexion;
        public VentanaInicioSesion()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void VentanaInicioSesion_Load(object sender, EventArgs e)
        {
            TEXT_cuenta.Text = "Correo";
            TEXT_contrasena.Text = "Contraseña";
            TEXT_contrasena.PasswordChar = '\0';
        }

        private void BT_inicioSesion_Click(object sender, EventArgs e)
        {

        }

        private void TEXT_cuenta_Enter(object sender, EventArgs e)
        {
            if (TEXT_cuenta.Text == "Correo")
            {
                TEXT_cuenta.Text = "";
            }
        }

        private void TEXT_cuenta_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TEXT_cuenta.Text))
            {
                TEXT_cuenta.Text = "Correo";
            }
        }

        private void TEXT_contrasena_Enter(object sender, EventArgs e)
        {
            if (TEXT_contrasena.Text == "Contraseña")
            {
                TEXT_contrasena.Text = "";
                TEXT_contrasena.PasswordChar = '*';
            }
        }

        private void TEXT_contrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TEXT_contrasena.Text))
            {
                TEXT_contrasena.Text = "Contraseña";
                TEXT_contrasena.PasswordChar = '\0';
            }
        }
    }
}
