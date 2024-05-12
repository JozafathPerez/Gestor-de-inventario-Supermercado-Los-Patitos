namespace Gestor_de_inventario_Supermercado_Los_Patitos
{
    partial class VentanaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BT_reporteria = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BT_ventas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_inventario = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BT_empleados = new System.Windows.Forms.Button();
            this.ImagenPatito = new System.Windows.Forms.PictureBox();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.PanelAreaDeTrabajo = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPatito)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.ImagenPatito);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(240, 662);
            this.sidebar.MinimumSize = new System.Drawing.Size(65, 662);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(240, 662);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 121);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::Gestor_de_inventario_Supermercado_Los_Patitos.Properties.Resources.Logo_de_menu;
            this.menuButton.Location = new System.Drawing.Point(3, 29);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(53, 49);
            this.menuButton.TabIndex = 1;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BT_reporteria);
            this.panel3.Location = new System.Drawing.Point(3, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 73);
            this.panel3.TabIndex = 2;
            // 
            // BT_reporteria
            // 
            this.BT_reporteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BT_reporteria.FlatAppearance.BorderSize = 0;
            this.BT_reporteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_reporteria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_reporteria.ForeColor = System.Drawing.Color.White;
            this.BT_reporteria.Image = ((System.Drawing.Image)(resources.GetObject("BT_reporteria.Image")));
            this.BT_reporteria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_reporteria.Location = new System.Drawing.Point(0, 0);
            this.BT_reporteria.Name = "BT_reporteria";
            this.BT_reporteria.Size = new System.Drawing.Size(237, 73);
            this.BT_reporteria.TabIndex = 0;
            this.BT_reporteria.Text = "               Reportería";
            this.BT_reporteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_reporteria.UseVisualStyleBackColor = true;
            this.BT_reporteria.Click += new System.EventHandler(this.BT_reporteria_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BT_ventas);
            this.panel4.Location = new System.Drawing.Point(3, 209);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 68);
            this.panel4.TabIndex = 3;
            // 
            // BT_ventas
            // 
            this.BT_ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BT_ventas.FlatAppearance.BorderSize = 0;
            this.BT_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ventas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ventas.ForeColor = System.Drawing.Color.White;
            this.BT_ventas.Image = global::Gestor_de_inventario_Supermercado_Los_Patitos.Properties.Resources.Logo_de_ventas;
            this.BT_ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_ventas.Location = new System.Drawing.Point(0, 0);
            this.BT_ventas.Margin = new System.Windows.Forms.Padding(0);
            this.BT_ventas.Name = "BT_ventas";
            this.BT_ventas.Size = new System.Drawing.Size(234, 68);
            this.BT_ventas.TabIndex = 0;
            this.BT_ventas.Text = "               Ventas";
            this.BT_ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_ventas.UseVisualStyleBackColor = true;
            this.BT_ventas.Click += new System.EventHandler(this.BT_ventas_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BT_inventario);
            this.panel2.Location = new System.Drawing.Point(3, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 67);
            this.panel2.TabIndex = 4;
            // 
            // BT_inventario
            // 
            this.BT_inventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BT_inventario.FlatAppearance.BorderSize = 0;
            this.BT_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_inventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_inventario.ForeColor = System.Drawing.Color.White;
            this.BT_inventario.Image = global::Gestor_de_inventario_Supermercado_Los_Patitos.Properties.Resources.Logo_de_inventario;
            this.BT_inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_inventario.Location = new System.Drawing.Point(0, 0);
            this.BT_inventario.Name = "BT_inventario";
            this.BT_inventario.Size = new System.Drawing.Size(234, 67);
            this.BT_inventario.TabIndex = 0;
            this.BT_inventario.Text = "               Inventario";
            this.BT_inventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_inventario.UseVisualStyleBackColor = true;
            this.BT_inventario.Click += new System.EventHandler(this.BT_inventario_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BT_empleados);
            this.panel5.Location = new System.Drawing.Point(3, 356);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 71);
            this.panel5.TabIndex = 3;
            // 
            // BT_empleados
            // 
            this.BT_empleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BT_empleados.FlatAppearance.BorderSize = 0;
            this.BT_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_empleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_empleados.ForeColor = System.Drawing.Color.White;
            this.BT_empleados.Image = global::Gestor_de_inventario_Supermercado_Los_Patitos.Properties.Resources.Logo_de_empleados;
            this.BT_empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_empleados.Location = new System.Drawing.Point(0, 0);
            this.BT_empleados.Name = "BT_empleados";
            this.BT_empleados.Size = new System.Drawing.Size(237, 71);
            this.BT_empleados.TabIndex = 0;
            this.BT_empleados.Text = "               Empleados";
            this.BT_empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_empleados.UseVisualStyleBackColor = true;
            this.BT_empleados.Click += new System.EventHandler(this.BT_empleados_Click);
            // 
            // ImagenPatito
            // 
            this.ImagenPatito.Image = global::Gestor_de_inventario_Supermercado_Los_Patitos.Properties.Resources.SUPERMERCADO_LOS_PATITOS__LOGOSINFONDO_;
            this.ImagenPatito.Location = new System.Drawing.Point(3, 433);
            this.ImagenPatito.Name = "ImagenPatito";
            this.ImagenPatito.Size = new System.Drawing.Size(237, 217);
            this.ImagenPatito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenPatito.TabIndex = 5;
            this.ImagenPatito.TabStop = false;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // PanelAreaDeTrabajo
            // 
            this.PanelAreaDeTrabajo.Location = new System.Drawing.Point(65, 0);
            this.PanelAreaDeTrabajo.Name = "PanelAreaDeTrabajo";
            this.PanelAreaDeTrabajo.Size = new System.Drawing.Size(1069, 662);
            this.PanelAreaDeTrabajo.TabIndex = 1;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 662);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.PanelAreaDeTrabajo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaPrincipal";
            this.Text = "Ventana Principal";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPatito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BT_reporteria;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BT_ventas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BT_empleados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BT_inventario;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel PanelAreaDeTrabajo;
        private System.Windows.Forms.PictureBox ImagenPatito;
    }
}