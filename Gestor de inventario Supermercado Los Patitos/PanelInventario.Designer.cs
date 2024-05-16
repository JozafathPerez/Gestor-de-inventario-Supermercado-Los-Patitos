namespace Gestor_de_inventario_Supermercado_Los_Patitos
{
    partial class PanelInventario
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
            this.DataViewProductos = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_agregarProducto = new System.Windows.Forms.Button();
            this.BT_realizarAjuste = new System.Windows.Forms.Button();
            this.PanelAreaInventario = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEliminarProducto = new System.Windows.Forms.Button();
            this.BT_vistaAgregar = new System.Windows.Forms.Button();
            this.BT_vistaAjuste = new System.Windows.Forms.Button();
            this.buttonHistrial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewProductos)).BeginInit();
            this.PanelAreaInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataViewProductos
            // 
            this.DataViewProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.DataViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewProductos.Location = new System.Drawing.Point(12, 93);
            this.DataViewProductos.Name = "DataViewProductos";
            this.DataViewProductos.Size = new System.Drawing.Size(621, 465);
            this.DataViewProductos.TabIndex = 0;
            this.DataViewProductos.DoubleClick += new System.EventHandler(this.DataViewProductos_DoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(192, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(389, 33);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar producto :";
            // 
            // BT_agregarProducto
            // 
            this.BT_agregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(195)))), ((int)(((byte)(141)))));
            this.BT_agregarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_agregarProducto.Location = new System.Drawing.Point(669, 578);
            this.BT_agregarProducto.Name = "BT_agregarProducto";
            this.BT_agregarProducto.Size = new System.Drawing.Size(173, 41);
            this.BT_agregarProducto.TabIndex = 3;
            this.BT_agregarProducto.Text = "Guardar producto";
            this.BT_agregarProducto.UseVisualStyleBackColor = false;
            this.BT_agregarProducto.Click += new System.EventHandler(this.BT_agregarProducto_Click);
            // 
            // BT_realizarAjuste
            // 
            this.BT_realizarAjuste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(195)))), ((int)(((byte)(141)))));
            this.BT_realizarAjuste.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_realizarAjuste.Location = new System.Drawing.Point(891, 578);
            this.BT_realizarAjuste.Name = "BT_realizarAjuste";
            this.BT_realizarAjuste.Size = new System.Drawing.Size(166, 41);
            this.BT_realizarAjuste.TabIndex = 4;
            this.BT_realizarAjuste.Text = "Guardar ajuste";
            this.BT_realizarAjuste.UseVisualStyleBackColor = false;
            this.BT_realizarAjuste.Click += new System.EventHandler(this.BT_realizarAjuste_Click);
            // 
            // PanelAreaInventario
            // 
            this.PanelAreaInventario.Controls.Add(this.label2);
            this.PanelAreaInventario.Location = new System.Drawing.Point(639, 93);
            this.PanelAreaInventario.Name = "PanelAreaInventario";
            this.PanelAreaInventario.Size = new System.Drawing.Size(428, 479);
            this.PanelAreaInventario.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "      Crea un producto o un ajuste\r\n          para dezplegar la ventana\r\n";
            // 
            // buttonEliminarProducto
            // 
            this.buttonEliminarProducto.BackColor = System.Drawing.Color.IndianRed;
            this.buttonEliminarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarProducto.Location = new System.Drawing.Point(192, 581);
            this.buttonEliminarProducto.Name = "buttonEliminarProducto";
            this.buttonEliminarProducto.Size = new System.Drawing.Size(163, 38);
            this.buttonEliminarProducto.TabIndex = 6;
            this.buttonEliminarProducto.Text = "Eliminar producto";
            this.buttonEliminarProducto.UseVisualStyleBackColor = false;
            this.buttonEliminarProducto.Click += new System.EventHandler(this.buttonEliminarProducto_Click);
            // 
            // BT_vistaAgregar
            // 
            this.BT_vistaAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.BT_vistaAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_vistaAgregar.ForeColor = System.Drawing.Color.White;
            this.BT_vistaAgregar.Location = new System.Drawing.Point(669, 581);
            this.BT_vistaAgregar.Name = "BT_vistaAgregar";
            this.BT_vistaAgregar.Size = new System.Drawing.Size(173, 41);
            this.BT_vistaAgregar.TabIndex = 7;
            this.BT_vistaAgregar.Text = "Crear producto";
            this.BT_vistaAgregar.UseVisualStyleBackColor = false;
            this.BT_vistaAgregar.Click += new System.EventHandler(this.BT_vistaAgregar_Click);
            // 
            // BT_vistaAjuste
            // 
            this.BT_vistaAjuste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.BT_vistaAjuste.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_vistaAjuste.ForeColor = System.Drawing.Color.White;
            this.BT_vistaAjuste.Location = new System.Drawing.Point(891, 581);
            this.BT_vistaAjuste.Name = "BT_vistaAjuste";
            this.BT_vistaAjuste.Size = new System.Drawing.Size(166, 41);
            this.BT_vistaAjuste.TabIndex = 8;
            this.BT_vistaAjuste.Text = "Crear ajuste";
            this.BT_vistaAjuste.UseVisualStyleBackColor = false;
            this.BT_vistaAjuste.Click += new System.EventHandler(this.BT_vistaAjuste_Click);
            // 
            // buttonHistrial
            // 
            this.buttonHistrial.Location = new System.Drawing.Point(943, 35);
            this.buttonHistrial.Name = "buttonHistrial";
            this.buttonHistrial.Size = new System.Drawing.Size(114, 23);
            this.buttonHistrial.TabIndex = 9;
            this.buttonHistrial.Text = "Historial de ajustes";
            this.buttonHistrial.UseVisualStyleBackColor = true;
            this.buttonHistrial.Click += new System.EventHandler(this.buttonHistrial_Click);
            // 
            // PanelInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 662);
            this.Controls.Add(this.buttonHistrial);
            this.Controls.Add(this.BT_vistaAjuste);
            this.Controls.Add(this.BT_vistaAgregar);
            this.Controls.Add(this.buttonEliminarProducto);
            this.Controls.Add(this.PanelAreaInventario);
            this.Controls.Add(this.BT_realizarAjuste);
            this.Controls.Add(this.BT_agregarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DataViewProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1069, 662);
            this.MinimumSize = new System.Drawing.Size(1069, 662);
            this.Name = "PanelInventario";
            this.Text = "PanelInventario";
            ((System.ComponentModel.ISupportInitialize)(this.DataViewProductos)).EndInit();
            this.PanelAreaInventario.ResumeLayout(false);
            this.PanelAreaInventario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataViewProductos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_agregarProducto;
        private System.Windows.Forms.Button BT_realizarAjuste;
        private System.Windows.Forms.Panel PanelAreaInventario;
        private System.Windows.Forms.Button buttonEliminarProducto;
        private System.Windows.Forms.Button BT_vistaAgregar;
        private System.Windows.Forms.Button BT_vistaAjuste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonHistrial;
    }
}