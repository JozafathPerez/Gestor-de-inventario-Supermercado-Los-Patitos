using Gestor_de_inventario__Super_Los_Patitos_;
using OpenQA.Selenium.DevTools.V122.DOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_inventario_Supermercado_Los_Patitos
{
    public partial class PanelInventario : Form
    {
        private Conexion conexion;
        private DialogoAgregarProducto PanelAgregar;
        private DialogoRealizarAjuste PanelAjuste;
        private int idTrabajador;
        public PanelInventario(int idTrabajador)
        {
            InitializeComponent();
            conexion = new Conexion();
            this.idTrabajador = idTrabajador;
        }

        /// <summary>
        /// Maneja el evento Load del formulario PanelInventario.
        /// Se ejecuta al cargar el formulario y realiza inicializaciones como cargar datos y configurar controles.
        /// </summary>
        private void PanelInventario_Load(object sender, EventArgs e)
        {
            actualizarDataView();
            BT_realizarAjuste.Visible = false;
            BT_agregarProducto.Visible = false;
            PanelAgregar = new DialogoAgregarProducto();
            PanelAjuste = new DialogoRealizarAjuste();
            CargarTiposMedida();
            CargarCategorias();
        }

        /// <summary>
        /// Maneja el evento Click del botón BT_agregarProducto.
        /// Se ejecuta al hacer clic en el botón "Agregar Producto" y realiza acciones relacionadas.
        /// </summary>
        private void BT_agregarProducto_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles del PanelAgregar
            string codigo = PanelAgregar.textBoxCodigo.Text;
            string nombre = PanelAgregar.textBoxNombre.Text;
            string categoria = PanelAgregar.comboBoxCategoria.Text;
            string tipoMedida = PanelAgregar.comboBoxTipoMedida.Text;
            string cantidad = PanelAgregar.textBoxCantidad.Text;
            string precioUnitario = (PanelAgregar.textBoxPrecioUnitario.Text);

            // Validar que los campos requeridos no estén vacíos
            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(categoria)  ||
                string.IsNullOrWhiteSpace(tipoMedida) ||
                string.IsNullOrWhiteSpace(cantidad) ||
                string.IsNullOrWhiteSpace(precioUnitario))
            {
                MessageBox.Show("Todos los campos son obligatorios y deben tener valores válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(codigo, out int resultado))
            {
                MessageBox.Show("El código debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (verificadorCodigo(codigo))
            {
                MessageBox.Show("El código ingresado ya pertenece a otro producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                
                {
                    conexion.abrir();

                    string query = "INSERT INTO Productos (codigoProd, nombre, categoria, tipoMedida, cantidadInv, precioUnit) " +
                                   "VALUES (@codigo, @nombre, @categoria, @tipoMedida, @cantidad, @precio)";

                    SqlCommand command = new SqlCommand(query, conexion.ConectarBD);
                    command.Parameters.AddWithValue("@codigo", Convert.ToInt32(codigo));
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@categoria", categoria);
                    command.Parameters.AddWithValue("@tipoMedida", tipoMedida);
                    command.Parameters.AddWithValue("@cantidad", Convert.ToInt32(cantidad));
                    command.Parameters.AddWithValue("@precio", Convert.ToDecimal(precioUnitario));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        actualizarDataView();
                        CargarCategorias();
                        CargarTiposMedida();
                        LimpiarControlesPanelAgregar();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento DoubleClick del DataViewProductos.
        /// Se ejecuta al hacer doble clic en una fila del DataViewProductos y realiza acciones relacionadas.
        /// </summary>
        private void DataViewProductos_DoubleClick(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila
            if (DataViewProductos.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = DataViewProductos.SelectedRows[0];

                // Obtener los valores de las celdas correspondientes
                string nombreProducto = filaSeleccionada.Cells["Nombre"].Value.ToString();
                decimal precioProducto = Convert.ToDecimal(filaSeleccionada.Cells["Precio"].Value);
                int codigoProducto = Convert.ToInt32(filaSeleccionada.Cells["Código del producto"].Value);

                // Mostrar los datos en los controles de la interfaz
                PanelAjuste.labelProducto.Text = nombreProducto;
                PanelAjuste.numericPrecio.Value = precioProducto;
                PanelAjuste.labelID.Text = codigoProducto.ToString();
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón BT_realizarAjuste.
        /// Se ejecuta al hacer clic en el botón "Realizar Ajuste" y realiza acciones relacionadas.
        /// </summary>
        private void BT_realizarAjuste_Click(object sender, EventArgs e)
        {
            MostrarBotones(true, false, false, true);

            if (string.IsNullOrWhiteSpace(PanelAjuste.textBoxRazon.Text))
            {
                MessageBox.Show("Debe ingresar una razón para realizar el ajuste.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int inserciones = 0;

            // Obtener el ID del ajuste creado
            int idAjuste = InsertarRegistroBitacora();

            if (idAjuste == -1)
            {
                MessageBox.Show("Error al insertar el registro en la Bitácora.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Iterar sobre cada fila en el dataGridSeleccionados
            foreach (DataGridViewRow fila in PanelAjuste.dataGridSeleccionados.Rows)
            {
                // Obtener los valores de la fila
                int codigoProducto = Convert.ToInt32(fila.Cells["Codigo"].Value);
                int cantidadAjuste = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);

                ActualizarCantidadProducto(codigoProducto, cantidadAjuste, precio);
                InsertarProductoAjustado(idAjuste, codigoProducto, cantidadAjuste);

                inserciones++;
            }

            if (inserciones != 0)
            {
                MessageBox.Show("Ajuste finalizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PanelAjuste.dataGridSeleccionados.Rows.Clear();
                actualizarDataView();
                LimpiarEntradas();
            }
            else
            {
                MessageBox.Show("Debe de realizar al menos un cambio en inventario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarEntradas()
        {
            PanelAjuste.labelProducto.Text = "";
            PanelAjuste.labelID.Text = "";
            PanelAjuste.numericPrecio.Value = 0;
            PanelAjuste.numericCantidad.Value = 0;
            PanelAjuste.textBoxRazon.Text = "";
        }

        /// <summary>
        /// Método para insertar un registro en la tabla BitacoraAjuste y obtener el ID del ajuste creado.
        /// </summary>
        /// <returns>El ID del ajuste creado o -1 si hay un error.</returns>
        private int InsertarRegistroBitacora()
        {
            try
            {
                DateTime fechaHora = DateTime.Now;
                string motivo = PanelAjuste.textBoxRazon.Text;

                // Query para insertar el registro en la tabla Bitacora
                string query = "INSERT INTO BitacoraAjuste (idTrabajador, fechaHora, motivo) " +
                               "OUTPUT INSERTED.IdAjuste " +
                               "VALUES (@idTrabajador, @fechaHora, @motivo)";

                using (SqlCommand command = new SqlCommand(query, conexion.ConectarBD))
                {
                    command.Parameters.AddWithValue("@idTrabajador", idTrabajador);
                    command.Parameters.AddWithValue("@fechaHora", fechaHora);
                    command.Parameters.AddWithValue("@motivo", motivo);

                    conexion.abrir();
                    int idAjuste = (int)command.ExecuteScalar(); // Obtener el IdAjuste generado
                    return idAjuste;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el registro en la Bitácora: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                conexion.cerrar();
            }
        }

        /// <summary>
        /// Método para insertar un producto ajustado en la tabla ProductosAjustados.
        /// </summary>
        /// <param name="idAjuste">El ID del ajuste asociado al producto ajustado.</param>
        /// <param name="codigoProducto">El código del producto ajustado.</param>
        /// <param name="cantidad">La cantidad ajustada del producto.</param>
        private void InsertarProductoAjustado(int idAjuste, int codigoProducto, int cantidad)
        {
            try
            {
                // Query para insertar el registro en la tabla ProductosAjustados
                string query = "INSERT INTO ProductosAjustados (IdAjuste, codigoProd, cantidad) " +
                               "VALUES (@idAjuste, @codigoProducto, @cantidad)";

                using (SqlCommand command = new SqlCommand(query, conexion.ConectarBD))
                {
                    command.Parameters.AddWithValue("@idAjuste", idAjuste);
                    command.Parameters.AddWithValue("@codigoProducto", codigoProducto);
                    command.Parameters.AddWithValue("@cantidad", cantidad);

                    conexion.abrir();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el registro en ProductosAjustados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        /// <summary>
        /// Método para actualizar la cantidad de un producto en la base de datos.
        /// </summary>
        /// <param name="codigoProducto">El código del producto a actualizar.</param>
        /// <param name="nuevaCantidad">La nueva cantidad del producto.</param>
        /// <param name="precio">El nuevo precio del producto.</param>
        private void ActualizarCantidadProducto(int codigoProducto, int nuevaCantidad, decimal precio)
        {
            try
            {
                string query = "UPDATE Productos SET cantidadInv = (cantidadInv + @nuevaCantidad), precioUnit = @precio WHERE codigoProd = @codigoProducto";
                using (SqlCommand command = new SqlCommand(query, conexion.ConectarBD))
                {
                    command.Parameters.AddWithValue("@nuevaCantidad", nuevaCantidad);
                    command.Parameters.AddWithValue("@codigoProducto", codigoProducto);
                    command.Parameters.AddWithValue("@precio", precio);

                    conexion.abrir();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected <= 0)
                    {
                        MessageBox.Show("Error al actualizar la cantidad del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la cantidad del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrar();
            }
        }


        /// <summary>
        /// Método para verificar si un código de producto ya existe en la base de datos.
        /// </summary>
        /// <param name="codigo">El código de producto a verificar.</param>
        /// <returns>True si el código existe, False si no existe o hay un error.</returns>
        private bool verificadorCodigo(string codigo)
        {
            string query = "SELECT COUNT(codigoProd) FROM Productos WHERE codigoProd = @codigo";
            using (SqlCommand command = new SqlCommand(query, conexion.ConectarBD))
            {
                command.Parameters.AddWithValue("@codigo", codigo);
                try
                {
                    conexion.abrir();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;  // Retorna verdadero si existe al menos un producto con el código dado
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar la existencia del código: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;  // Consideramos que hay un error para evitar agregar el producto
                }
                finally
                {
                    conexion.cerrar();
                }
            }
        }

        /// <summary>
        /// Método para cargar los tipos de medida en el ComboBox del PanelAgregar.
        /// </summary>
        private void CargarTiposMedida()
        {
            PanelAgregar.comboBoxTipoMedida.Items.Clear();

            string query = "SELECT DISTINCT tipoMedida FROM Productos";

            using (SqlCommand command = new SqlCommand(query, conexion.ConectarBD))
            {
                try
                {
                    conexion.abrir();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string medida = reader["tipoMedida"].ToString();
                        PanelAgregar.comboBoxTipoMedida.Items.Add(medida);                       
                    }
                   

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los tipos de medida: " + ex.Message);
                }
                finally
                {
                    conexion.cerrar();
                }
            }
        }

        /// <summary>
        /// Método para cargar las categorías en el ComboBox del PanelAgregar.
        /// </summary>
        private void CargarCategorias()
        {
            PanelAgregar.comboBoxCategoria.Items.Clear();
            string query = "SELECT DISTINCT categoria FROM Productos";

            using (SqlCommand command = new SqlCommand(query, conexion.ConectarBD))
            {
                try
                {
                    conexion.abrir();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string categoria = reader["categoria"].ToString();
                        PanelAgregar.comboBoxCategoria.Items.Add(categoria);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las categorías: " + ex.Message);
                }
                finally
                {
                    conexion.cerrar();
                }
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón BT_vistaAjuste.
        /// Se ejecuta al hacer clic en el botón "Vista Ajuste" y realiza acciones relacionadas.
        /// </summary>
        private void BT_vistaAjuste_Click(object sender, EventArgs e)
        {
            MostrarBotones(true, false, false, true);
            cargarForm(PanelAjuste);
        }

        /// <summary>
        /// Maneja el evento Click del botón BT_vistaAgregar.
        /// Se ejecuta al hacer clic en el botón "Vista Agregar" y realiza acciones relacionadas.
        /// </summary>
        private void BT_vistaAgregar_Click(object sender, EventArgs e)
        {
            MostrarBotones(false, true, true, false);
            cargarForm(PanelAgregar);
        }

        /// <summary>
        /// Método para limpiar los controles del PanelAgregar después de agregar un producto.
        /// </summary>
        private void LimpiarControlesPanelAgregar()
        {
            PanelAgregar.textBoxCodigo.Text = string.Empty;
            PanelAgregar.textBoxNombre.Text = string.Empty;
            PanelAgregar.comboBoxCategoria.Text = string.Empty;
            PanelAgregar.comboBoxTipoMedida.Text = string.Empty;
            PanelAgregar.textBoxCantidad.Value = 0;
            PanelAgregar.textBoxPrecioUnitario.Value = 0;
        }

        /// <summary>
        /// Método para mostrar u ocultar botones y paneles según la vista seleccionada.
        /// </summary>
        /// <param name="vistaAgregar">True para mostrar el botón Vista Agregar, False para ocultarlo.</param>
        /// <param name="vistaAjuste">True para mostrar el botón Vista Ajuste, False para ocultarlo.</param>
        /// <param name="agregarProducto">True para mostrar el botón Agregar Producto, False para ocultarlo.</param>
        /// <param name="realizarAjuste">True para mostrar el botón Realizar Ajuste, False para ocultarlo.</param>
        private void MostrarBotones(bool vistaAgregar, bool vistaAjuste, bool agregarProducto, bool realizarAjuste)
        {
            BT_vistaAgregar.Visible = vistaAgregar;
            BT_vistaAjuste.Visible = vistaAjuste;
            BT_agregarProducto.Visible = agregarProducto;
            BT_realizarAjuste.Visible = realizarAjuste;
        }

        /// <summary>
        /// Actualiza la vista de empleados en el DataGridView.
        /// </summary>
        /// <remarks>
        /// Obtiene los datos de los empleados de la base de datos y los muestra en el DataGridView.
        /// </remarks>
        public void actualizarDataView()
        {
            conexion.abrir();
            string query = "SELECT codigoProd AS 'Código del producto', nombre AS 'Nombre', categoria AS 'Categoría', tipoMedida AS 'Tipo de medida', cantidadInv AS 'Cantidad en inventario', precioUnit AS 'Precio' FROM Productos;";
            SqlCommand comando = new SqlCommand(query, conexion.ConectarBD);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            DataViewProductos.DataSource = tabla;
            conexion.cerrar();
        }

        /// <summary>
        /// Método para cargar un formulario en el PanelAreaInventario.
        /// </summary>
        /// <param name="Form">El formulario a cargar en el panel.</param>
        public void cargarForm(object Form)
        {
            if (this.PanelAreaInventario.Controls.Count > 0)
                this.PanelAreaInventario.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PanelAreaInventario.Controls.Add(f);
            this.PanelAreaInventario.Tag = f;
            f.Show();
        }

        /// <summary>
        /// Maneja el evento Click del botón buttonHistrial.
        /// Se ejecuta al hacer clic en el botón "Historial" y realiza acciones relacionadas.
        /// </summary>
        private void buttonHistrial_Click(object sender, EventArgs e)
        {
            cargarForm(new DialogHistorialAjustes ());
            MostrarBotones(true, true, false, false);
        }

        private void comboBoxBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            conexion.abrir();
            string busqueda = comboBoxBuscar.Text;
            string query = "SELECT codigoProd AS 'Código del producto', nombre AS 'Nombre', categoria AS 'Categoría', tipoMedida AS 'Tipo de medida', cantidadInv AS 'Cantidad en inventario', precioUnit AS 'Precio' FROM Productos WHERE nombre LIKE @busqueda;";
            SqlCommand comando = new SqlCommand(query, conexion.ConectarBD);
            comando.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            DataViewProductos.DataSource = tabla;
            conexion.cerrar();
        }

    }
}
