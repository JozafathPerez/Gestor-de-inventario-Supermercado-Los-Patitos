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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
			this.panel1.Location = new System.Drawing.Point(1044, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(380, 814);
			this.panel1.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(233, 25);
			this.label4.TabIndex = 33;
			this.label4.Text = "Categorías más vendidas";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 281);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(222, 25);
			this.label3.TabIndex = 32;
			this.label3.Text = "Cajeros con más ventas";
			// 
			// lbDias
			// 
			this.lbDias.AutoSize = true;
			this.lbDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDias.Location = new System.Drawing.Point(3, 544);
			this.lbDias.Name = "lbDias";
			this.lbDias.Size = new System.Drawing.Size(315, 25);
			this.lbDias.TabIndex = 31;
			this.lbDias.Text = "Días de la semana con mas ventas";
			// 
			// chFechas
			// 
			chartArea19.Name = "ChartFechas";
			this.chFechas.ChartAreas.Add(chartArea19);
			legend19.Name = "Legend1";
			this.chFechas.Legends.Add(legend19);
			this.chFechas.Location = new System.Drawing.Point(3, 562);
			this.chFechas.Name = "chFechas";
			series19.ChartArea = "ChartFechas";
			series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
			series19.IsValueShownAsLabel = true;
			series19.Legend = "Legend1";
			series19.Name = "Fechas";
			series19.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series19.YValuesPerPoint = 4;
			this.chFechas.Series.Add(series19);
			this.chFechas.Size = new System.Drawing.Size(374, 252);
			this.chFechas.TabIndex = 2;
			this.chFechas.Text = "chart3";
			// 
			// chCajeros
			// 
			chartArea20.Name = "chartCajeroFact";
			this.chCajeros.ChartAreas.Add(chartArea20);
			legend20.Name = "Legend1";
			this.chCajeros.Legends.Add(legend20);
			this.chCajeros.Location = new System.Drawing.Point(3, 299);
			this.chCajeros.Name = "chCajeros";
			this.chCajeros.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
			series20.ChartArea = "chartCajeroFact";
			series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
			series20.IsValueShownAsLabel = true;
			series20.IsVisibleInLegend = false;
			series20.Legend = "Legend1";
			series20.LegendText = " ";
			series20.Name = "Facturas";
			series20.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
			this.chCajeros.Series.Add(series20);
			this.chCajeros.Size = new System.Drawing.Size(377, 252);
			this.chCajeros.TabIndex = 1;
			this.chCajeros.Text = "chart2";
			// 
			// chCategorias
			// 
			chartArea21.Name = "ChartCategorias";
			this.chCategorias.ChartAreas.Add(chartArea21);
			legend21.Name = "Legend1";
			this.chCategorias.Legends.Add(legend21);
			this.chCategorias.Location = new System.Drawing.Point(3, 22);
			this.chCategorias.Name = "chCategorias";
			series21.ChartArea = "ChartCategorias";
			series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series21.IsValueShownAsLabel = true;
			series21.Legend = "Legend1";
			series21.Name = "Categorias";
			series21.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
			this.chCategorias.Series.Add(series21);
			this.chCategorias.Size = new System.Drawing.Size(374, 252);
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
			this.panel2.Location = new System.Drawing.Point(1, 391);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1037, 424);
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
			this.tbTopCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tbTopCashier.Location = new System.Drawing.Point(480, 165);
			this.tbTopCashier.Name = "tbTopCashier";
			this.tbTopCashier.ReadOnly = true;
			this.tbTopCashier.RowHeadersVisible = false;
			this.tbTopCashier.RowHeadersWidth = 51;
			this.tbTopCashier.RowTemplate.Height = 24;
			this.tbTopCashier.Size = new System.Drawing.Size(554, 54);
			this.tbTopCashier.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(480, 133);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(177, 29);
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
			this.tbTopProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tbTopProd.Location = new System.Drawing.Point(480, 77);
			this.tbTopProd.Name = "tbTopProd";
			this.tbTopProd.ReadOnly = true;
			this.tbTopProd.RowHeadersVisible = false;
			this.tbTopProd.RowHeadersWidth = 51;
			this.tbTopProd.RowTemplate.Height = 24;
			this.tbTopProd.Size = new System.Drawing.Size(554, 53);
			this.tbTopProd.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(480, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(253, 29);
			this.label2.TabIndex = 8;
			this.label2.Text = "Producto más vendido";
			// 
			// lbProducts
			// 
			this.lbProducts.AutoSize = true;
			this.lbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbProducts.Location = new System.Drawing.Point(6, 20);
			this.lbProducts.Name = "lbProducts";
			this.lbProducts.Size = new System.Drawing.Size(408, 29);
			this.lbProducts.TabIndex = 7;
			this.lbProducts.Text = "Top productos de los últimos 30 días";
			// 
			// lbClients
			// 
			this.lbClients.AutoSize = true;
			this.lbClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbClients.Location = new System.Drawing.Point(479, 222);
			this.lbClients.Name = "lbClients";
			this.lbClients.Size = new System.Drawing.Size(360, 29);
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
			this.tbProdVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tbProdVendidos.Location = new System.Drawing.Point(3, 52);
			this.tbProdVendidos.Name = "tbProdVendidos";
			this.tbProdVendidos.ReadOnly = true;
			this.tbProdVendidos.RowHeadersVisible = false;
			this.tbProdVendidos.RowHeadersWidth = 51;
			this.tbProdVendidos.RowTemplate.Height = 24;
			this.tbProdVendidos.Size = new System.Drawing.Size(471, 360);
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
			this.tbTopClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tbTopClientes.Location = new System.Drawing.Point(480, 254);
			this.tbTopClientes.Name = "tbTopClientes";
			this.tbTopClientes.ReadOnly = true;
			this.tbTopClientes.RowHeadersVisible = false;
			this.tbTopClientes.RowHeadersWidth = 51;
			this.tbTopClientes.RowTemplate.Height = 24;
			this.tbTopClientes.Size = new System.Drawing.Size(554, 158);
			this.tbTopClientes.TabIndex = 4;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.tbFacturasRF);
			this.panel3.Location = new System.Drawing.Point(387, 1);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(651, 391);
			this.panel3.TabIndex = 4;
			// 
			// tbFacturasRF
			// 
			this.tbFacturasRF.AllowUserToAddRows = false;
			this.tbFacturasRF.AllowUserToDeleteRows = false;
			this.tbFacturasRF.AllowUserToResizeColumns = false;
			this.tbFacturasRF.AllowUserToResizeRows = false;
			this.tbFacturasRF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tbFacturasRF.Location = new System.Drawing.Point(5, 81);
			this.tbFacturasRF.Name = "tbFacturasRF";
			this.tbFacturasRF.ReadOnly = true;
			this.tbFacturasRF.RowHeadersVisible = false;
			this.tbFacturasRF.RowHeadersWidth = 51;
			this.tbFacturasRF.RowTemplate.Height = 24;
			this.tbFacturasRF.Size = new System.Drawing.Size(643, 307);
			this.tbFacturasRF.TabIndex = 0;
			// 
			// dtpFechaInicio
			// 
			this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaInicio.Location = new System.Drawing.Point(15, 172);
			this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpFechaInicio.Name = "dtpFechaInicio";
			this.dtpFechaInicio.Size = new System.Drawing.Size(352, 27);
			this.dtpFechaInicio.TabIndex = 27;
			this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.loadInvoicesByDateRange);
			// 
			// dtpFechaFin
			// 
			this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaFin.Location = new System.Drawing.Point(15, 300);
			this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpFechaFin.Name = "dtpFechaFin";
			this.dtpFechaFin.Size = new System.Drawing.Size(352, 27);
			this.dtpFechaFin.TabIndex = 28;
			this.dtpFechaFin.ValueChanged += new System.EventHandler(this.loadInvoicesByDateRange2);
			// 
			// lbFechaInicial
			// 
			this.lbFechaInicial.AutoSize = true;
			this.lbFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFechaInicial.Location = new System.Drawing.Point(10, 145);
			this.lbFechaInicial.Name = "lbFechaInicial";
			this.lbFechaInicial.Size = new System.Drawing.Size(75, 25);
			this.lbFechaInicial.TabIndex = 12;
			this.lbFechaInicial.Text = "Desde:";
			// 
			// lbFechaFinal
			// 
			this.lbFechaFinal.AutoSize = true;
			this.lbFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFechaFinal.Location = new System.Drawing.Point(14, 273);
			this.lbFechaFinal.Name = "lbFechaFinal";
			this.lbFechaFinal.Size = new System.Drawing.Size(69, 25);
			this.lbFechaFinal.TabIndex = 29;
			this.lbFechaFinal.Text = "Hasta:";
			// 
			// lbFactRangoFechas
			// 
			this.lbFactRangoFechas.AutoSize = true;
			this.lbFactRangoFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFactRangoFechas.Location = new System.Drawing.Point(14, 82);
			this.lbFactRangoFechas.Name = "lbFactRangoFechas";
			this.lbFactRangoFechas.Size = new System.Drawing.Size(325, 29);
			this.lbFactRangoFechas.TabIndex = 30;
			this.lbFactRangoFechas.Text = "Facturas por rango de fechas";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(14, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(275, 29);
			this.label5.TabIndex = 31;
			this.label5.Text = "Sistema de Reportería";
			// 
			// PanelReporteria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1425, 815);
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
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(1425, 815);
			this.MinimumSize = new System.Drawing.Size(1425, 815);
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