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
			this.chFechas = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chCajeros = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chCategorias = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chFechas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chCajeros)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chCategorias)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.chFechas);
			this.panel1.Controls.Add(this.chCajeros);
			this.panel1.Controls.Add(this.chCategorias);
			this.panel1.Location = new System.Drawing.Point(1044, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(380, 814);
			this.panel1.TabIndex = 2;
			// 
			// chFechas
			// 
			chartArea1.Name = "ChartFechas";
			this.chFechas.ChartAreas.Add(chartArea1);
			this.chFechas.Dock = System.Windows.Forms.DockStyle.Top;
			legend1.Name = "Legend1";
			this.chFechas.Legends.Add(legend1);
			this.chFechas.Location = new System.Drawing.Point(0, 504);
			this.chFechas.Name = "chFechas";
			series1.ChartArea = "ChartFechas";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
			series1.IsValueShownAsLabel = true;
			series1.Legend = "Legend1";
			series1.Name = "Fechas";
			series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.YValuesPerPoint = 4;
			this.chFechas.Series.Add(series1);
			this.chFechas.Size = new System.Drawing.Size(380, 252);
			this.chFechas.TabIndex = 2;
			this.chFechas.Text = "chart3";
			// 
			// chCajeros
			// 
			chartArea2.Name = "chartCajeroFact";
			this.chCajeros.ChartAreas.Add(chartArea2);
			this.chCajeros.Dock = System.Windows.Forms.DockStyle.Top;
			legend2.Name = "Legend1";
			this.chCajeros.Legends.Add(legend2);
			this.chCajeros.Location = new System.Drawing.Point(0, 252);
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
			this.chCajeros.Size = new System.Drawing.Size(380, 252);
			this.chCajeros.TabIndex = 1;
			this.chCajeros.Text = "chart2";
			// 
			// chCategorias
			// 
			chartArea3.Name = "ChartCategorias";
			this.chCategorias.ChartAreas.Add(chartArea3);
			this.chCategorias.Dock = System.Windows.Forms.DockStyle.Top;
			legend3.Name = "Legend1";
			this.chCategorias.Legends.Add(legend3);
			this.chCategorias.Location = new System.Drawing.Point(0, 0);
			this.chCategorias.Name = "chCategorias";
			series3.ChartArea = "ChartCategorias";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series3.IsValueShownAsLabel = true;
			series3.Legend = "Legend1";
			series3.Name = "Categorias";
			series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
			this.chCategorias.Series.Add(series3);
			this.chCategorias.Size = new System.Drawing.Size(380, 252);
			this.chCategorias.TabIndex = 0;
			// 
			// PanelReporteria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1425, 815);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(1425, 815);
			this.MinimumSize = new System.Drawing.Size(1425, 815);
			this.Name = "PanelReporteria";
			this.Text = "PanelReporteria";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chFechas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chCajeros)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chCategorias)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chFechas;
		private System.Windows.Forms.DataVisualization.Charting.Chart chCajeros;
		private System.Windows.Forms.DataVisualization.Charting.Chart chCategorias;
	}
}