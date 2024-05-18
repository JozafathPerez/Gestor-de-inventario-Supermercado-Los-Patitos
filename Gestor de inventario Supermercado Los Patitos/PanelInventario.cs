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
        private void PanelInventario_Load(object sender, EventArgs e)
        {
            actualizarDataView();
            BT_realizarAjuste.Visible = false;
            BT_agregarProducto.Visible = false;
            PanelAgregar = new DialogoAgregarProducto();
            PanelAjuste = new DialogoRealizarAjuste();
            CargarTiposMedida();
            CargarCategorias();

            // Habilitar autocompletado y configurar el modo de sugerencia
            comboBoxBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxBuscar.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxBuscar.AutoCompleteCustomSource = ObtenerSugerenciasDesdeBaseDatos(""); // Inicializar con sugerencias vacías

        }

        private void ComboBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }


        private AutoCompleteStringCollection ObtenerSugerenciasDesdeBaseDatos(string filtro)
        {
            AutoCompleteStringCollection suggestions = new AutoCompleteStringCollection();

            try
            {
                conexion.abrir();

                string[] filtros = filtro.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder queryBuilder = new StringBuilder("SELECT nombre FROM Productos WHERE 1=1");

                for (int i = 0; i < filtros.Length; i++)
                {
                    string paramName = "@filtro" + i;
                    queryBuilder.Append($" AND nombre LIKE {paramName}");
                    filtros[i] = "%" + filtros[i] + "%";
                }

                string query = queryBuilder.ToString();

                using (SqlCommand command = new SqlCommand(query, conexion.ConectarBD))
                {
                    for (int i = 0; i < filtros.Length; i++)
                    {
                        string paramName = "@filtro" + i;
                        command.Parameters.AddWithValue(paramName, filtros[i]);
                    }

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string nombreProducto = reader["nombre"].ToString();
                        suggestions.Add(nombreProducto);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener sugerencias desde la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrar();
            }

            return suggestions;
        }


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


        private void BT_realizarAjuste_Click(object sender, EventArgs e)
        {
            MostrarBotones(true, false, false, true);

            if (string.IsNullOrWhiteSpace(PanelAjuste.textBoxRazon.Text))
            {
                MessageBox.Show("Debe ingresar una razón para realizar el ajuste.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int inserciones = 0;
            // Iterar sobre cada fila en el dataGridSeleccionados
            foreach (DataGridViewRow fila in PanelAjuste.dataGridSeleccionados.Rows)
            {
                // Obtener los valores de la fila
                int codigoProducto = Convert.ToInt32(fila.Cells["Codigo"].Value);
                int cantidadAjuste = Convert.ToInt32(fila.Cells["Cantidad"].Value); 
                decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);

                ActualizarCantidadProducto(codigoProducto, cantidadAjuste, precio);
                
                inserciones++;
            }

            if (inserciones != 0)
            {
                MessageBox.Show("Ajuste finalizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PanelAjuste.dataGridSeleccionados.Rows.Clear();
                actualizarDataView();
                InsertarRegistroBitacora();
            }
            else 
            {
                MessageBox.Show("Debe de realizar al menos un cambio en inventario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertarRegistroBitacora()
        {
            try
            {
         
                DateTime fechaHora = DateTime.Now;
                // Obtener el nombre del trabajador                

                string motivo = PanelAjuste.textBoxRazon.Text;

                // Query para insertar el registro en la tabla Bitacora
                string query = "INSERT INTO Bitacora (idTrabajador, fechaHora, motivo) " +
                               "VALUES (@idTrabajador, @fechaHora, @motivo)";

                // Crear un SqlCommand para ejecutar la inserción
                using (SqlCommand command = new SqlCommand(query, conexion.ConectarBD))
                {
                    // Agregar los parámetros al comando
                    command.Parameters.AddWithValue("@idTrabajador", idTrabajador);
                    command.Parameters.AddWithValue("@fechaHora", fechaHora);
                    command.Parameters.AddWithValue("@motivo", motivo);

                    // Abrir la conexión y ejecutar la consulta
                    conexion.abrir();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el registro en la Bitácora: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión
                conexion.cerrar();
            }
        }



            // Método para actualizar la cantidad del producto en la base de datos
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

                    if (rowsAffected > 0)
                    {
                        
                    }
                    else
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

        private void buttonEliminarProducto_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (DataViewProductos.SelectedRows.Count > 0)
            {
                // Obtener el valor del código del producto de la fila seleccionada
                string codigoProducto = DataViewProductos.SelectedRows[0].Cells["Código del producto"].Value.ToString();

                // Confirmar la eliminación con un cuadro de diálogo
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        // Construir la consulta SQL para eliminar el producto
                        string query = "DELETE FROM Productos WHERE codigoProd = @codigo";
                        using (SqlCommand command = new SqlCommand(query, conexion.ConectarBD))
                        {
                            command.Parameters.AddWithValue("@codigo", codigoProducto);
                            conexion.abrir();
                            int filasEliminadas = command.ExecuteNonQuery();
                            conexion.cerrar();

                            // Verificar si se eliminó correctamente
                            if (filasEliminadas > 0)
                            {
                                MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                actualizarDataView();  // Actualizar el DataGridView
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void BT_vistaAjuste_Click(object sender, EventArgs e)
        {
            MostrarBotones(true, false, false, true);
            cargarForm(PanelAjuste);
        }

        private void BT_vistaAgregar_Click(object sender, EventArgs e)
        {
            MostrarBotones(false, true, true, false);
            cargarForm(PanelAgregar);
        }

        private void LimpiarControlesPanelAgregar()
        {
            PanelAgregar.textBoxCodigo.Text = string.Empty;
            PanelAgregar.textBoxNombre.Text = string.Empty;
            PanelAgregar.comboBoxCategoria.Text = string.Empty;
            PanelAgregar.comboBoxTipoMedida.Text = string.Empty;
            PanelAgregar.textBoxCantidad.Value = 0;
            PanelAgregar.textBoxPrecioUnitario.Value = 0;
        }

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
