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
    public partial class PanelVentas : Form
    {
        Conexion c;
        public PanelVentas()
        {
            InitializeComponent();
            c = new Conexion();
            CargarInventario();
            CargarDocumentos();
        }
        private void CargarInventario()
        {
            try
            {
                c.abrir();
                string consulta = "SELECT codigoProd AS 'Código del Producto', categoria AS 'Categoría', descripcion AS 'Descripción', tipoMedida AS 'Tipo de Medida', cantidad AS 'Cantidad Disponible', precioUnit AS 'Precio Unitario', fechaCaducidad AS 'Fecha de Caducidad' FROM Productos; ";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, c.ConectarBD);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                DGVInventario.DataSource = tabla;
                c.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarDocumentos()
        {
            try
            {
                c.abrir();
                string consulta = "SELECT idDocumento AS 'ID del Documento', tipo AS 'Tipo de Documento', fechaCreacion AS 'Fecha de Creación', consecutivo AS 'Consecutivo', idCliente AS 'ID del Cliente', idTrabajador AS 'ID del Trabajador', totalImpuestos AS 'Total de Impuestos', subtotal AS 'Subtotal' FROM Documentos;";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, c.ConectarBD);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                DGVDocumentos.DataSource = tabla;
                c.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            if (DGVInventario.SelectedRows.Count > 0)
            {
                if (comboBoxTipoDoc.SelectedItem.ToString() == "Factura" || comboBoxTipoDoc.SelectedItem.ToString() == "Tiquete")
                {
                    DataRowView filaSeleccionada = (DataRowView)DGVInventario.SelectedRows[0].DataBoundItem;
                    decimal precioUnitario = Convert.ToDecimal(filaSeleccionada["Precio"]);

                    int cantidad = (int)numCantidad.Value;
                    decimal subtotal = cantidad * precioUnitario;
                    decimal impuesto = 1.13m;
                    decimal total = cantidad * precioUnitario * impuesto;
                    int cantidadInventario = Convert.ToInt32(filaSeleccionada["Cantidad"]);
                    if (cantidadInventario - cantidad > -1)
                    {
                        DGVCarrito.Rows.Add(cantidad, precioUnitario, subtotal, impuesto, total);
                        filaSeleccionada["Cantidad"] = cantidadInventario - cantidad;
                        ActualizarTotales();
                    }
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
            string informacionCliente = textIDCliente.Text.Trim();
            if (tipoDocumento == "Factura")
            {
                if (string.IsNullOrEmpty(informacionCliente))
                {
                    MessageBox.Show("Debe ingresar la información del cliente.");
                    return;
                }
            }

            try
            {
                c.abrir();
                string consulta = "INSERT INTO Documentos (tipo, fechaCreacion, idCliente, idTrabajador, totalImpuestos, subtotal) " +
                    "VALUES (@TipoDocumento, @FechaCreacion, @IdCliente, @IdTrabajador, @TotalImpuestos, @Subtotal)";
                SqlCommand comando = new SqlCommand(consulta, c.ConectarBD);
                comando.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
                comando.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
                comando.Parameters.AddWithValue("@IdCliente", informacionCliente);
                comando.Parameters.AddWithValue("@IdTrabajador", 1);
                comando.Parameters.AddWithValue("@TotalImpuestos", 0);
                comando.Parameters.AddWithValue("@Subtotal", 0);
                comando.ExecuteNonQuery();

                MessageBox.Show("Documento creado correctamente.");
                c.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el documento: " + ex.Message);
            }
            ActualizarTotales();
            LimpiarCarrito();
        }

        private void ActualizarTotales()
        {
            decimal totalImpuestos = 0;
            decimal subtotal = 0;
            int cantidad = 0;
            foreach (DataGridViewRow fila in DGVCarrito.Rows)
            {
                subtotal += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
                totalImpuestos += subtotal*0.13m;
                cantidad += Convert.ToInt16(fila.Cells["Cantidad"].Value);
            }
            textTotales.Text = $"Total impuestos: {totalImpuestos:C}\n" +
                               $"Subtotal: {subtotal:C}\n" +
                               $"Total del documento: {(totalImpuestos + subtotal):C}\n" +
                               $"Cantidad de productos: {cantidad}";
        }
        private void LimpiarCarrito()
        {
            DGVCarrito.Rows.Clear();
            numCantidad.Value = 1;
            textTotales.Clear();
            comboBoxTipoDoc.SelectedIndex = -1;
            textIDCliente.Clear();
        }
    }
}
