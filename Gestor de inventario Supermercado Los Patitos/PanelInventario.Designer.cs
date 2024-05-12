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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_agregarProducto = new System.Windows.Forms.Button();
            this.BT_realizarAjuste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1045, 465);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(387, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(389, 33);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar porducto :";
            // 
            // BT_agregarProducto
            // 
            this.BT_agregarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_agregarProducto.Location = new System.Drawing.Point(301, 590);
            this.BT_agregarProducto.Name = "BT_agregarProducto";
            this.BT_agregarProducto.Size = new System.Drawing.Size(173, 41);
            this.BT_agregarProducto.TabIndex = 3;
            this.BT_agregarProducto.Text = "Agregar producto";
            this.BT_agregarProducto.UseVisualStyleBackColor = true;
            this.BT_agregarProducto.Click += new System.EventHandler(this.BT_agregarProducto_Click);
            // 
            // BT_realizarAjuste
            // 
            this.BT_realizarAjuste.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_realizarAjuste.Location = new System.Drawing.Point(571, 590);
            this.BT_realizarAjuste.Name = "BT_realizarAjuste";
            this.BT_realizarAjuste.Size = new System.Drawing.Size(166, 41);
            this.BT_realizarAjuste.TabIndex = 4;
            this.BT_realizarAjuste.Text = "Realizar ajuste";
            this.BT_realizarAjuste.UseVisualStyleBackColor = true;
            this.BT_realizarAjuste.Click += new System.EventHandler(this.BT_realizarAjuste_Click);
            // 
            // PanelInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 662);
            this.Controls.Add(this.BT_realizarAjuste);
            this.Controls.Add(this.BT_agregarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1069, 662);
            this.MinimumSize = new System.Drawing.Size(1069, 662);
            this.Name = "PanelInventario";
            this.Text = "PanelInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_agregarProducto;
        private System.Windows.Forms.Button BT_realizarAjuste;
    }
}