﻿namespace Gestor_de_inventario_Supermercado_Los_Patitos
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
            this.PanelAreaInventario = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BT_vistaAgregar = new System.Windows.Forms.Button();
            this.BT_vistaAjuste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelAreaInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 465);
            this.dataGridView1.TabIndex = 0;
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
            this.label1.Text = "Buscar porducto :";
            // 
            // BT_agregarProducto
            // 
            this.BT_agregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(195)))), ((int)(((byte)(141)))));
            this.BT_agregarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_agregarProducto.Location = new System.Drawing.Point(669, 578);
            this.BT_agregarProducto.Name = "BT_agregarProducto";
            this.BT_agregarProducto.Size = new System.Drawing.Size(173, 41);
            this.BT_agregarProducto.TabIndex = 3;
            this.BT_agregarProducto.Text = "Agregar producto";
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
            this.PanelAreaInventario.Size = new System.Drawing.Size(428, 465);
            this.PanelAreaInventario.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "      Selecciona una vista \r\npara realizar modificaciones\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(192, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Eliminar producto";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BT_vistaAgregar
            // 
            this.BT_vistaAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.BT_vistaAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_vistaAgregar.ForeColor = System.Drawing.Color.White;
            this.BT_vistaAgregar.Location = new System.Drawing.Point(669, 578);
            this.BT_vistaAgregar.Name = "BT_vistaAgregar";
            this.BT_vistaAgregar.Size = new System.Drawing.Size(173, 41);
            this.BT_vistaAgregar.TabIndex = 7;
            this.BT_vistaAgregar.Text = "Vista de agregar";
            this.BT_vistaAgregar.UseVisualStyleBackColor = false;
            this.BT_vistaAgregar.Click += new System.EventHandler(this.BT_vistaAgregar_Click);
            // 
            // BT_vistaAjuste
            // 
            this.BT_vistaAjuste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.BT_vistaAjuste.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_vistaAjuste.ForeColor = System.Drawing.Color.White;
            this.BT_vistaAjuste.Location = new System.Drawing.Point(891, 578);
            this.BT_vistaAjuste.Name = "BT_vistaAjuste";
            this.BT_vistaAjuste.Size = new System.Drawing.Size(166, 41);
            this.BT_vistaAjuste.TabIndex = 8;
            this.BT_vistaAjuste.Text = "Vista de ajuste";
            this.BT_vistaAjuste.UseVisualStyleBackColor = false;
            this.BT_vistaAjuste.Click += new System.EventHandler(this.BT_vistaAjuste_Click);
            // 
            // PanelInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 662);
            this.Controls.Add(this.BT_vistaAjuste);
            this.Controls.Add(this.BT_vistaAgregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PanelAreaInventario);
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
            this.PanelAreaInventario.ResumeLayout(false);
            this.PanelAreaInventario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_agregarProducto;
        private System.Windows.Forms.Button BT_realizarAjuste;
        private System.Windows.Forms.Panel PanelAreaInventario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BT_vistaAgregar;
        private System.Windows.Forms.Button BT_vistaAjuste;
        private System.Windows.Forms.Label label2;
    }
}