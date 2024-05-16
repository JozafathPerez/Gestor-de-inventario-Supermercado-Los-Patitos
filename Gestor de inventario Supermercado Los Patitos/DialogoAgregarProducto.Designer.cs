namespace Gestor_de_inventario_Supermercado_Los_Patitos
{
    partial class DialogoAgregarProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.comboBoxTipoMedida = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.textBoxCantidad = new System.Windows.Forms.NumericUpDown();
            this.textBoxPrecioUnitario = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPrecioUnitario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 384);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código :\r\n\r\nNombre :\r\n\r\nCategoria :\r\n\r\nTipo de medida :\t\r\n\r\nCantidad :\t\t\r\n\r\nPreci" +
    "o unitario :\t\t\r\n\r\n";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(227, 30);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(163, 29);
            this.textBoxCodigo.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(227, 93);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(163, 29);
            this.textBoxNombre.TabIndex = 2;
            // 
            // comboBoxTipoMedida
            // 
            this.comboBoxTipoMedida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoMedida.FormattingEnabled = true;
            this.comboBoxTipoMedida.Location = new System.Drawing.Point(227, 223);
            this.comboBoxTipoMedida.Name = "comboBoxTipoMedida";
            this.comboBoxTipoMedida.Size = new System.Drawing.Size(163, 29);
            this.comboBoxTipoMedida.TabIndex = 7;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(227, 159);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(163, 29);
            this.comboBoxCategoria.TabIndex = 8;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(227, 283);
            this.textBoxCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(163, 29);
            this.textBoxCantidad.TabIndex = 9;
            // 
            // textBoxPrecioUnitario
            // 
            this.textBoxPrecioUnitario.DecimalPlaces = 2;
            this.textBoxPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecioUnitario.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.textBoxPrecioUnitario.Location = new System.Drawing.Point(227, 347);
            this.textBoxPrecioUnitario.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.textBoxPrecioUnitario.Name = "textBoxPrecioUnitario";
            this.textBoxPrecioUnitario.Size = new System.Drawing.Size(163, 29);
            this.textBoxPrecioUnitario.TabIndex = 10;
            // 
            // DialogoAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 426);
            this.Controls.Add(this.textBoxPrecioUnitario);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.comboBoxTipoMedida);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogoAgregarProducto";
            this.Text = "DialogoAgregarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPrecioUnitario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxCodigo;
        public System.Windows.Forms.TextBox textBoxNombre;
        public System.Windows.Forms.ComboBox comboBoxTipoMedida;
        public System.Windows.Forms.ComboBox comboBoxCategoria;
        public System.Windows.Forms.NumericUpDown textBoxCantidad;
        public System.Windows.Forms.NumericUpDown textBoxPrecioUnitario;
    }
}