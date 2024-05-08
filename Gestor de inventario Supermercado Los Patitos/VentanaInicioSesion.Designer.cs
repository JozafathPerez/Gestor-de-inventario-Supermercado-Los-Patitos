using System.Drawing;
using System.Windows.Forms;

namespace Gestor_de_inventario_Supermercado_Los_Patitos
{
    partial class VentanaInicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXT_inicioSesion = new System.Windows.Forms.Label();
            this.TEXT_cuenta = new System.Windows.Forms.TextBox();
            this.TEXT_contrasena = new System.Windows.Forms.TextBox();
            this.BT_inicioSesion = new System.Windows.Forms.Button();
            this.IMG_logoPrincipal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_logoPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_inicioSesion
            // 
            this.TXT_inicioSesion.AutoSize = true;
            this.TXT_inicioSesion.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_inicioSesion.Location = new System.Drawing.Point(329, 215);
            this.TXT_inicioSesion.Name = "TXT_inicioSesion";
            this.TXT_inicioSesion.Size = new System.Drawing.Size(278, 50);
            this.TXT_inicioSesion.TabIndex = 1;
            this.TXT_inicioSesion.Text = "Inicio de Sesión";
            // 
            // TEXT_cuenta
            // 
            this.TEXT_cuenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXT_cuenta.Location = new System.Drawing.Point(372, 287);
            this.TEXT_cuenta.Name = "TEXT_cuenta";
            this.TEXT_cuenta.Size = new System.Drawing.Size(216, 29);
            this.TEXT_cuenta.TabIndex = 2;
            this.TEXT_cuenta.Enter += new System.EventHandler(this.TEXT_cuenta_Enter);
            this.TEXT_cuenta.Leave += new System.EventHandler(this.TEXT_cuenta_Leave);
            // 
            // TEXT_contrasena
            // 
            this.TEXT_contrasena.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXT_contrasena.Location = new System.Drawing.Point(372, 342);
            this.TEXT_contrasena.Name = "TEXT_contrasena";
            this.TEXT_contrasena.Size = new System.Drawing.Size(216, 29);
            this.TEXT_contrasena.TabIndex = 3;
            this.TEXT_contrasena.Enter += new System.EventHandler(this.TEXT_contrasena_Enter);
            this.TEXT_contrasena.Leave += new System.EventHandler(this.TEXT_contrasena_Leave);
            // 
            // BT_inicioSesion
            // 
            this.BT_inicioSesion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BT_inicioSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_inicioSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_inicioSesion.Location = new System.Drawing.Point(412, 398);
            this.BT_inicioSesion.Name = "BT_inicioSesion";
            this.BT_inicioSesion.Size = new System.Drawing.Size(135, 34);
            this.BT_inicioSesion.TabIndex = 4;
            this.BT_inicioSesion.Text = "Iniciar sesión";
            this.BT_inicioSesion.UseVisualStyleBackColor = false;
            this.BT_inicioSesion.Click += new System.EventHandler(this.BT_inicioSesion_Click);
            // 
            // IMG_logoPrincipal
            // 
            this.IMG_logoPrincipal.Image = global::Gestor_de_inventario_Supermercado_Los_Patitos.Properties.Resources.SUPERMERCADO_LOS_PATITOS__LOGOSINFONDO_;
            this.IMG_logoPrincipal.Location = new System.Drawing.Point(315, -46);
            this.IMG_logoPrincipal.Name = "IMG_logoPrincipal";
            this.IMG_logoPrincipal.Size = new System.Drawing.Size(325, 267);
            this.IMG_logoPrincipal.TabIndex = 0;
            this.IMG_logoPrincipal.TabStop = false;
            // 
            // VentanaInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 565);
            this.Controls.Add(this.BT_inicioSesion);
            this.Controls.Add(this.TEXT_contrasena);
            this.Controls.Add(this.TEXT_cuenta);
            this.Controls.Add(this.TXT_inicioSesion);
            this.Controls.Add(this.IMG_logoPrincipal);
            this.Name = "VentanaInicioSesion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaInicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IMG_logoPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox IMG_logoPrincipal;
        private Label TXT_inicioSesion;
        private TextBox TEXT_cuenta;
        private TextBox TEXT_contrasena;
        private Button BT_inicioSesion;
    }
}

