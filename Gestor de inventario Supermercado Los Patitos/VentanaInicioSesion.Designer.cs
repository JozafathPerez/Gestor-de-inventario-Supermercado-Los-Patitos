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
            this.IMG_logoPrincipal = new System.Windows.Forms.PictureBox();
            this.TXT_inicioSesion = new System.Windows.Forms.Label();
            this.TEXT_cuenta = new System.Windows.Forms.TextBox();
            this.TEXT_contrasena = new System.Windows.Forms.TextBox();
            this.BT_inicioSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_logoPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // IMG_logoPrincipal
            // 
            this.IMG_logoPrincipal.Image = global::Gestor_de_inventario_Supermercado_Los_Patitos.Properties.Resources.SUPERMERCADO_LOS_PATITOS__LOGOSINFONDO_;
            this.IMG_logoPrincipal.Location = new System.Drawing.Point(318, -15);
            this.IMG_logoPrincipal.Name = "IMG_logoPrincipal";
            this.IMG_logoPrincipal.Size = new System.Drawing.Size(325, 267);
            this.IMG_logoPrincipal.TabIndex = 0;
            this.IMG_logoPrincipal.TabStop = false;
            // 
            // TXT_inicioSesion
            // 
            this.TXT_inicioSesion.AutoSize = true;
            this.TXT_inicioSesion.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_inicioSesion.Location = new System.Drawing.Point(354, 241);
            this.TXT_inicioSesion.Name = "TXT_inicioSesion";
            this.TXT_inicioSesion.Size = new System.Drawing.Size(262, 47);
            this.TXT_inicioSesion.TabIndex = 1;
            this.TXT_inicioSesion.Text = "Inicio de Sesión";
            // 
            // TEXT_cuenta
            // 
            this.TEXT_cuenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXT_cuenta.Location = new System.Drawing.Point(400, 304);
            this.TEXT_cuenta.Name = "TEXT_cuenta";
            this.TEXT_cuenta.Size = new System.Drawing.Size(157, 29);
            this.TEXT_cuenta.TabIndex = 2;
            // 
            // TEXT_contrasena
            // 
            this.TEXT_contrasena.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXT_contrasena.Location = new System.Drawing.Point(400, 354);
            this.TEXT_contrasena.Name = "TEXT_contrasena";
            this.TEXT_contrasena.Size = new System.Drawing.Size(157, 29);
            this.TEXT_contrasena.TabIndex = 3;
            // 
            // BT_inicioSesion
            // 
            this.BT_inicioSesion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BT_inicioSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_inicioSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_inicioSesion.Location = new System.Drawing.Point(408, 404);
            this.BT_inicioSesion.Name = "BT_inicioSesion";
            this.BT_inicioSesion.Size = new System.Drawing.Size(135, 25);
            this.BT_inicioSesion.TabIndex = 4;
            this.BT_inicioSesion.Text = "Iniciar sesión";
            this.BT_inicioSesion.UseVisualStyleBackColor = false;
            // 
            // VentanaInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 596);
            this.Controls.Add(this.BT_inicioSesion);
            this.Controls.Add(this.TEXT_contrasena);
            this.Controls.Add(this.TEXT_cuenta);
            this.Controls.Add(this.TXT_inicioSesion);
            this.Controls.Add(this.IMG_logoPrincipal);
            this.Name = "VentanaInicioSesion";
            this.Text = "Form1";
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

