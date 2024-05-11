using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gestor_de_inventario_Supermercado_Los_Patitos
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {


            // PRUEBA FUNCIONALIDAD VERIFICADOR ID

            // cedula valida
            VerifyID v = new VerifyID();
            string datos = v.verifyID("703100722");
            string[] resul = datos.Split(',');
			MessageBox.Show("Número de cédula: " + resul[0] + "\nNombre completo: " + resul[1]);

			//cedula invalida (retorna 0,0)
			VerifyID v2 = new VerifyID();
			string datos2 = v2.verifyID("123456789");
			string[] resul2 = datos2.Split(',');
			MessageBox.Show("Número de cédula: " + resul2[0] + "\nNombre completo: " + resul2[1]);


			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VentanaInicioSesion());
            
        }
    }
}
