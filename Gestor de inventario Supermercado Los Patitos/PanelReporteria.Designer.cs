namespace Gestor_de_inventario_Supermercado_Los_Patitos
{
    partial class PanelReporteria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDias = new System.Windows.Forms.Label();
            this.chFechas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chCajeros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chCategorias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbTopCashier = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTopProd = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.Label();
            this.lbClients = new System.Windows.Forms.Label();
            this.tbProdVendidos = new System.Windows.Forms.DataGridView();
            this.tbTopClientes = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbFacturasRF = new System.Windows.Forms.DataGridView();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lbFechaInicial = new System.Windows.Forms.Label();
            this.lbFechaFinal = new System.Windows.Forms.Label();
            this.lbFactRangoFechas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chFechas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCategorias)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTopCashier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTopProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTopClientes)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFacturasRF)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbDias);
            this.panel1.Controls.Add(this.chFechas);
            this.panel1.Controls.Add(this.chCajeros);
            this.panel1.Controls.Add(this.chCategorias);
            this.panel1.Location = new System.Drawing.Point(783, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 661);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Categorías más vendidas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Cajeros con más ventas";
            // 
            // lbDias
            // 
            this.lbDias.AutoSize = true;
            this.lbDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDias.Location = new System.Drawing.Point(2, 442);
            this.lbDias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(255, 20);
            this.lbDias.TabIndex = 31;
            this.lbDias.Text = "Días de la semana con mas ventas";
            // 
            // chFechas
            // 
            chartArea1.Name = "ChartFechas";
            this.chFechas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chFechas.Legends.Add(legend1);
            this.chFechas.Location = new System.Drawing.Point(2, 457);
            this.chFechas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chFechas.Name = "chFechas";
            series1.ChartArea = "ChartFechas";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Fechas";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series1.YValuesPerPoint = 4;
            this.chFechas.Series.Add(series1);
            this.chFechas.Size = new System.Drawing.Size(280, 205);
            this.chFechas.TabIndex = 2;
            this.chFechas.Text = "chart3";
            // 
            // chCajeros
            // 
            chartArea2.Name = "chartCajeroFact";
            this.chCajeros.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chCajeros.Legends.Add(legend2);
            this.chCajeros.Location = new System.Drawing.Point(2, 243);
            this.chCajeros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chCajeros.Name = "chCajeros";
            this.chCajeros.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "chartCajeroFact";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.LegendText = " ";
            series2.Name = "Facturas";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chCajeros.Series.Add(series2);
            this.chCajeros.Size = new System.Drawing.Size(283, 205);
            this.chCajeros.TabIndex = 1;
            this.chCajeros.Text = "chart2";
            // 
            // chCategorias
            // 
            chartArea3.Name = "ChartCategorias";
            this.chCategorias.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chCategorias.Legends.Add(legend3);
            this.chCategorias.Location = new System.Drawing.Point(2, 18);
            this.chCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chCategorias.Name = "chCategorias";
            series3.ChartArea = "ChartCategorias";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Categorias";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chCategorias.Series.Add(series3);
            this.chCategorias.Size = new System.Drawing.Size(280, 205);
            this.chCategorias.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbTopCashier);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbTopProd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbProducts);
            this.panel2.Controls.Add(this.lbClients);
            this.panel2.Controls.Add(this.tbProdVendidos);
            this.panel2.Controls.Add(this.tbTopClientes);
            this.panel2.Location = new System.Drawing.Point(1, 318);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 344);
            this.panel2.TabIndex = 3;
            // 
            // tbTopCashier
            // 
            this.tbTopCashier.AllowUserToAddRows = false;
            this.tbTopCashier.AllowUserToDeleteRows = false;
            this.tbTopCashier.AllowUserToResizeColumns = false;
            this.tbTopCashier.AllowUserToResizeRows = false;
            this.tbTopCashier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbTopCashier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tbTopCashier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.tbTopCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbTopCashier.Location = new System.Drawing.Point(360, 134);
            this.tbTopCashier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTopCashier.Name = "tbTopCashier";
            this.tbTopCashier.ReadOnly = true;
            this.tbTopCashier.RowHeadersVisible = false;
            this.tbTopCashier.RowHeadersWidth = 51;
            this.tbTopCashier.RowTemplate.Height = 24;
            this.tbTopCashier.Size = new System.Drawing.Size(416, 44);
            this.tbTopCashier.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cajero del mes";
            // 
            // tbTopProd
            // 
            this.tbTopProd.AllowUserToAddRows = false;
            this.tbTopProd.AllowUserToDeleteRows = false;
            this.tbTopProd.AllowUserToResizeColumns = false;
            this.tbTopProd.AllowUserToResizeRows = false;
            this.tbTopProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbTopProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tbTopProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.tbTopProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbTopProd.Location = new System.Drawing.Point(360, 63);
            this.tbTopProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTopProd.Name = "tbTopProd";
            this.tbTopProd.ReadOnly = true;
            this.tbTopProd.RowHeadersVisible = false;
            this.tbTopProd.RowHeadersWidth = 51;
            this.tbTopProd.RowTemplate.Height = 24;
            this.tbTopProd.Size = new System.Drawing.Size(416, 43);
            this.tbTopProd.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Producto más vendido";
            // 
            // lbProducts
            // 
            this.lbProducts.AutoSize = true;
            this.lbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducts.Location = new System.Drawing.Point(4, 16);
            this.lbProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(317, 24);
            this.lbProducts.TabIndex = 7;
            this.lbProducts.Text = "Top productos de los últimos 30 días";
            // 
            // lbClients
            // 
            this.lbClients.AutoSize = true;
            this.lbClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClients.Location = new System.Drawing.Point(359, 180);
            this.lbClients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(283, 24);
            this.lbClients.TabIndex = 6;
            this.lbClients.Text = "Top 5 clientes con más compras";
            // 
            // tbProdVendidos
            // 
            this.tbProdVendidos.AllowUserToAddRows = false;
            this.tbProdVendidos.AllowUserToDeleteRows = false;
            this.tbProdVendidos.AllowUserToResizeColumns = false;
            this.tbProdVendidos.AllowUserToResizeRows = false;
            this.tbProdVendidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbProdVendidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.tbProdVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbProdVendidos.Location = new System.Drawing.Point(2, 42);
            this.tbProdVendidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbProdVendidos.Name = "tbProdVendidos";
            this.tbProdVendidos.ReadOnly = true;
            this.tbProdVendidos.RowHeadersVisible = false;
            this.tbProdVendidos.RowHeadersWidth = 51;
            this.tbProdVendidos.RowTemplate.Height = 24;
            this.tbProdVendidos.Size = new System.Drawing.Size(353, 292);
            this.tbProdVendidos.TabIndex = 5;
            // 
            // tbTopClientes
            // 
            this.tbTopClientes.AllowUserToAddRows = false;
            this.tbTopClientes.AllowUserToDeleteRows = false;
            this.tbTopClientes.AllowUserToResizeColumns = false;
            this.tbTopClientes.AllowUserToResizeRows = false;
            this.tbTopClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbTopClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tbTopClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.tbTopClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbTopClientes.Location = new System.Drawing.Point(360, 206);
            this.tbTopClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTopClientes.Name = "tbTopClientes";
            this.tbTopClientes.ReadOnly = true;
            this.tbTopClientes.RowHeadersVisible = false;
            this.tbTopClientes.RowHeadersWidth = 51;
            this.tbTopClientes.RowTemplate.Height = 24;
            this.tbTopClientes.Size = new System.Drawing.Size(416, 128);
            this.tbTopClientes.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbFacturasRF);
            this.panel3.Location = new System.Drawing.Point(259, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 318);
            this.panel3.TabIndex = 4;
            // 
            // tbFacturasRF
            // 
            this.tbFacturasRF.AllowUserToAddRows = false;
            this.tbFacturasRF.AllowUserToDeleteRows = false;
            this.tbFacturasRF.AllowUserToResizeColumns = false;
            this.tbFacturasRF.AllowUserToResizeRows = false;
            this.tbFacturasRF.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.tbFacturasRF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbFacturasRF.Location = new System.Drawing.Point(10, 66);
            this.tbFacturasRF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFacturasRF.Name = "tbFacturasRF";
            this.tbFacturasRF.ReadOnly = true;
            this.tbFacturasRF.RowHeadersVisible = false;
            this.tbFacturasRF.RowHeadersWidth = 51;
            this.tbFacturasRF.RowTemplate.Height = 24;
            this.tbFacturasRF.Size = new System.Drawing.Size(508, 249);
            this.tbFacturasRF.TabIndex = 0;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "dd \'de\'MMMM\'de\' yyyy";
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(11, 140);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(206, 23);
            this.dtpFechaInicio.TabIndex = 27;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.loadInvoicesByDateRange);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd \'de\'MMMM\'de\' yyyy";
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(11, 244);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(206, 23);
            this.dtpFechaFin.TabIndex = 28;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.loadInvoicesByDateRange2);
            // 
            // lbFechaInicial
            // 
            this.lbFechaInicial.AutoSize = true;
            this.lbFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaInicial.Location = new System.Drawing.Point(8, 118);
            this.lbFechaInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaInicial.Name = "lbFechaInicial";
            this.lbFechaInicial.Size = new System.Drawing.Size(60, 20);
            this.lbFechaInicial.TabIndex = 12;
            this.lbFechaInicial.Text = "Desde:";
            // 
            // lbFechaFinal
            // 
            this.lbFechaFinal.AutoSize = true;
            this.lbFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaFinal.Location = new System.Drawing.Point(8, 222);
            this.lbFechaFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaFinal.Name = "lbFechaFinal";
            this.lbFechaFinal.Size = new System.Drawing.Size(56, 20);
            this.lbFechaFinal.TabIndex = 29;
            this.lbFechaFinal.Text = "Hasta:";
            // 
            // lbFactRangoFechas
            // 
            this.lbFactRangoFechas.AutoSize = true;
            this.lbFactRangoFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFactRangoFechas.Location = new System.Drawing.Point(10, 67);
            this.lbFactRangoFechas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFactRangoFechas.Name = "lbFactRangoFechas";
            this.lbFactRangoFechas.Size = new System.Drawing.Size(256, 24);
            this.lbFactRangoFechas.TabIndex = 30;
            this.lbFactRangoFechas.Text = "Facturas por rango de fechas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Sistema de Reportería";
            // 
            // PanelReporteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 662);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbFactRangoFechas);
            this.Controls.Add(this.lbFechaFinal);
            this.Controls.Add(this.lbFechaInicial);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1069, 662);
            this.MinimumSize = new System.Drawing.Size(1023, 583);
            this.Name = "PanelReporteria";
            this.Text = "PanelReporteria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chFechas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCategorias)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTopCashier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTopProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTopClientes)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbFacturasRF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chFechas;
		private System.Windows.Forms.DataVisualization.Charting.Chart chCajeros;
		private System.Windows.Forms.DataVisualization.Charting.Chart chCategorias;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView tbProdVendidos;
		private System.Windows.Forms.DataGridView tbTopClientes;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView tbFacturasRF;
		private System.Windows.Forms.Label lbClients;
		private System.Windows.Forms.Label lbProducts;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView tbTopProd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView tbTopCashier;
		private System.Windows.Forms.DateTimePicker dtpFechaInicio;
		private System.Windows.Forms.DateTimePicker dtpFechaFin;
		private System.Windows.Forms.Label lbFechaInicial;
		private System.Windows.Forms.Label lbFechaFinal;
		private System.Windows.Forms.Label lbFactRangoFechas;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbDias;
		private System.Windows.Forms.Label label5;
	}
}