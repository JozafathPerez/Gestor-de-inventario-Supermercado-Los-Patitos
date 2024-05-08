using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Gestor_de_inventario__Super_Los_Patitos_
{
    public class Conexion
    {
        // Cambiar el nombre de hotel
        string cadena = "Data source=" + Environment.MachineName + "; Initial Catalog=hotel; Integrated Security=True";

        public SqlConnection ConectarBD = new SqlConnection();

        public Conexion()
        {
            ConectarBD.ConnectionString = cadena;

        }

        public void abrir()
        {
            try
            {
                ConectarBD.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: No se pudo abrir la BD" + ex.Message);
            }
        }

        public void cerrar()
        {
            ConectarBD.Close();
        }
    }
}
