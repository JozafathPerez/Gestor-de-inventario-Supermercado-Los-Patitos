using Gestor_de_inventario__Super_Los_Patitos_;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        /// <summary>
        /// Funcion encargada de cargar los productos de la base de datos
        /// </summary>
		private void CargarInventario() {
			try {
				c.abrir();
				string consulta = "SELECT codigoProd AS 'Codigo', nombre AS 'Nombre', categoria AS 'Categoria', tipoMedida AS 'Medida', cantidadInv AS 'Cantidad', precioUnit AS 'Precio' FROM Productos; ";
				SqlDataAdapter adaptador = new SqlDataAdapter(consulta, c.ConectarBD);
				DataTable tabla = new DataTable();
				adaptador.Fill(tabla);
				DGVInventario.DataSource = tabla;
				c.cerrar();
			} catch (Exception ex) {
				MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
        /// <summary>
        /// Funcion encargada de cargar los documentos de la base de datos
        /// </summary>
		private void CargarDocumentos() {
			try {
				c.abrir();
				string consulta = "SELECT idDocumento AS 'ID', tipo AS 'Tipo', fechaCreacion AS 'Fecha de Creacion', consecutivo AS 'Consecutivo', idCliente AS 'ID del Cliente', idTrabajador AS 'ID del Trabajador', totalImpuestos AS 'Total de Impuestos', subtotal AS 'Subtotal', idNotaCredito AS 'Nota de Credito' FROM Documentos;";
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
                    foreach (DataGridViewRow fila in DGVCarrito.Rows){
                        subtotal += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
                        totalImpuestos += Convert.ToDecimal(fila.Cells["Impuesto"].Value);
                    }

                    SqlCommand obtenerConsecutivoCmd = new SqlCommand("ObtenerConsecutivo", c.ConectarBD, transaction);
                    obtenerConsecutivoCmd.CommandType = CommandType.StoredProcedure;
                    obtenerConsecutivoCmd.Parameters.AddWithValue("@TipoDocumento", tipoDocumentoId);
                    SqlParameter consecutivoParam = new SqlParameter("@Consecutivo", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    obtenerConsecutivoCmd.Parameters.Add(consecutivoParam);
                    obtenerConsecutivoCmd.ExecuteNonQuery();
                    int consecutivo = (int)consecutivoParam.Value;

                    SqlCommand actualizarConsecutivoCmd = new SqlCommand("ActualizarConsecutivo", c.ConectarBD, transaction);
                    actualizarConsecutivoCmd.CommandType = CommandType.StoredProcedure;
                    actualizarConsecutivoCmd.Parameters.AddWithValue("@TipoDocumento", tipoDocumentoId);
                    actualizarConsecutivoCmd.ExecuteNonQuery();

                    SqlCommand insertarDocumentoCmd = new SqlCommand("InsertarDocumento", c.ConectarBD, transaction);
                    insertarDocumentoCmd.CommandType = CommandType.StoredProcedure;
                    insertarDocumentoCmd.Parameters.AddWithValue("@TipoDocumento", tipoDocumentoId);
                    insertarDocumentoCmd.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
                    insertarDocumentoCmd.Parameters.AddWithValue("@Consecutivo", consecutivo);
                    insertarDocumentoCmd.Parameters.AddWithValue("@IdCliente", string.IsNullOrEmpty(informacionCliente) ? (object)DBNull.Value : informacionCliente);
                    insertarDocumentoCmd.Parameters.AddWithValue("@IdTrabajador", this.idTrabajador);
                    insertarDocumentoCmd.Parameters.AddWithValue("@TotalImpuestos", totalImpuestos);
                    insertarDocumentoCmd.Parameters.AddWithValue("@Subtotal", subtotal);
                    SqlParameter idDocumentoParam = new SqlParameter("@IdDocumento", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    insertarDocumentoCmd.Parameters.Add(idDocumentoParam);
                    insertarDocumentoCmd.ExecuteNonQuery();
                    int idDocumento = (int)idDocumentoParam.Value;

                    foreach (DataGridViewRow fila in DGVCarrito.Rows)
                    {
                        int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                        int codigoProd = Convert.ToInt32(fila.Cells["Codigo"].Value);
                        decimal subtotalLinea = Convert.ToDecimal(fila.Cells["Subtotal"].Value);
                        decimal impuestoLinea = Convert.ToDecimal(fila.Cells["Impuesto"].Value);

                        SqlCommand verificarProductoCmd = new SqlCommand("VerificarProducto", c.ConectarBD, transaction);
                        verificarProductoCmd.CommandType = CommandType.StoredProcedure;
                        verificarProductoCmd.Parameters.AddWithValue("@CodigoProd", codigoProd);
                        SqlParameter productoExisteParam = new SqlParameter("@ProductoExiste", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        verificarProductoCmd.Parameters.Add(productoExisteParam);
                        verificarProductoCmd.ExecuteNonQuery();
                        int productoExiste = (int)productoExisteParam.Value;

                        if (productoExiste > 0){
                            SqlCommand insertarLineaCmd = new SqlCommand("InsertarLinea", c.ConectarBD, transaction);
                            insertarLineaCmd.CommandType = CommandType.StoredProcedure;
                            insertarLineaCmd.Parameters.AddWithValue("@Cantidad", cantidad);
                            insertarLineaCmd.Parameters.AddWithValue("@CodigoProd", codigoProd);
                            insertarLineaCmd.Parameters.AddWithValue("@Subtotal", subtotalLinea);
                            insertarLineaCmd.Parameters.AddWithValue("@Impuesto", impuestoLinea);
                            insertarLineaCmd.Parameters.AddWithValue("@IdDocumento", idDocumento);
                            insertarLineaCmd.ExecuteNonQuery();

                            SqlCommand actualizarCantidadCmd = new SqlCommand("ActualizarCantidadProducto", c.ConectarBD, transaction);
                            actualizarCantidadCmd.CommandType = CommandType.StoredProcedure;
                            actualizarCantidadCmd.Parameters.AddWithValue("@Cantidad", cantidad);
                            actualizarCantidadCmd.Parameters.AddWithValue("@CodigoProd", codigoProd);
                            actualizarCantidadCmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    if (tipoDocumento == "Factura")
                    {
                        MessageBox.Show("Documento y líneas creados correctamente.");

                        DialogResult resultado = MessageBox.Show("¿Quieres recibir un correo de tu Documento?", "Correo", MessageBoxButtons.YesNo);
                        if (resultado == DialogResult.Yes)
                        {
                            string obemial = "SELECT email FROM Personal WHERE idTrabajador = @idTrabajador";
                            SqlCommand getemail = new SqlCommand(obemial, c.ConectarBD, transaction);
                            getemail.Parameters.AddWithValue("@idTrabajador", this.idTrabajador);
                            object res = getemail.ExecuteScalar();
                            if (res != null)
                            {
                                string email = res.ToString();
                                enviarDocumento(email, idDocumento);
                            }
                            else
                            {
                                throw new Exception("No se encontró ningún trabajador");
                            }
                        }
                    }
                }
                catch (Exception ex){
                    transaction.Rollback();
                    MessageBox.Show("Error al crear el documento: " + ex.Message);
                }
                finally{c.cerrar();}
            }
            catch (Exception ex){MessageBox.Show("Error al abrir la conexión: " + ex.Message);}

            LimpiarCarrito();
            ActualizarTotales();
        }

        /// <summary>
        /// Funcion para enviar un correo al crear un documento
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="idDocumento"></param>
        private void enviarDocumento(string correo, int idDocumento)
        {
            new Facturacion().enviarFactura(correo, idDocumento);
            Console.WriteLine("El correo del trabajador que hizo el documento {0} es: {1}", idDocumento, correo);
        }
        /// <summary>
        /// Se encarga de limpiar los espacios y refrescar todos los datos
        /// </summary>
        private void LimpiarCarrito() {
            this.lbName.Visible = false;
            this.txtName_Founded.Visible = false;
            this.txtID_Founded.Visible = false;
            this.lbClientID.Visible = false;
            this.lbClientID.Text = "";
            this.lbName.Text = "";
            this.txtID_Founded.Text = "";
            this.txtName_Founded.Text = "";
            this.textIDCliente.ForeColor = System.Drawing.Color.Red;
            DGVCarrito.Rows.Clear();
            numCantidad.Value = 1;
            comboBoxTipoDoc.SelectedIndex = 0;
            textIDCliente.Clear();
            CargarInventario();
            CargarDocumentos();
        }
        /// <summary>
        /// Calcula y muestra los totales esperados de una compra
        /// </summary>
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

        /// <summary>
        /// Verifica que una cadena sea numero valido
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
		private bool EsNumeroValido(string cadena) {
			foreach (char c in cadena) {
				if (!char.IsDigit(c))
					return false;
			}
			return true;
		}

        private void bNotaCredito_Click(object sender, EventArgs e)
        {
            if (DGVDocumentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un documento de la lista de facturas.");
                return;
            }

            int idDocumentoReferencia = Convert.ToInt32(DGVDocumentos.SelectedRows[0].Cells["ID"].Value);
            int tipoDocumentoReferencia = Convert.ToInt32(DGVDocumentos.SelectedRows[0].Cells["Tipo"].Value);

            if (tipoDocumentoReferencia == 3)
            {
                MessageBox.Show("Solo se pueden anular notas de credito.");
                return;
            }

            try
            {
                c.abrir();
                SqlTransaction transaction = c.ConectarBD.BeginTransaction();

                try
                {
                    string verificarAnulacionQuery = "SELECT idNotaCredito FROM Documentos WHERE idDocumento = @IdDocumentoReferencia";
                    SqlCommand verificarAnulacionCmd = new SqlCommand(verificarAnulacionQuery, c.ConectarBD, transaction);
                    verificarAnulacionCmd.Parameters.AddWithValue("@IdDocumentoReferencia", idDocumentoReferencia);
                    object idNotaCredito = verificarAnulacionCmd.ExecuteScalar();
                    if (idNotaCredito != DBNull.Value)
                    {
                        throw new Exception("Este documento ya ha sido anulado.");
                    }

                    string idCliente = DGVDocumentos.SelectedRows[0].Cells["Id del Cliente"].Value.ToString();
                    int idTrabajador = this.idTrabajador;
                    decimal totalImpuestos = Convert.ToDecimal(DGVDocumentos.SelectedRows[0].Cells["Total de Impuestos"].Value);
                    decimal subtotal = Convert.ToDecimal(DGVDocumentos.SelectedRows[0].Cells["Subtotal"].Value);

                    SqlCommand obtenerConsecutivoCmd = new SqlCommand("ObtenerConsecutivo", c.ConectarBD, transaction);
                    obtenerConsecutivoCmd.CommandType = CommandType.StoredProcedure;
                    obtenerConsecutivoCmd.Parameters.AddWithValue("@TipoDocumento", 3);
                    SqlParameter consecutivoParam = new SqlParameter("@Consecutivo", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    obtenerConsecutivoCmd.Parameters.Add(consecutivoParam);
                    obtenerConsecutivoCmd.ExecuteNonQuery();
                    int consecutivo = (int)consecutivoParam.Value;

                    SqlCommand actualizarConsecutivoCmd = new SqlCommand("ActualizarConsecutivo", c.ConectarBD, transaction);
                    actualizarConsecutivoCmd.CommandType = CommandType.StoredProcedure;
                    actualizarConsecutivoCmd.Parameters.AddWithValue("@TipoDocumento", 3);
                    actualizarConsecutivoCmd.ExecuteNonQuery();

                    SqlCommand insertarDocumentoCmd = new SqlCommand("InsertarDocumento", c.ConectarBD, transaction);
                    insertarDocumentoCmd.CommandType = CommandType.StoredProcedure;
                    insertarDocumentoCmd.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("@TipoDocumento", 3),
                        new SqlParameter("@FechaCreacion", DateTime.Now),
                        new SqlParameter("@Consecutivo", consecutivo),
                        new SqlParameter("@IdCliente", string.IsNullOrEmpty(idCliente) ? (object)DBNull.Value : idCliente),
                        new SqlParameter("@IdTrabajador", idTrabajador),
                        new SqlParameter("@TotalImpuestos", totalImpuestos),
                        new SqlParameter("@Subtotal", subtotal),
                        new SqlParameter("@IdDocumento", SqlDbType.Int) { Direction = ParameterDirection.Output }
                    });
                    insertarDocumentoCmd.ExecuteNonQuery();
                    int idDocumentoNotaCredito = (int)((SqlParameter)insertarDocumentoCmd.Parameters["@IdDocumento"]).Value;

                    string obtenerLineasQuery = "SELECT cantidad, codigoProd, subtotal, impuesto FROM Lineas WHERE idDocumento = @IdDocumentoReferencia";
                    SqlCommand obtenerLineasCmd = new SqlCommand(obtenerLineasQuery, c.ConectarBD, transaction);
                    obtenerLineasCmd.Parameters.AddWithValue("@IdDocumentoReferencia", idDocumentoReferencia);
                    SqlDataReader lineasReader = obtenerLineasCmd.ExecuteReader();
                    List<(int cantidad, int codigoProd, decimal subtotalLinea, decimal impuestoLinea)> lineas = new List<(int, int, decimal, decimal)>();

                    while (lineasReader.Read())
                    {
                        int cantidad = Convert.ToInt32(lineasReader["cantidad"]);
                        int codigoProd = Convert.ToInt32(lineasReader["codigoProd"]);
                        decimal subtotalLinea = Convert.ToDecimal(lineasReader["subtotal"]);
                        decimal impuestoLinea = Convert.ToDecimal(lineasReader["impuesto"]);

                        lineas.Add((cantidad, codigoProd, subtotalLinea, impuestoLinea));
                    }
                    lineasReader.Close();

                    foreach (var linea in lineas)
                    {
                        int cantidad = linea.cantidad;
                        int codigoProd = linea.codigoProd;
                        decimal subtotalLinea = linea.subtotalLinea;
                        decimal impuestoLinea = linea.impuestoLinea;

                        SqlCommand insertarLineaCmd = new SqlCommand("InsertarLinea", c.ConectarBD, transaction);
                        insertarLineaCmd.CommandType = CommandType.StoredProcedure;
                        insertarLineaCmd.Parameters.AddRange(new SqlParameter[]
                        {
                            new SqlParameter("@Cantidad", cantidad),
                            new SqlParameter("@CodigoProd", codigoProd),
                            new SqlParameter("@Subtotal", subtotalLinea),
                            new SqlParameter("@Impuesto", impuestoLinea),
                            new SqlParameter("@IdDocumento", idDocumentoNotaCredito)
                        });
                        insertarLineaCmd.ExecuteNonQuery();

                        SqlCommand actualizarCantidadCmd = new SqlCommand("ActualizarCantidadProductoAnulacion", c.ConectarBD, transaction);
                        actualizarCantidadCmd.CommandType = CommandType.StoredProcedure;
                        actualizarCantidadCmd.Parameters.AddRange(new SqlParameter[]
                        {
                            new SqlParameter("@Cantidad", cantidad),
                            new SqlParameter("@CodigoProd", codigoProd)
                        });
                        actualizarCantidadCmd.ExecuteNonQuery();
                    }

                    string actualizarDocumentoReferenciaQuery = "UPDATE Documentos SET idNotaCredito = @IdNotaCredito WHERE idDocumento = @IdDocumentoReferencia";
                    SqlCommand actualizarDocumentoReferenciaCmd = new SqlCommand(actualizarDocumentoReferenciaQuery, c.ConectarBD, transaction);
                    actualizarDocumentoReferenciaCmd.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("@IdNotaCredito", idDocumentoNotaCredito),
                        new SqlParameter("@IdDocumentoReferencia", idDocumentoReferencia)
                    });
                    actualizarDocumentoReferenciaCmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Nota de Crédito generada correctamente.");

                    LimpiarCarrito();
                    ActualizarTotales();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al generar la Nota de Crédito: " + ex.Message);
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
        }

        private void textIDCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.textIDCliente.Text == "")
            {
                return;
            }

            if (this.txtID_Founded.Text.Equals(this.textIDCliente.Text))
            {
                return;
            }

            string clientInfo = getClientID(this.textIDCliente.Text);

            if (clientInfo != null && !clientInfo[0].Equals('0'))
            {
                string[] cI = clientInfo.Split(',');
                this.lbClientID.Text = "Identificación:";
                this.lbName.Text = "Nombre Completo:";
                this.txtID_Founded.Text = cI[0];
                this.txtName_Founded.Text = cI[1];

                this.lbClientID.Visible = true;
                this.lbName.Visible = true;
                this.txtName_Founded.Visible = true;
                this.txtID_Founded.Visible = true;
                this.textIDCliente.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbName.Visible = false;
                this.txtName_Founded.Visible = false;
                this.txtID_Founded.Visible = false;
                this.lbClientID.Visible = false;

                this.lbClientID.Text = "";
                this.lbName.Text = "";
                this.txtID_Founded.Text = "";
                this.txtName_Founded.Text = "";
                this.textIDCliente.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCarrito();
        }

        private void textBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            string busqueda = textBusqueda.Text.ToLower();
            foreach (DataGridViewRow fila in DGVInventario.Rows)
            {
                if (fila.Cells["Nombre"].Value != null)
                {
                    string nombre = fila.Cells["Nombre"].Value.ToString().ToLower();

                    if (!nombre.Contains(busqueda))
                    {
                        try
                        {
                            fila.Visible = false;
                        }
                        catch { }
                    }
                    else
                    {
                        fila.Visible = true;
                    }
                }
            }
        }


        ////////////////////////////////////////////////////////////////////////////
    }
}
