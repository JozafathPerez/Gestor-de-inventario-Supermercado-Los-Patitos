﻿namespace Gestor_de_inventario_Supermercado_Los_Patitos {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bComprar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textTotales = new System.Windows.Forms.RichTextBox();
            this.DGVDocumentos = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.bNotaCredito = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 47);
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
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(19, 122);
            this.comboBoxTipoDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(278, 28);
            this.comboBoxTipoDoc.TabIndex = 2;
            this.comboBoxTipoDoc.Text = "Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(15, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = " Identificacion de Cliente";
            // 
            // textIDCliente
            // 
            this.textIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textIDCliente.ForeColor = System.Drawing.Color.Black;
            this.textIDCliente.Location = new System.Drawing.Point(17, 187);
            this.textIDCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textIDCliente.Name = "textIDCliente";
            this.textIDCliente.Size = new System.Drawing.Size(279, 26);
            this.textIDCliente.TabIndex = 5;
            this.textIDCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textIDCliente_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtName_Founded);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.txtID_Founded);
            this.panel1.Controls.Add(this.lbClientID);
            this.panel1.Location = new System.Drawing.Point(19, 251);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 234);
            this.panel1.TabIndex = 6;
            // 
            // txtName_Founded
            // 
            this.txtName_Founded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName_Founded.Location = new System.Drawing.Point(117, 62);
            this.txtName_Founded.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtName_Founded.Name = "txtName_Founded";
            this.txtName_Founded.Size = new System.Drawing.Size(158, 88);
            this.txtName_Founded.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(2, 62);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(111, 88);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Nombre Completo:";
            // 
            // txtID_Founded
            // 
            this.txtID_Founded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_Founded.Location = new System.Drawing.Point(117, 9);
            this.txtID_Founded.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtID_Founded.Name = "txtID_Founded";
            this.txtID_Founded.Size = new System.Drawing.Size(159, 53);
            this.txtID_Founded.TabIndex = 1;
            // 
            // lbClientID
            // 
            this.lbClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientID.Location = new System.Drawing.Point(2, 9);
            this.lbClientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClientID.Name = "lbClientID";
            this.lbClientID.Size = new System.Drawing.Size(119, 53);
            this.lbClientID.TabIndex = 0;
            this.lbClientID.Text = "Identificación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(15, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datos de Cliente";
            // 
            // DGVInventario
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.DGVInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInventario.Location = new System.Drawing.Point(310, 283);
            this.DGVInventario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVInventario.MultiSelect = false;
            this.DGVInventario.Name = "DGVInventario";
            this.DGVInventario.ReadOnly = true;
            this.DGVInventario.RowHeadersVisible = false;
            this.DGVInventario.RowHeadersWidth = 51;
            this.DGVInventario.RowTemplate.Height = 24;
            this.DGVInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVInventario.Size = new System.Drawing.Size(500, 172);
            this.DGVInventario.TabIndex = 8;
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCantidad.Location = new System.Drawing.Point(814, 283);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numCantidad.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(245, 26);
            this.numCantidad.TabIndex = 9;
            this.numCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bAgregar
            // 
            this.bAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(195)))), ((int)(((byte)(141)))));
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bAgregar.Location = new System.Drawing.Point(814, 313);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(245, 53);
            this.bAgregar.TabIndex = 10;
            this.bAgregar.Text = "Agregar al Carrito";
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(811, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad";
            // 
            // DGVCarrito
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVCarrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.DGVCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cantidad,
            this.PrecioUnitario,
            this.Subtotal,
            this.Impuesto,
            this.Total});
            this.DGVCarrito.Location = new System.Drawing.Point(310, 38);
            this.DGVCarrito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVCarrito.Name = "DGVCarrito";
            this.DGVCarrito.ReadOnly = true;
            this.DGVCarrito.RowHeadersVisible = false;
            this.DGVCarrito.RowHeadersWidth = 51;
            this.DGVCarrito.RowTemplate.Height = 24;
            this.DGVCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCarrito.Size = new System.Drawing.Size(410, 219);
            this.DGVCarrito.TabIndex = 12;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 65;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 74;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Width = 62;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "SubTotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 75;
            // 
            // Impuesto
            // 
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.MinimumWidth = 6;
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.ReadOnly = true;
            this.Impuesto.Width = 75;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 56;
            // 
            // bComprar
            // 
            this.bComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(195)))), ((int)(((byte)(141)))));
            this.bComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bComprar.Location = new System.Drawing.Point(814, 372);
            this.bComprar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bComprar.Name = "bComprar";
            this.bComprar.Size = new System.Drawing.Size(245, 53);
            this.bComprar.TabIndex = 13;
            this.bComprar.Text = "Completar Compra";
            this.bComprar.UseVisualStyleBackColor = false;
            this.bComprar.Click += new System.EventHandler(this.bComprar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(737, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Totales Previstos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(306, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Inventario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(306, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Carrito";
            // 
            // textTotales
            // 
            this.textTotales.BackColor = System.Drawing.Color.White;
            this.textTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textTotales.Location = new System.Drawing.Point(724, 38);
            this.textTotales.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textTotales.Name = "textTotales";
            this.textTotales.ReadOnly = true;
            this.textTotales.Size = new System.Drawing.Size(337, 220);
            this.textTotales.TabIndex = 18;
            this.textTotales.Text = "";
            // 
            // DGVDocumentos
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVDocumentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVDocumentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.DGVDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDocumentos.Location = new System.Drawing.Point(19, 509);
            this.DGVDocumentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVDocumentos.Name = "DGVDocumentos";
            this.DGVDocumentos.ReadOnly = true;
            this.DGVDocumentos.RowHeadersVisible = false;
            this.DGVDocumentos.RowHeadersWidth = 51;
            this.DGVDocumentos.RowTemplate.Height = 24;
            this.DGVDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDocumentos.Size = new System.Drawing.Size(791, 144);
            this.DGVDocumentos.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(16, 486);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Registro de documentos";
            // 
            // bNotaCredito
            // 
            this.bNotaCredito.BackColor = System.Drawing.Color.LightBlue;
            this.bNotaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNotaCredito.Location = new System.Drawing.Point(814, 509);
            this.bNotaCredito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bNotaCredito.Name = "bNotaCredito";
            this.bNotaCredito.Size = new System.Drawing.Size(245, 144);
            this.bNotaCredito.TabIndex = 21;
            this.bNotaCredito.Text = "Generar Nota de credito";
            this.bNotaCredito.UseVisualStyleBackColor = false;
            this.bNotaCredito.Click += new System.EventHandler(this.bNotaCredito_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.BackColor = System.Drawing.Color.IndianRed;
            this.bLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLimpiar.Location = new System.Drawing.Point(814, 431);
            this.bLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(245, 53);
            this.bLimpiar.TabIndex = 22;
            this.bLimpiar.Text = "Limpiar Espacios";
            this.bLimpiar.UseVisualStyleBackColor = false;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // textBusqueda
            // 
            this.textBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBusqueda.Location = new System.Drawing.Point(450, 459);
            this.textBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(270, 26);
            this.textBusqueda.TabIndex = 23;
            this.textBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBusqueda_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(315, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Buscar producto:";
            // 
            // PanelVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 662);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBusqueda);
            this.Controls.Add(this.bLimpiar);
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
            this.MaximumSize = new System.Drawing.Size(1069, 662);
            this.MinimumSize = new System.Drawing.Size(1023, 583);
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
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.Label label10;
    }
}