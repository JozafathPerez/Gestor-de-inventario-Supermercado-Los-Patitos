using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestor_de_inventario__Super_Los_Patitos_;
using Newtonsoft.Json.Linq;
using Spire.Pdf;
using Spire.Pdf.Graphics;


namespace Gestor_de_inventario_Supermercado_Los_Patitos {
	internal class Facturacion {
		/// <summary>
		/// Clase que maneja la generación y envío de facturas electrónicas en formato PDF a través del sistema de gestión de inventario 
		/// para el supermercado "Los Patitos".
		/// </summary>
		private static string projectPath;
		private Conexion c;

		/// <summary>
		/// Constructor de la clase Facturacion que inicializa una instancia de Facturacion con la ubicación del proyecto
		/// y la instancia de la conexión a la base de datos.
		/// </summary>
		public Facturacion() {
			string path = getMyLocation();
			string[] p = path.Split('\\');
			p = p.Take(p.Length - 3).ToArray();

			projectPath = string.Join("\\", p) + "\\";
			c = new Conexion();
		}


		/// <summary>
		/// Genera y envía una factura electrónica en formato PDF a través de correo electrónico.
		/// </summary>
		/// <param name="pDestinatario">Dirección de correo electrónico del destinatario.</param>
		/// <param name="pIdDocumento">ID del documento de factura.</param>
		/// <returns>Devuelve verdadero si la factura se envió correctamente, de lo contrario, falso.</returns>
		public bool enviarFactura(string pDestinatario, int pIdDocumento) {

			try {
				PdfDocument document = generarFactura(pIdDocumento);
				Email mail = new Email();
				mail.sendEmail(pDestinatario, document);
				MessageBox.Show("Factura enviada correctamente.", "Envío Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			} catch (Exception ex) {
				MessageBox.Show("Error al enviar la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}

		/// <summary>
		/// Genera un documento PDF de factura electrónica basado en el ID de documento proporcionado.
		/// </summary>
		/// <param name="pIdDocumento">ID del documento de factura.</param>
		/// <returns>Devuelve un documento PDF de factura electrónica.</returns>
		private PdfDocument generarFactura(int pIdDocumento) {
			try {
				DataTable dt = new DataTable();

				PdfDocument pdf = new PdfDocument();

				PdfPageBase page = pdf.Pages.Add();

				float width = page.Canvas.ClientSize.Width;
				float height = page.Canvas.ClientSize.Height;
				float margin = 10;

				PdfFont titleFont = new PdfFont(PdfFontFamily.Helvetica, 23f, PdfFontStyle.Bold);
				PdfFont subTitleFont = new PdfFont(PdfFontFamily.Helvetica, 13f, PdfFontStyle.Bold);
				PdfFont contentFont = new PdfFont(PdfFontFamily.Helvetica, 12f);

				PdfStringFormat leftFormat = new PdfStringFormat(PdfTextAlignment.Left);
				PdfStringFormat rightFormat = new PdfStringFormat(PdfTextAlignment.Right);

				try {
					c.abrir();
					SqlDataAdapter da = new SqlDataAdapter("Buscar_Documento", c.ConectarBD);
					da.SelectCommand.Parameters.AddWithValue("@idDocumento", pIdDocumento);
					da.SelectCommand.CommandType = CommandType.StoredProcedure;
					da.Fill(dt);
					c.cerrar();
				} catch (Exception ex) {
					MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return null;
				}

				int idDocumento = 0;
				int tipo = 0;
				DateTime fechaCreacion = DateTime.MinValue;
				int consecutivo = 0;
				string idCliente = null;
				int idTrabajador = 0;
				decimal totalImpuestos = 0;
				decimal subTotalFactura = 0;


				if (dt.Rows.Count > 0) {
					DataRow row = dt.Rows[0];

					idDocumento = Convert.ToInt32(row["idDocumento"]);
					tipo = Convert.ToInt32(row["tipo"]);
					fechaCreacion = Convert.ToDateTime(row["fechaCreacion"]);
					consecutivo = Convert.ToInt32(row["consecutivo"]);
					idCliente = row["idCliente"].ToString();
					idTrabajador = Convert.ToInt32(row["idTrabajador"]);
					totalImpuestos = Convert.ToDecimal(row["totalImpuestos"]);
					subTotalFactura = Convert.ToDecimal(row["subtotal"]);
				} else {
					MessageBox.Show("No se encontraron datos para el ID de documento proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				VerifyID vId = new VerifyID();
				string clientInfo = vId.verifyID(idCliente);
				string[] cI = clientInfo.Split(',');


				string title = "Factura Electrónica";
				page.Canvas.DrawString(title, titleFont, PdfBrushes.Black, new RectangleF(10, margin+40, width, 50), leftFormat);

				string imagePath = projectPath + "Resources\\LOGO_Transparente.png";
				PdfImage image = PdfImage.FromFile(imagePath);
				float imageWidth = 100f;
				float imageHeight = 100f;
				page.Canvas.DrawImage(image, new RectangleF(width - margin - imageWidth, margin, imageWidth, imageHeight));

				PdfPen pen = PdfPens.Gray;
				page.Canvas.DrawLine(pen, margin, 100, width - margin, 100);

				page.Canvas.DrawString("FACTURAR A", subTitleFont, PdfBrushes.Black, new PointF(10, 110), leftFormat);
				page.Canvas.DrawString(cI[1], contentFont, PdfBrushes.Black, new PointF(10, 130), leftFormat);
				page.Canvas.DrawString(cI[0], contentFont, PdfBrushes.Black, new PointF(10, 150), leftFormat);

				page.Canvas.DrawString("N° DE FACTURA:", subTitleFont, PdfBrushes.Black, new PointF(400, 110), rightFormat);
				page.Canvas.DrawString(consecutivo.ToString(), contentFont, PdfBrushes.Black, new PointF(430, 110), leftFormat);

				page.Canvas.DrawString("EFECTUADA EN:", subTitleFont, PdfBrushes.Black, new PointF(400, 130), rightFormat);
				page.Canvas.DrawString(fechaCreacion.ToString("dd/MM/yyyy"), contentFont, PdfBrushes.Black, new PointF(430, 130), leftFormat);

				page.Canvas.DrawString("CAJERO(A):", subTitleFont, PdfBrushes.Black, new PointF(400, 150), rightFormat);

				string workerName = "";
				try {
					c.abrir();
					SqlCommand cmd = new SqlCommand("Get_Nombre_Trabajador", c.ConectarBD);
					cmd.CommandType = CommandType.StoredProcedure;
					workerName = cmd.ExecuteScalar()?.ToString();

					c.cerrar();
				} catch (Exception ex) {
					MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				page.Canvas.DrawString(workerName, contentFont, PdfBrushes.Black, new PointF(430, 150), leftFormat);

				page.Canvas.DrawString("LINEAS", subTitleFont, PdfBrushes.Black, new PointF(10, 200), leftFormat);
				page.Canvas.DrawLine(pen, margin, 220, width - margin, 220);

				page.Canvas.DrawString("CANT", subTitleFont, PdfBrushes.Black, new PointF(10, 230), leftFormat);
				page.Canvas.DrawString("DESCRIPCIÓN", subTitleFont, PdfBrushes.Black, new PointF(100, 230), leftFormat);
				page.Canvas.DrawString("PRECIO UNIT", subTitleFont, PdfBrushes.Black, new PointF(240, 230), leftFormat);
				page.Canvas.DrawString("SUBTOTAL", subTitleFont, PdfBrushes.Black, new PointF(340, 230), leftFormat);
				page.Canvas.DrawString("IVA", subTitleFont, PdfBrushes.Black, new PointF(420, 230), leftFormat);
				page.Canvas.DrawString("TOTAL", subTitleFont, PdfBrushes.Black, new PointF(460, 230), leftFormat);

				dt.Clear();
				try {
					c.abrir();
					SqlDataAdapter da = new SqlDataAdapter("Buscar_Lineas_Documento", c.ConectarBD);
					da.SelectCommand.Parameters.AddWithValue("@idDocumento", pIdDocumento);
					da.SelectCommand.CommandType = CommandType.StoredProcedure;
					da.Fill(dt);
					c.cerrar();
				} catch (Exception ex) {
					MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return null;
				}

				int y = 250;

				foreach (DataRow row in dt.Rows) {
					int cantidad = Convert.ToInt32(row["cantidad"]);
					int codigoProd = Convert.ToInt32(row["codigoProd"]);
					decimal subtotal_linea = Convert.ToDecimal(row["subtotal"]);
					decimal impuesto_linea = Convert.ToDecimal(row["impuesto"]);

					page.Canvas.DrawString(cantidad.ToString(), contentFont, PdfBrushes.Black, new PointF(10, y), leftFormat);

					DataTable dtProd = new DataTable();
					try {
						c.abrir();
						SqlDataAdapter da = new SqlDataAdapter("Buscar_Producto", c.ConectarBD);
						da.SelectCommand.Parameters.AddWithValue("@codigoProd", codigoProd);
						da.SelectCommand.CommandType = CommandType.StoredProcedure;
						da.Fill(dtProd);
						c.cerrar();
					} catch (Exception ex) {
						MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return null;
					}
					DataRow rowProd =dtProd.Rows[0];
					string nombreProd = rowProd["nombre"].ToString();
					decimal precioUnit = Convert.ToDecimal(rowProd["precioUnit"]);

					page.Canvas.DrawString(nombreProd, contentFont, PdfBrushes.Black, new PointF(100, y), leftFormat);
					page.Canvas.DrawString(precioUnit.ToString(), contentFont, PdfBrushes.Black, new PointF(240, y), leftFormat);

					page.Canvas.DrawString(subtotal_linea.ToString(), contentFont, PdfBrushes.Black, new PointF(340, y), leftFormat);
					page.Canvas.DrawString(impuesto_linea.ToString(), contentFont, PdfBrushes.Black, new PointF(420, y), leftFormat);
					page.Canvas.DrawString((subtotal_linea+impuesto_linea).ToString(), contentFont, PdfBrushes.Black, new PointF(460, y), leftFormat);

					y += 20;
				}

				page.Canvas.DrawLine(pen, margin, y+15, width - margin, y+15);


				page.Canvas.DrawString("SUBTOTAL:", subTitleFont, PdfBrushes.Black, new PointF(435, y+ 30), rightFormat);
				page.Canvas.DrawString(subTotalFactura.ToString(), subTitleFont, PdfBrushes.Black, new PointF(450, y + 30), leftFormat);

				page.Canvas.DrawString("TOTAL IMPUESTO:", subTitleFont, PdfBrushes.Black, new PointF(435, y + 60), rightFormat);
				page.Canvas.DrawString(totalImpuestos.ToString(), subTitleFont, PdfBrushes.Black, new PointF(450, y + 60), leftFormat);

				page.Canvas.DrawString("TOTAL:", subTitleFont, PdfBrushes.Black, new PointF(435, y + 90), rightFormat);
				page.Canvas.DrawString((subTotalFactura + totalImpuestos).ToString(), subTitleFont, PdfBrushes.Black, new PointF(450, y + 90), leftFormat);

				//string filePath = projectPath + "factura_electronica.pdf";
				//pdf.SaveToFile(filePath);
				//pdf.Close();
				return pdf;

			} catch (Exception ex) {
				MessageBox.Show("Error al generar la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return null;
		}

		/// <summary>
		/// Obtiene la ubicación del archivo de la clase Facturacion.cs.
		/// </summary>
		/// <returns>Devuelve la ruta completa del archivo Facturacion.cs.</returns>
		public string getMyLocation() {
			string codeBase = Assembly.GetExecutingAssembly().CodeBase;
			UriBuilder uri = new UriBuilder(codeBase);
			string path = Uri.UnescapeDataString(uri.Path);

			string directoryPath = Path.GetDirectoryName(path);
			string filePath = Path.Combine(directoryPath, "Facturacion.cs");

			return filePath;
		}
	}
}
