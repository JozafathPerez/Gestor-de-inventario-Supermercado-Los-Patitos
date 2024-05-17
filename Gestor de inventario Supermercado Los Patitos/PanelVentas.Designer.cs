namespace Gestor_de_inventario_Supermercado_Los_Patitos {
	partial class PanelVentas {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textIDCliente = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtName_Founded = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.txtID_Founded = new System.Windows.Forms.Label();
			this.lbClientID = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.DGVInventario = new System.Windows.Forms.DataGridView();
			this.numCantidad = new System.Windows.Forms.NumericUpDown();
			this.bAgregar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.DGVCarrito = new System.Windows.Forms.DataGridView();
			this.bComprar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textTotales = new System.Windows.Forms.RichTextBox();
			this.DGVDocumentos = new System.Windows.Forms.DataGridView();
			this.label9 = new System.Windows.Forms.Label();
			this.bNotaCredito = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGVInventario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DGVCarrito)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DGVDocumentos)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(357, 60);
			this.label1.TabIndex = 1;
			this.label1.Text = "Centro de Ventas";
			// 
			// comboBoxTipoDoc
			// 
			this.comboBoxTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.comboBoxTipoDoc.FormattingEnabled = true;
			this.comboBoxTipoDoc.Items.AddRange(new object[] {
            "Factura",
            "Tiquete"});
			this.comboBoxTipoDoc.Location = new System.Drawing.Point(25, 150);
			this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
			this.comboBoxTipoDoc.Size = new System.Drawing.Size(369, 33);
			this.comboBoxTipoDoc.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label2.Location = new System.Drawing.Point(20, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tipo de documento";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label3.Location = new System.Drawing.Point(20, 202);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(223, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = " Identificacion de Cliente";
			// 
			// textIDCliente
			// 
			this.textIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.textIDCliente.ForeColor = System.Drawing.Color.Silver;
			this.textIDCliente.Location = new System.Drawing.Point(23, 230);
			this.textIDCliente.Name = "textIDCliente";
			this.textIDCliente.Size = new System.Drawing.Size(371, 30);
			this.textIDCliente.TabIndex = 5;
			this.textIDCliente.Text = "Ej: 123456789";
			this.textIDCliente.Enter += new System.EventHandler(this.textIDCliente_Enter);
			this.textIDCliente.Leave += new System.EventHandler(this.textIDCliente_Leave);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtName_Founded);
			this.panel1.Controls.Add(this.lbName);
			this.panel1.Controls.Add(this.txtID_Founded);
			this.panel1.Controls.Add(this.lbClientID);
			this.panel1.Location = new System.Drawing.Point(25, 309);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(371, 494);
			this.panel1.TabIndex = 6;
			// 
			// txtName_Founded
			// 
			this.txtName_Founded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName_Founded.Location = new System.Drawing.Point(157, 144);
			this.txtName_Founded.Name = "txtName_Founded";
			this.txtName_Founded.Size = new System.Drawing.Size(211, 108);
			this.txtName_Founded.TabIndex = 3;
			// 
			// lbName
			// 
			this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbName.Location = new System.Drawing.Point(3, 144);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(148, 108);
			this.lbName.TabIndex = 2;
			this.lbName.Text = "Nombre Completo:";
			// 
			// txtID_Founded
			// 
			this.txtID_Founded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID_Founded.Location = new System.Drawing.Point(156, 47);
			this.txtID_Founded.Name = "txtID_Founded";
			this.txtID_Founded.Size = new System.Drawing.Size(212, 65);
			this.txtID_Founded.TabIndex = 1;
			// 
			// lbClientID
			// 
			this.lbClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbClientID.Location = new System.Drawing.Point(3, 47);
			this.lbClientID.Name = "lbClientID";
			this.lbClientID.Size = new System.Drawing.Size(148, 65);
			this.lbClientID.TabIndex = 0;
			this.lbClientID.Text = "Identificación:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label4.Location = new System.Drawing.Point(20, 281);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(156, 25);
			this.label4.TabIndex = 7;
			this.label4.Text = "Datos de Cliente";
			// 
			// DGVInventario
			// 
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DGVInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.DGVInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVInventario.Location = new System.Drawing.Point(474, 50);
			this.DGVInventario.Name = "DGVInventario";
			this.DGVInventario.RowHeadersWidth = 51;
			this.DGVInventario.RowTemplate.Height = 24;
			this.DGVInventario.Size = new System.Drawing.Size(430, 250);
			this.DGVInventario.TabIndex = 8;
			// 
			// numCantidad
			// 
			this.numCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numCantidad.Location = new System.Drawing.Point(474, 337);
			this.numCantidad.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
			this.numCantidad.Name = "numCantidad";
			this.numCantidad.Size = new System.Drawing.Size(429, 30);
			this.numCantidad.TabIndex = 9;
			this.numCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// bAgregar
			// 
			this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.bAgregar.Location = new System.Drawing.Point(474, 373);
			this.bAgregar.Name = "bAgregar";
			this.bAgregar.Size = new System.Drawing.Size(210, 140);
			this.bAgregar.TabIndex = 10;
			this.bAgregar.Text = "Agregar al Carrito";
			this.bAgregar.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label5.Location = new System.Drawing.Point(469, 309);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 25);
			this.label5.TabIndex = 11;
			this.label5.Text = "Cantidad";
			// 
			// DGVCarrito
			// 
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DGVCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.DGVCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVCarrito.Location = new System.Drawing.Point(915, 50);
			this.DGVCarrito.Name = "DGVCarrito";
			this.DGVCarrito.RowHeadersWidth = 51;
			this.DGVCarrito.RowTemplate.Height = 24;
			this.DGVCarrito.Size = new System.Drawing.Size(430, 250);
			this.DGVCarrito.TabIndex = 12;
			// 
			// bComprar
			// 
			this.bComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.bComprar.Location = new System.Drawing.Point(694, 373);
			this.bComprar.Name = "bComprar";
			this.bComprar.Size = new System.Drawing.Size(210, 140);
			this.bComprar.TabIndex = 13;
			this.bComprar.Text = "Completar Compra";
			this.bComprar.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label6.Location = new System.Drawing.Point(910, 308);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(162, 25);
			this.label6.TabIndex = 15;
			this.label6.Text = "Totales Previstos";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label7.Location = new System.Drawing.Point(470, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(97, 25);
			this.label7.TabIndex = 16;
			this.label7.Text = "Inventario";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label8.Location = new System.Drawing.Point(910, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 25);
			this.label8.TabIndex = 17;
			this.label8.Text = "Carrito";
			// 
			// textTotales
			// 
			this.textTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.textTotales.Location = new System.Drawing.Point(915, 336);
			this.textTotales.Name = "textTotales";
			this.textTotales.Size = new System.Drawing.Size(430, 177);
			this.textTotales.TabIndex = 18;
			this.textTotales.Text = "";
			// 
			// DGVDocumentos
			// 
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DGVDocumentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			this.DGVDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVDocumentos.Location = new System.Drawing.Point(474, 553);
			this.DGVDocumentos.Name = "DGVDocumentos";
			this.DGVDocumentos.RowHeadersWidth = 51;
			this.DGVDocumentos.RowTemplate.Height = 24;
			this.DGVDocumentos.Size = new System.Drawing.Size(756, 250);
			this.DGVDocumentos.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label9.Location = new System.Drawing.Point(470, 525);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(222, 25);
			this.label9.TabIndex = 20;
			this.label9.Text = "Registro de documentos";
			// 
			// bNotaCredito
			// 
			this.bNotaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bNotaCredito.Location = new System.Drawing.Point(1236, 553);
			this.bNotaCredito.Name = "bNotaCredito";
			this.bNotaCredito.Size = new System.Drawing.Size(109, 250);
			this.bNotaCredito.TabIndex = 21;
			this.bNotaCredito.Text = "Generar Nota de credito";
			this.bNotaCredito.UseVisualStyleBackColor = true;
			// 
			// PanelVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1425, 815);
			this.Controls.Add(this.bNotaCredito);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.DGVDocumentos);
			this.Controls.Add(this.textTotales);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.bComprar);
			this.Controls.Add(this.DGVCarrito);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.bAgregar);
			this.Controls.Add(this.numCantidad);
			this.Controls.Add(this.DGVInventario);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textIDCliente);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxTipoDoc);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(1425, 815);
			this.MinimumSize = new System.Drawing.Size(1425, 815);
			this.Name = "PanelVentas";
			this.Text = "PanelVentas";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DGVInventario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DGVCarrito)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DGVDocumentos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxTipoDoc;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textIDCliente;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView DGVInventario;
		private System.Windows.Forms.NumericUpDown numCantidad;
		private System.Windows.Forms.Button bAgregar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView DGVCarrito;
		private System.Windows.Forms.Button bComprar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RichTextBox textTotales;
		private System.Windows.Forms.DataGridView DGVDocumentos;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button bNotaCredito;
		private System.Windows.Forms.Label lbClientID;
		private System.Windows.Forms.Label txtID_Founded;
		private System.Windows.Forms.Label txtName_Founded;
		private System.Windows.Forms.Label lbName;
	}
}