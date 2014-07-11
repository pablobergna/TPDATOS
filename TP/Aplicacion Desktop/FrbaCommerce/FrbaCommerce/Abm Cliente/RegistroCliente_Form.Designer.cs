namespace FrbaCommerce.Abm_Cliente
{
    partial class Alta_Cliente
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
            this.Nombre = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.TipoDoc = new System.Windows.Forms.Label();
            this.Dni = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.Piso = new System.Windows.Forms.Label();
            this.Depto = new System.Windows.Forms.Label();
            this.Localidad = new System.Windows.Forms.Label();
            this.CodPostal = new System.Windows.Forms.Label();
            this.FechaNac = new System.Windows.Forms.Label();
            this.cliNombre = new System.Windows.Forms.TextBox();
            this.cliApellido = new System.Windows.Forms.TextBox();
            this.cliTipoDoc = new System.Windows.Forms.ComboBox();
            this.cliDni = new System.Windows.Forms.TextBox();
            this.cliEmail = new System.Windows.Forms.TextBox();
            this.cliTelefono = new System.Windows.Forms.TextBox();
            this.cliDireccion = new System.Windows.Forms.TextBox();
            this.cliPiso = new System.Windows.Forms.TextBox();
            this.cliDpto = new System.Windows.Forms.TextBox();
            this.cliLocalidad = new System.Windows.Forms.TextBox();
            this.cliCodPostal = new System.Windows.Forms.TextBox();
            this.cliFechaNac = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(6, 30);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(48, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre*";
            this.Nombre.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(6, 56);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(48, 13);
            this.Apellido.TabIndex = 2;
            this.Apellido.Text = "Apellido*";
            // 
            // TipoDoc
            // 
            this.TipoDoc.AutoSize = true;
            this.TipoDoc.Location = new System.Drawing.Point(6, 82);
            this.TipoDoc.Name = "TipoDoc";
            this.TipoDoc.Size = new System.Drawing.Size(58, 13);
            this.TipoDoc.TabIndex = 3;
            this.TipoDoc.Text = "Tipo Doc.*";
            // 
            // Dni
            // 
            this.Dni.AutoSize = true;
            this.Dni.Location = new System.Drawing.Point(6, 107);
            this.Dni.Name = "Dni";
            this.Dni.Size = new System.Drawing.Size(50, 13);
            this.Dni.TabIndex = 4;
            this.Dni.Text = "Nro. Dni*";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(6, 133);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(35, 13);
            this.Email.TabIndex = 5;
            this.Email.Text = "E-mail";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(6, 159);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(49, 13);
            this.Telefono.TabIndex = 6;
            this.Telefono.Text = "Teléfono";
            this.Telefono.Click += new System.EventHandler(this.Telefono_Click);
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(6, 185);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(52, 13);
            this.Direccion.TabIndex = 7;
            this.Direccion.Text = "Dirección";
            this.Direccion.Click += new System.EventHandler(this.label8_Click);
            // 
            // Piso
            // 
            this.Piso.AutoSize = true;
            this.Piso.Location = new System.Drawing.Point(6, 211);
            this.Piso.Name = "Piso";
            this.Piso.Size = new System.Drawing.Size(50, 13);
            this.Piso.TabIndex = 8;
            this.Piso.Text = "Nro. Piso";
            // 
            // Depto
            // 
            this.Depto.AutoSize = true;
            this.Depto.Location = new System.Drawing.Point(6, 237);
            this.Depto.Name = "Depto";
            this.Depto.Size = new System.Drawing.Size(36, 13);
            this.Depto.TabIndex = 9;
            this.Depto.Text = "Depto";
            // 
            // Localidad
            // 
            this.Localidad.AutoSize = true;
            this.Localidad.Location = new System.Drawing.Point(6, 262);
            this.Localidad.Name = "Localidad";
            this.Localidad.Size = new System.Drawing.Size(53, 13);
            this.Localidad.TabIndex = 10;
            this.Localidad.Text = "Localidad";
            // 
            // CodPostal
            // 
            this.CodPostal.AutoSize = true;
            this.CodPostal.Location = new System.Drawing.Point(6, 288);
            this.CodPostal.Name = "CodPostal";
            this.CodPostal.Size = new System.Drawing.Size(72, 13);
            this.CodPostal.TabIndex = 11;
            this.CodPostal.Text = "Código Postal";
            // 
            // FechaNac
            // 
            this.FechaNac.AutoSize = true;
            this.FechaNac.Location = new System.Drawing.Point(6, 318);
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.Size = new System.Drawing.Size(63, 13);
            this.FechaNac.TabIndex = 12;
            this.FechaNac.Text = "Fecha Nac.";
            // 
            // cliNombre
            // 
            this.cliNombre.Location = new System.Drawing.Point(78, 27);
            this.cliNombre.Name = "cliNombre";
            this.cliNombre.Size = new System.Drawing.Size(169, 20);
            this.cliNombre.TabIndex = 13;
            this.cliNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cliApellido
            // 
            this.cliApellido.Location = new System.Drawing.Point(78, 53);
            this.cliApellido.Name = "cliApellido";
            this.cliApellido.Size = new System.Drawing.Size(169, 20);
            this.cliApellido.TabIndex = 14;
            // 
            // cliTipoDoc
            // 
            this.cliTipoDoc.AutoCompleteCustomSource.AddRange(new string[] {
            "DNI",
            "Pasaporte",
            "Cedula",
            "Libreta Enrolamiento"});
            this.cliTipoDoc.FormattingEnabled = true;
            this.cliTipoDoc.Location = new System.Drawing.Point(78, 79);
            this.cliTipoDoc.Name = "cliTipoDoc";
            this.cliTipoDoc.Size = new System.Drawing.Size(149, 21);
            this.cliTipoDoc.TabIndex = 15;
            // 
            // cliDni
            // 
            this.cliDni.Location = new System.Drawing.Point(78, 104);
            this.cliDni.Name = "cliDni";
            this.cliDni.Size = new System.Drawing.Size(110, 20);
            this.cliDni.TabIndex = 16;
            // 
            // cliEmail
            // 
            this.cliEmail.Location = new System.Drawing.Point(78, 130);
            this.cliEmail.Name = "cliEmail";
            this.cliEmail.Size = new System.Drawing.Size(183, 20);
            this.cliEmail.TabIndex = 17;
            // 
            // cliTelefono
            // 
            this.cliTelefono.Location = new System.Drawing.Point(78, 156);
            this.cliTelefono.Name = "cliTelefono";
            this.cliTelefono.Size = new System.Drawing.Size(121, 20);
            this.cliTelefono.TabIndex = 18;
            // 
            // cliDireccion
            // 
            this.cliDireccion.Location = new System.Drawing.Point(78, 182);
            this.cliDireccion.Name = "cliDireccion";
            this.cliDireccion.Size = new System.Drawing.Size(217, 20);
            this.cliDireccion.TabIndex = 19;
            // 
            // cliPiso
            // 
            this.cliPiso.Location = new System.Drawing.Point(78, 208);
            this.cliPiso.Name = "cliPiso";
            this.cliPiso.Size = new System.Drawing.Size(39, 20);
            this.cliPiso.TabIndex = 20;
            this.cliPiso.TextChanged += new System.EventHandler(this.ACliPiso_TextChanged);
            // 
            // cliDpto
            // 
            this.cliDpto.Location = new System.Drawing.Point(78, 234);
            this.cliDpto.Name = "cliDpto";
            this.cliDpto.Size = new System.Drawing.Size(39, 20);
            this.cliDpto.TabIndex = 21;
            // 
            // cliLocalidad
            // 
            this.cliLocalidad.Location = new System.Drawing.Point(78, 259);
            this.cliLocalidad.Name = "cliLocalidad";
            this.cliLocalidad.Size = new System.Drawing.Size(183, 20);
            this.cliLocalidad.TabIndex = 22;
            // 
            // cliCodPostal
            // 
            this.cliCodPostal.Location = new System.Drawing.Point(78, 285);
            this.cliCodPostal.Name = "cliCodPostal";
            this.cliCodPostal.Size = new System.Drawing.Size(56, 20);
            this.cliCodPostal.TabIndex = 23;
            // 
            // cliFechaNac
            // 
            this.cliFechaNac.Location = new System.Drawing.Point(78, 311);
            this.cliFechaNac.Name = "cliFechaNac";
            this.cliFechaNac.Size = new System.Drawing.Size(200, 20);
            this.cliFechaNac.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.FechaNac);
            this.groupBox1.Controls.Add(this.cliFechaNac);
            this.groupBox1.Controls.Add(this.CodPostal);
            this.groupBox1.Controls.Add(this.cliNombre);
            this.groupBox1.Controls.Add(this.Localidad);
            this.groupBox1.Controls.Add(this.cliCodPostal);
            this.groupBox1.Controls.Add(this.Depto);
            this.groupBox1.Controls.Add(this.cliApellido);
            this.groupBox1.Controls.Add(this.Piso);
            this.groupBox1.Controls.Add(this.cliLocalidad);
            this.groupBox1.Controls.Add(this.cliTipoDoc);
            this.groupBox1.Controls.Add(this.cliDpto);
            this.groupBox1.Controls.Add(this.Apellido);
            this.groupBox1.Controls.Add(this.cliPiso);
            this.groupBox1.Controls.Add(this.TipoDoc);
            this.groupBox1.Controls.Add(this.cliDireccion);
            this.groupBox1.Controls.Add(this.Dni);
            this.groupBox1.Controls.Add(this.cliTelefono);
            this.groupBox1.Controls.Add(this.cliDni);
            this.groupBox1.Controls.Add(this.cliEmail);
            this.groupBox1.Controls.Add(this.Direccion);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.Telefono);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 396);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "* Campos Obligatorios";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(40, 450);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 26;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(392, 450);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 27;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // Alta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(498, 540);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Alta_Cliente";
            this.Text = "Alta Cliente";
            this.Load += new System.EventHandler(this.Alta_Cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label TipoDoc;
        private System.Windows.Forms.Label Dni;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Piso;
        private System.Windows.Forms.Label Depto;
        private System.Windows.Forms.Label Localidad;
        private System.Windows.Forms.Label CodPostal;
        private System.Windows.Forms.Label FechaNac;
        private System.Windows.Forms.TextBox cliNombre;
        private System.Windows.Forms.TextBox cliApellido;
        private System.Windows.Forms.ComboBox cliTipoDoc;
        private System.Windows.Forms.TextBox cliDni;
        private System.Windows.Forms.TextBox cliEmail;
        private System.Windows.Forms.TextBox cliTelefono;
        private System.Windows.Forms.TextBox cliDireccion;
        private System.Windows.Forms.TextBox cliPiso;
        private System.Windows.Forms.TextBox cliDpto;
        private System.Windows.Forms.TextBox cliLocalidad;
        private System.Windows.Forms.TextBox cliCodPostal;
        private System.Windows.Forms.DateTimePicker cliFechaNac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonGuardar;

    }
}