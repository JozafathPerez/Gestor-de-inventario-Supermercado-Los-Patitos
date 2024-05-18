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

		/// <summary>
		/// Constructor de la clase PanelReporteria que inicializa una instancia de PanelReporteria
		/// con las vistas y métodos de carga de datos especificados.
		/// </summary>
		public PanelReporteria()
        {	
			c = new Conexion();
			InitializeComponent();
			loadCashiersMostSales();
			loadDaysMostPurchases();
			loadTopSellingCategories();
			loadTop5Clients();
			loadTop5Products();
			loadTopProduct();
			loadCashierOfTheMonth();
		}

		/// <summary>
		/// Carga los datos del producto más vendido en el DataGridView tbTopProd.
		/// </summary>

		private void loadTopProduct() {
			try {
				c.abrir();
				SqlDataAdapter da = new SqlDataAdapter("Top_Producto", c.ConectarBD);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				DataTable dt = new DataTable();
				da.Fill(dt);
				this.tbTopProd.DataSource = dt;
				c.cerrar();
			} catch (Exception ex) {
				MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			foreach (DataGridViewColumn column in tbTopProd.Columns) {
				column.SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}

		/// <summary>
		/// Carga los datos de los 5 clientes principales en el DataGridView tbTopClientes.
		/// </summary>
		private void loadTop5Clients() {
			try {
				c.abrir();
				SqlDataAdapter da = new SqlDataAdapter("Top_5_Clientes", c.ConectarBD);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				DataTable dt = new DataTable();
				da.Fill(dt);


				/*
				DataColumn colName = new DataColumn("Nombre Completo", typeof(string));
				dt.Columns.Add(colName);

				colName.SetOrdinal(1);
	
				foreach (DataRow row in dt.Rows) {
					string clientID = row["Cédula"].ToString();

					string clientData = vID.verifyID(clientID);
					string[] cD = clientData.Split(',');

					if (cD != null && cD[0].Equals('0')) {
						cD[1] = "Nombre no registrado";
					}

					row["Nombre Completo"] = cD[1];
				}
				*/
				this.tbTopClientes.DataSource = dt;
				c.cerrar();
			} catch (Exception ex) {
				MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			foreach (DataGridViewColumn column in tbTopClientes.Columns) {
				column.SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}

		/// <summary>
		/// Carga los datos de los productos más vendidos en el DataGridView tbProdVendidos.
		/// </summary>
		private void loadTop5Products() {
			try {
				c.abrir();
				SqlDataAdapter da = new SqlDataAdapter("Prod_Vendidos_30_Dias", c.ConectarBD);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				DataTable dt = new DataTable();
				da.Fill(dt);
				this.tbProdVendidos.DataSource = dt;
				c.cerrar();
			} catch (Exception ex) {
				MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			foreach (DataGridViewColumn column in tbProdVendidos.Columns) {
				column.SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}

		/// <summary>
		/// Carga los datos del cajero del mes en el DataGridView tbTopCashier.
		/// </summary>
		private void loadCashierOfTheMonth() {
			try {
				c.abrir();
				SqlDataAdapter da = new SqlDataAdapter("Cajero_Del_Mes", c.ConectarBD);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				DataTable dt = new DataTable();
				da.Fill(dt);
				this.tbTopCashier.DataSource = dt;
				c.cerrar();
			} catch (Exception ex) {
				MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			foreach (DataGridViewColumn column in tbTopCashier.Columns) {
				column.SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}

		/// <summary>
		/// Carga los datos de las categorías más vendidas en el gráfico chCategorias.
		/// </summary>
		private void loadTopSellingCategories() {
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

		/// <summary>
		/// Carga los datos de las ventas por cajero en el gráfico chCajeros.
		/// </summary>
		private void loadCashiersMostSales() {
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

			} catch (Exception) {
				Console.WriteLine("Error al mostrar la gráfica de facturas por cajero, Inténtelo nuevamente ");
			}

		}



		/// <summary>
		/// Carga los datos de los días con más compras en el gráfico chFechas.
		/// </summary>
		private void loadDaysMostPurchases() {
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



		/// <summary>
		/// Ejecuta un procedimiento almacenado y devuelve el resultado en forma de DataTable.
		/// </summary>
		/// <param name="pSp">Nombre del procedimiento almacenado a ejecutar.</param>
		/// <returns>DataTable con el resultado del procedimiento almacenado.</returns>
		public DataTable spExecuter(string pSp) {
			c.abrir();
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(pSp, c.ConectarBD);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.Fill(dt);
			c.cerrar();
			return dt;
		}


		/// <summary>
		/// Carga las facturas dentro de un rango de fechas especificado en el DataGridView tbFacturasRF.
		/// </summary>
		/// <param name="sender">Objeto que envía el evento (en este caso, un control de fecha).</param>
		/// <param name="e">Argumentos del evento.</param>
		private void loadInvoicesByDateRange(object sender, EventArgs e) {
			if (dtpFechaInicio.Value <= dtpFechaFin.Value) {
				try {
					c.abrir();

					SqlDataAdapter da = new SqlDataAdapter("Facturas_Por_Rango_Fechas", c.ConectarBD);
					da.SelectCommand.CommandType = CommandType.StoredProcedure;

					da.SelectCommand.Parameters.AddWithValue("@fechaInicial", dtpFechaInicio.Value.ToString("MM-dd-yyyy"));
					da.SelectCommand.Parameters.AddWithValue("@fechaFinal", dtpFechaFin.Value.ToString("MM-dd-yyyy"));

					DataTable dt = new DataTable();
					da.Fill(dt);
					this.tbFacturasRF.DataSource = dt;
					c.cerrar();
				} catch (Exception ex) {
					MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}


		/// <summary>
		/// Carga las facturas dentro de un rango de fechas especificado en el DataGridView tbFacturasRF.
		/// </summary>
		/// <param name="sender">Objeto que envía el evento (en este caso, un control de fecha).</param>
		/// <param name="e">Argumentos del evento.</param>
		private void loadInvoicesByDateRange2(object sender, EventArgs e) {
			if (dtpFechaInicio.Value <= dtpFechaFin.Value) {
				try {
					c.abrir();

					SqlDataAdapter da = new SqlDataAdapter("Facturas_Por_Rango_Fechas", c.ConectarBD);
					da.SelectCommand.CommandType = CommandType.StoredProcedure;

					da.SelectCommand.Parameters.AddWithValue("@fechaInicial", dtpFechaInicio.Value.ToString("MM-dd-yyyy"));
					da.SelectCommand.Parameters.AddWithValue("@fechaFinal", dtpFechaFin.Value.ToString("MM-dd-yyyy"));

					DataTable dt = new DataTable();
					da.Fill(dt);
					this.tbFacturasRF.DataSource = dt;
					c.cerrar();
				} catch (Exception ex) {
					MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

	}
}
