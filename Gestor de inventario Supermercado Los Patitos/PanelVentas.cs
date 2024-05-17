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

namespace Gestor_de_inventario_Supermercado_Los_Patitos {
	public partial class PanelVentas : Form {
		Conexion c;
        private int idTrabajador;

        public PanelVentas(int idTrabajador) {
			InitializeComponent();
			this.lbName.Visible = false;
			this.txtName_Founded.Visible = false;
			this.txtID_Founded.Visible = false;
			this.lbClientID.Visible = false;
            this.idTrabajador = idTrabajador;
            c = new Conexion();
			CargarInventario();
			CargarDocumentos();
            ActualizarTotales();
        }
		private void CargarInventario() {
			try {
				c.abrir();
				string consulta = "SELECT codigoProd AS 'Codigo', categoria AS 'Categoria', tipoMedida AS 'Medida', cantidadInv AS 'Cantidad', precioUnit AS 'Precio' FROM Productos; ";
				SqlDataAdapter adaptador = new SqlDataAdapter(consulta, c.ConectarBD);
				DataTable tabla = new DataTable();
				adaptador.Fill(tabla);
				DGVInventario.DataSource = tabla;
				c.cerrar();
			} catch (Exception ex) {
				MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void CargarDocumentos() {
			try {
				c.abrir();
				string consulta = "SELECT idDocumento AS 'ID', tipo AS 'Tipo', fechaCreacion AS 'Fecha de Creacion', consecutivo AS 'Consecutivo', idCliente AS 'ID del Cliente', idTrabajador AS 'ID del Trabajador', totalImpuestos AS 'Total de Impuestos', subtotal AS 'Subtotal' FROM Documentos;";
				SqlDataAdapter adaptador = new SqlDataAdapter(consulta, c.ConectarBD);
				DataTable tabla = new DataTable();
				adaptador.Fill(tabla);
				DGVDocumentos.DataSource = tabla;
				c.cerrar();
			} catch (Exception ex) {
				MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void bAgregar_Click(object sender, EventArgs e)
        {
            if (DGVInventario.SelectedRows.Count > 0)
            {
                DataRowView filaSeleccionada = (DataRowView)DGVInventario.SelectedRows[0].DataBoundItem;
                decimal precioUnitario = Convert.ToDecimal(filaSeleccionada["Precio"]);
                int id = Convert.ToInt32(filaSeleccionada["Codigo"]);

                int cantidad = (int)numCantidad.Value;
                decimal subtotal = cantidad * precioUnitario;
                decimal impuesto = 0.13m * subtotal;
                decimal total = subtotal + impuesto;
                int cantidadInventario = Convert.ToInt32(filaSeleccionada["Cantidad"]);

                if (cantidadInventario - cantidad >= 0)
                {
                    bool itemExiste = false;
                    foreach (DataGridViewRow fila in DGVCarrito.Rows)
                    {
                        if (Convert.ToInt32(fila.Cells["Codigo"].Value) == id)
                        {
                            fila.Cells["Cantidad"].Value = Convert.ToInt32(fila.Cells["Cantidad"].Value) + cantidad;
                            fila.Cells["Subtotal"].Value = Convert.ToDecimal(fila.Cells["Cantidad"].Value) * precioUnitario;
                            fila.Cells["Impuesto"].Value = Convert.ToDecimal(fila.Cells["Subtotal"].Value) * 0.13m;
                            fila.Cells["Total"].Value = Convert.ToDecimal(fila.Cells["Subtotal"].Value) * Convert.ToDecimal(fila.Cells["Impuesto"].Value);
                            itemExiste = true;
                            break;
                        }
                    }

                    if (!itemExiste)
                    {
                        DGVCarrito.Rows.Add(id, cantidad, precioUnitario, subtotal, impuesto, total);
                    }

                    filaSeleccionada["Cantidad"] = cantidadInventario - cantidad;
                    ActualizarTotales();
                }
                else
                {
                    MessageBox.Show("No hay suficiente cantidad en el inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto del inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bComprar_Click(object sender, EventArgs e)
        {
            string tipoDocumento = comboBoxTipoDoc.SelectedItem.ToString();
            int tipoDocumentoId;

            if (tipoDocumento == "Factura")
                tipoDocumentoId = 1;
            else if (tipoDocumento == "Tiquete")
                tipoDocumentoId = 2;
            else
            {
                MessageBox.Show("Tipo de documento no válido.");
                return;
            }

            string informacionCliente = textIDCliente.Text.Trim();
            if (tipoDocumentoId == 1 && string.IsNullOrEmpty(informacionCliente))
            {
                MessageBox.Show("Debe ingresar la información del cliente.");
                return;
            }

            try
            {
                c.abrir();
                SqlTransaction transaction = c.ConectarBD.BeginTransaction();

                try
                {
                    decimal totalImpuestos = 0;
                    decimal subtotal = 0;
                    foreach (DataGridViewRow fila in DGVCarrito.Rows)
                    {
                        subtotal += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
                        totalImpuestos += Convert.ToDecimal(fila.Cells["Impuesto"].Value);
                    }

                    string obtenerConsecutivoQuery = "SELECT consecutivo FROM Consecutivos WHERE tipo = @TipoDocumento";
                    SqlCommand obtenerConsecutivoCmd = new SqlCommand(obtenerConsecutivoQuery, c.ConectarBD, transaction);
                    obtenerConsecutivoCmd.Parameters.AddWithValue("@TipoDocumento", tipoDocumentoId);
                    object resultado = obtenerConsecutivoCmd.ExecuteScalar();
                    int consecutivo = (resultado != DBNull.Value) ? Convert.ToInt32(resultado) : 0;

                    string actualizarConsecutivoQuery = "UPDATE Consecutivos SET consecutivo = consecutivo + 1 WHERE tipo = @TipoDocumento";
                    SqlCommand actualizarConsecutivoCmd = new SqlCommand(actualizarConsecutivoQuery, c.ConectarBD, transaction);
                    actualizarConsecutivoCmd.Parameters.AddWithValue("@TipoDocumento", tipoDocumentoId);
                    actualizarConsecutivoCmd.ExecuteNonQuery();

                    string insertarDocumentoQuery = "INSERT INTO Documentos (tipo, fechaCreacion, consecutivo, idCliente, idTrabajador, totalImpuestos, subtotal) " +
                        "VALUES (@TipoDocumento, @FechaCreacion, @Consecutivo, @IdCliente, @IdTrabajador, @TotalImpuestos, @Subtotal); " +
                        "SELECT SCOPE_IDENTITY();";
                    SqlCommand insertarDocumentoCmd = new SqlCommand(insertarDocumentoQuery, c.ConectarBD, transaction);
                    insertarDocumentoCmd.Parameters.AddWithValue("@TipoDocumento", tipoDocumentoId);
                    insertarDocumentoCmd.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
                    insertarDocumentoCmd.Parameters.AddWithValue("@Consecutivo", consecutivo);
                    insertarDocumentoCmd.Parameters.AddWithValue("@IdCliente", string.IsNullOrEmpty(informacionCliente) ? (object)DBNull.Value : informacionCliente);
                    insertarDocumentoCmd.Parameters.AddWithValue("@IdTrabajador", this.idTrabajador);
                    insertarDocumentoCmd.Parameters.AddWithValue("@TotalImpuestos", totalImpuestos);
                    insertarDocumentoCmd.Parameters.AddWithValue("@Subtotal", subtotal);
                    int idDocumento = Convert.ToInt32(insertarDocumentoCmd.ExecuteScalar());

                    foreach (DataGridViewRow fila in DGVCarrito.Rows)
                    {
                        int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                        int codigoProd = Convert.ToInt32(fila.Cells["Codigo"].Value);
                        decimal subtotalLinea = Convert.ToDecimal(fila.Cells["Subtotal"].Value);
                        decimal impuestoLinea = Convert.ToDecimal(fila.Cells["Impuesto"].Value);

                        string verificarProductoQuery = "SELECT COUNT(*) FROM Productos WHERE codigoProd = @CodigoProd";
                        SqlCommand verificarProductoCmd = new SqlCommand(verificarProductoQuery, c.ConectarBD, transaction);
                        verificarProductoCmd.Parameters.AddWithValue("@CodigoProd", codigoProd);
                        int productoExiste = Convert.ToInt32(verificarProductoCmd.ExecuteScalar());

                        if (productoExiste > 0)
                        {
                            string insertarLineaQuery = "INSERT INTO Lineas (cantidad, codigoProd, subtotal, impuesto, idDocumento) " +
                            "VALUES (@Cantidad, @CodigoProd, @Subtotal, @Impuesto, @IdDocumento)";
                            SqlCommand insertarLineaCmd = new SqlCommand(insertarLineaQuery, c.ConectarBD, transaction);
                            insertarLineaCmd.Parameters.AddWithValue("@Cantidad", cantidad);
                            insertarLineaCmd.Parameters.AddWithValue("@CodigoProd", codigoProd);
                            insertarLineaCmd.Parameters.AddWithValue("@Subtotal", subtotalLinea);
                            insertarLineaCmd.Parameters.AddWithValue("@Impuesto", impuestoLinea);
                            insertarLineaCmd.Parameters.AddWithValue("@IdDocumento", idDocumento);
                            insertarLineaCmd.ExecuteNonQuery();

                            string actualizarCantidadQuery = "UPDATE Productos SET cantidadInv = cantidadInv - @Cantidad WHERE codigoProd = @CodigoProd";
                            SqlCommand actualizarCantidadCmd = new SqlCommand(actualizarCantidadQuery, c.ConectarBD, transaction);
                            actualizarCantidadCmd.Parameters.AddWithValue("@Cantidad", cantidad);
                            actualizarCantidadCmd.Parameters.AddWithValue("@CodigoProd", codigoProd);
                            actualizarCantidadCmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();

                    MessageBox.Show("Documento y líneas creados correctamente.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al crear el documento: " + ex.Message);
                }
                finally
                {
                    c.cerrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
            }

            LimpiarCarrito();
            ActualizarTotales();
        }


        private void LimpiarCarrito() {
            DGVCarrito.Rows.Clear();
            numCantidad.Value = 1;
            textTotales.Clear();
            comboBoxTipoDoc.SelectedIndex = 0;
            textIDCliente.Clear();
            CargarInventario();
            CargarDocumentos();
        }
		private void ActualizarTotales() {
			decimal totalImpuestos = 0;
			decimal subtotal = 0;
			int cantidad = 0;
			foreach (DataGridViewRow fila in DGVCarrito.Rows) {
				subtotal += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
				totalImpuestos += subtotal * 0.13m;
				cantidad += Convert.ToInt16(fila.Cells["Cantidad"].Value);
			}
			textTotales.Text = $"Total impuestos: {totalImpuestos:C}\n" +
							   $"Subtotal: {subtotal:C}\n" +
							   $"Total del documento: {(totalImpuestos + subtotal):C}\n" +
							   $"Cantidad de productos: {cantidad}";
		}

		// CÓDIGO PARA VERIFICACIÓN DE CÉDULA DE CLIENTE
		
		private void textIDCliente_Enter(object sender, EventArgs e) {
			if (this.textIDCliente.Text == "Ej: 123456789") {
				this.textIDCliente.Text = "";
			}
			this.textIDCliente.ForeColor = Color.Black;
		}

		private void textIDCliente_Leave(object sender, EventArgs e) {

			if (this.textIDCliente.Text == "") {
				this.textIDCliente.Text = "Ej: 123456789";
				this.textIDCliente.ForeColor = Color.Silver;
				return;
			}

			if (this.txtID_Founded.Text.Equals(this.textIDCliente.Text)) {
				return;
			}

			string clientInfo = getClientID(this.textIDCliente.Text);

			if (clientInfo != null && !clientInfo[0].Equals('0')) {

				string[] cI     = clientInfo.Split(',');

				this.lbClientID.Text = "Identificación:";
				this.lbName.Text	 = "Nombre Completo:";

				this.txtID_Founded.Text		 = cI[0];
				this.txtName_Founded.Text	 = cI[1];

				this.lbClientID.Visible		 = true;
				this.lbName.Visible			 = true;
				this.txtName_Founded.Visible = true;
				this.txtID_Founded.Visible 	 = true;

				return;
			}
			this.lbName.Visible			 = false;
			this.txtName_Founded.Visible = false;
			this.txtID_Founded.Visible	 = false;
			this.lbClientID.Visible		 = false;

			this.lbClientID.Text		 = "";
			this.lbName.Text			 = "";
			this.txtID_Founded.Text		 = "";
			this.txtName_Founded.Text	 = "";
			this.textIDCliente.ForeColor = System.Drawing.Color.Red;
		}

		private string getClientID(string pID) {
			string clientInfo = null;
			if (this.textIDCliente.Text != "" || this.textIDCliente.Text != null) {
				if (EsNumeroValido(this.textIDCliente.Text) && this.textIDCliente.Text.Length >= 9) {
					VerifyID idVerify = new VerifyID();
					clientInfo = idVerify.verifyID(this.textIDCliente.Text);
				}
			}
			return clientInfo;
		}

		private bool EsNumeroValido(string cadena) {
			foreach (char c in cadena) {
				if (!char.IsDigit(c))
					return false;
			}
			return true;
		}

		////////////////////////////////////////////////////////////////////////////
	}
}
