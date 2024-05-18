namespace Gestor_de_inventario_Supermercado_Los_Patitos
{
    partial class PanelEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelPersonal = new System.Windows.Forms.Label();
            this.DGVPersonal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.labelIdentificacion = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido1 = new System.Windows.Forms.Label();
            this.labelApellido2 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido1 = new System.Windows.Forms.TextBox();
            this.textApellido2 = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textContra = new System.Windows.Forms.TextBox();
            this.labelContra = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.checkActivo = new System.Windows.Forms.CheckBox();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelNacimiento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPersonal
            // 
            this.labelPersonal.AutoSize = true;
            this.labelPersonal.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonal.Location = new System.Drawing.Point(146, 7);
            this.labelPersonal.Name = "labelPersonal";
            this.labelPersonal.Size = new System.Drawing.Size(337, 47);
            this.labelPersonal.TabIndex = 0;
            this.labelPersonal.Text = "Registro de Personal";
            // 
            // DGVPersonal
            // 
            this.DGVPersonal.AllowUserToAddRows = false;
            this.DGVPersonal.AllowUserToDeleteRows = false;
            this.DGVPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVPersonal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVPersonal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.DGVPersonal.ColumnHeadersHeight = 25;
            this.DGVPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVPersonal.Location = new System.Drawing.Point(31, 121);
            this.DGVPersonal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVPersonal.MultiSelect = false;
            this.DGVPersonal.Name = "DGVPersonal";
            this.DGVPersonal.ReadOnly = true;
            this.DGVPersonal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVPersonal.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVPersonal.RowTemplate.Height = 24;
            this.DGVPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPersonal.Size = new System.Drawing.Size(618, 510);
            this.DGVPersonal.TabIndex = 0;
            this.DGVPersonal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPersonal_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Empleados Registrados";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(195)))), ((int)(((byte)(141)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(706, 533);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 39);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar.Location = new System.Drawing.Point(811, 533);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 39);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(917, 533);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 39);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdentificacion.Location = new System.Drawing.Point(669, 146);
            this.textIdentificacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(120, 23);
            this.textIdentificacion.TabIndex = 6;
            // 
            // labelIdentificacion
            // 
            this.labelIdentificacion.AutoSize = true;
            this.labelIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentificacion.Location = new System.Drawing.Point(669, 127);
            this.labelIdentificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdentificacion.Name = "labelIdentificacion";
            this.labelIdentificacion.Size = new System.Drawing.Size(90, 17);
            this.labelIdentificacion.TabIndex = 7;
            this.labelIdentificacion.Text = "Identificación";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(669, 196);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 8;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido1
            // 
            this.labelApellido1.AutoSize = true;
            this.labelApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido1.Location = new System.Drawing.Point(791, 197);
            this.labelApellido1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelApellido1.Name = "labelApellido1";
            this.labelApellido1.Size = new System.Drawing.Size(76, 17);
            this.labelApellido1.TabIndex = 9;
            this.labelApellido1.Text = "1° Apellido";
            // 
            // labelApellido2
            // 
            this.labelApellido2.AutoSize = true;
            this.labelApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido2.Location = new System.Drawing.Point(918, 196);
            this.labelApellido2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelApellido2.Name = "labelApellido2";
            this.labelApellido2.Size = new System.Drawing.Size(76, 17);
            this.labelApellido2.TabIndex = 10;
            this.labelApellido2.Text = "2° Apellido";
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(668, 215);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(121, 23);
            this.textNombre.TabIndex = 11;
            // 
            // textApellido1
            // 
            this.textApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido1.Location = new System.Drawing.Point(793, 215);
            this.textApellido1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textApellido1.Name = "textApellido1";
            this.textApellido1.Size = new System.Drawing.Size(121, 23);
            this.textApellido1.TabIndex = 12;
            // 
            // textApellido2
            // 
            this.textApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido2.Location = new System.Drawing.Point(920, 215);
            this.textApellido2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textApellido2.Name = "textApellido2";
            this.textApellido2.Size = new System.Drawing.Size(121, 23);
            this.textApellido2.TabIndex = 13;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(666, 266);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "Email";
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(668, 285);
            this.textEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(121, 23);
            this.textEmail.TabIndex = 15;
            // 
            // textContra
            // 
            this.textContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContra.Location = new System.Drawing.Point(793, 285);
            this.textContra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textContra.Name = "textContra";
            this.textContra.Size = new System.Drawing.Size(121, 23);
            this.textContra.TabIndex = 17;
            // 
            // labelContra
            // 
            this.labelContra.AutoSize = true;
            this.labelContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContra.Location = new System.Drawing.Point(793, 266);
            this.labelContra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContra.Name = "labelContra";
            this.labelContra.Size = new System.Drawing.Size(81, 17);
            this.labelContra.TabIndex = 16;
            this.labelContra.Text = "Contraseña";
            // 
            // textTelefono
            // 
            this.textTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefono.Location = new System.Drawing.Point(917, 285);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(123, 23);
            this.textTelefono.TabIndex = 19;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(917, 266);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(64, 17);
            this.labelTelefono.TabIndex = 18;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(666, 335);
            this.labelGenero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(56, 17);
            this.labelGenero.TabIndex = 20;
            this.labelGenero.Text = "Género";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBoxGenero.Location = new System.Drawing.Point(668, 353);
            this.comboBoxGenero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(121, 25);
            this.comboBoxGenero.TabIndex = 21;
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(793, 353);
            this.comboBoxRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(121, 25);
            this.comboBoxRol.TabIndex = 23;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.Location = new System.Drawing.Point(790, 335);
            this.labelRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(29, 17);
            this.labelRol.TabIndex = 22;
            this.labelRol.Text = "Rol";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(924, 357);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(52, 17);
            this.labelEstado.TabIndex = 24;
            this.labelEstado.Text = "Estado";
            // 
            // checkActivo
            // 
            this.checkActivo.AutoSize = true;
            this.checkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkActivo.Location = new System.Drawing.Point(976, 357);
            this.checkActivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkActivo.Name = "checkActivo";
            this.checkActivo.Size = new System.Drawing.Size(65, 21);
            this.checkActivo.TabIndex = 25;
            this.checkActivo.Text = "Activo";
            this.checkActivo.UseVisualStyleBackColor = true;
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNacimiento.Location = new System.Drawing.Point(917, 146);
            this.dateNacimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(121, 23);
            this.dateNacimiento.TabIndex = 26;
            // 
            // labelNacimiento
            // 
            this.labelNacimiento.AutoSize = true;
            this.labelNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNacimiento.Location = new System.Drawing.Point(914, 127);
            this.labelNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNacimiento.Name = "labelNacimiento";
            this.labelNacimiento.Size = new System.Drawing.Size(141, 17);
            this.labelNacimiento.TabIndex = 27;
            this.labelNacimiento.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(668, 404);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Dirección";
            // 
            // textDireccion
            // 
            this.textDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDireccion.Location = new System.Drawing.Point(668, 428);
            this.textDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(372, 54);
            this.textDireccion.TabIndex = 29;
            this.textDireccion.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Limpiar campos\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 662);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNacimiento);
            this.Controls.Add(this.dateNacimiento);
            this.Controls.Add(this.checkActivo);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.labelRol);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textContra);
            this.Controls.Add(this.labelContra);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textApellido2);
            this.Controls.Add(this.textApellido1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelApellido2);
            this.Controls.Add(this.labelApellido1);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelIdentificacion);
            this.Controls.Add(this.textIdentificacion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVPersonal);
            this.Controls.Add(this.labelPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1069, 662);
            this.Name = "PanelEmpleados";
            this.Text = "PanelEmpleados";
            this.Load += new System.EventHandler(this.PanelEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPersonal;
        private System.Windows.Forms.DataGridView DGVPersonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox textIdentificacion;
        private System.Windows.Forms.Label labelIdentificacion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido1;
        private System.Windows.Forms.Label labelApellido2;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido1;
        private System.Windows.Forms.TextBox textApellido2;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textContra;
        private System.Windows.Forms.Label labelContra;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.CheckBox checkActivo;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.Label labelNacimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox textDireccion;
        private System.Windows.Forms.Button button1;
    }
}