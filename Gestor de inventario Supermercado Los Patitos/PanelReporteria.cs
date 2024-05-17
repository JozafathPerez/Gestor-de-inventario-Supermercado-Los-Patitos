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
    public partial class PanelReporteria : Form
    {

		Conexion c;
        public PanelReporteria()
        {
			c = new Conexion();
			InitializeComponent();
			cajerosConMasVentas();
			fechaConMasCompras();
			categoriasMasVendida();

		}

		private void categoriasMasVendida() {
			try {
				DataTable dt = spExecuter("Top_Categorias_Vendidas");

				if (dt.Rows.Count > 0) {
					this.chCategorias.Series["Categorias"].Points.Clear();

					foreach (DataRow row in dt.Rows) {
						string	categoria = row["Categoría"].ToString();
						int		totalVendido = Convert.ToInt32(row["Total Vendido"]);

						this.chCategorias.Series["Categorias"].Points.AddXY(categoria, totalVendido);
					}
				} else {
					MessageBox.Show("No hay datos para mostrar categorías más vendidas.");
				}

			} catch (Exception) {
				Console.WriteLine("Error al mostrar la gráfica de categorías más vendidas, Inténtelo nuevamente ");
			}

		}

		private void cajerosConMasVentas() {
			try {
				DataTable dt = spExecuter("Cajeros_Mas_Ventas");

				if (dt.Rows.Count > 0) {
					this.chCajeros.Series["Facturas"].Points.Clear();

					foreach (DataRow row in dt.Rows) {
						string  idTrabajador = row["Nombre Completo"].ToString();
						int     facturas = Convert.ToInt32(row["Total Facturas"]);

						this.chCajeros.Series["Facturas"].Points.AddXY(idTrabajador, facturas);
					}
				} else {
					MessageBox.Show("No hay datos para mostrar facturas por cajero.");
				}

			} catch (Exception ex) {
				Console.WriteLine("Error al mostrar la gráfica de facturas por cajero, Inténtelo nuevamente ");
			}

		}

		private void fechaConMasCompras() {
			try {
				DataTable dt = spExecuter("Fechas_Mas_Compras");

				if (dt.Rows.Count > 0) {
					this.chFechas.Series["Fechas"].Points.Clear();

					foreach (DataRow row in dt.Rows) {
						string  dia = row["Día"].ToString();
						int     facturas = Convert.ToInt32(row["Total Facturas"]);

						this.chFechas.Series["Fechas"].Points.AddXY(dia, facturas);
					}
				} else {
					MessageBox.Show("No hay datos para mostrar día de la semana con más ventas.");
				}

			} catch (Exception) {
				Console.WriteLine("Error al mostrar la gráfica de día de la semana con más ventas, Inténtelo nuevamente ");
			}

		}

		public DataTable spExecuter(string pSp) {
			c.abrir();
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(pSp, c.ConectarBD);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.Fill(dt);
			c.cerrar();
			return dt;
		}

	}
}
