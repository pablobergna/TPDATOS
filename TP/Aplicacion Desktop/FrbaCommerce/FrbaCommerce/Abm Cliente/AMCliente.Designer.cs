namespace FrbaCommerce.Abm_Cliente
{
    partial class AMCliente
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.cliCiudad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nroCalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cuil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.FechaNac = new System.Windows.Forms.Label();
            this.cliFechaNac = new System.Windows.Forms.DateTimePicker();
            this.CodPostal = new System.Windows.Forms.Label();
            this.cliNombre = new System.Windows.Forms.TextBox();
            this.Localidad = new System.Windows.Forms.Label();
            this.cliCodPostal = new System.Windows.Forms.TextBox();
            this.Depto = new System.Windows.Forms.Label();
            this.cliApellido = new System.Windows.Forms.TextBox();
            this.Piso = new System.Windows.Forms.Label();
            this.cliLocalidad = new System.Windows.Forms.TextBox();
            this.cliTipoDoc = new System.Windows.Forms.ComboBox();
            this.cliDpto = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.Label();
            this.cliPiso = new System.Windows.Forms.TextBox();
            this.TipoDoc = new System.Windows.Forms.Label();
            this.cliDireccion = new System.Windows.Forms.TextBox();
            this.Dni = new System.Windows.Forms.Label();
            this.cliTelefono = new System.Windows.Forms.TextBox();
            this.cliDni = new System.Windows.Forms.TextBox();
            this.cliEmail = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.lblUsu = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(60, 506);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // cliCiudad
            // 
            this.cliCiudad.Location = new System.Drawing.Point(122, 395);
            this.cliCiudad.Name = "cliCiudad";
            this.cliCiudad.Size = new System.Drawing.Size(100, 20);
            this.cliCiudad.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ciudad*";
            // 
            // nroCalle
            // 
            this.nroCalle.Location = new System.Drawing.Point(122, 208);
            this.nroCalle.Name = "nroCalle";
            this.nroCalle.Size = new System.Drawing.Size(100, 20);
            this.nroCalle.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nro calle*";
            // 
            // cuil
            // 
            this.cuil.Location = new System.Drawing.Point(122, 238);
            this.cuil.Name = "cuil";
            this.cuil.Size = new System.Drawing.Size(100, 20);
            this.cuil.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "CUIL*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "* Campos Obligatorios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cliCiudad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nroCalle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cuil);
            this.groupBox1.Controls.Add(this.label2);
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
            this.groupBox1.Location = new System.Drawing.Point(34, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 456);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Formato XX-XXXXXXXX-X";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(13, 31);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(48, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre*";
            // 
            // FechaNac
            // 
            this.FechaNac.AutoSize = true;
            this.FechaNac.Location = new System.Drawing.Point(13, 369);
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.Size = new System.Drawing.Size(67, 13);
            this.FechaNac.TabIndex = 12;
            this.FechaNac.Text = "Fecha Nac.*";
            // 
            // cliFechaNac
            // 
            this.cliFechaNac.Location = new System.Drawing.Point(122, 368);
            this.cliFechaNac.Name = "cliFechaNac";
            this.cliFechaNac.Size = new System.Drawing.Size(200, 20);
            this.cliFechaNac.TabIndex = 26;
            // 
            // CodPostal
            // 
            this.CodPostal.AutoSize = true;
            this.CodPostal.Location = new System.Drawing.Point(13, 343);
            this.CodPostal.Name = "CodPostal";
            this.CodPostal.Size = new System.Drawing.Size(72, 13);
            this.CodPostal.TabIndex = 11;
            this.CodPostal.Text = "Código Postal";
            // 
            // cliNombre
            // 
            this.cliNombre.Location = new System.Drawing.Point(122, 27);
            this.cliNombre.Name = "cliNombre";
            this.cliNombre.Size = new System.Drawing.Size(169, 20);
            this.cliNombre.TabIndex = 13;
            // 
            // Localidad
            // 
            this.Localidad.AutoSize = true;
            this.Localidad.Location = new System.Drawing.Point(13, 317);
            this.Localidad.Name = "Localidad";
            this.Localidad.Size = new System.Drawing.Size(57, 13);
            this.Localidad.TabIndex = 10;
            this.Localidad.Text = "Localidad*";
            // 
            // cliCodPostal
            // 
            this.cliCodPostal.Location = new System.Drawing.Point(122, 342);
            this.cliCodPostal.Name = "cliCodPostal";
            this.cliCodPostal.Size = new System.Drawing.Size(56, 20);
            this.cliCodPostal.TabIndex = 25;
            // 
            // Depto
            // 
            this.Depto.AutoSize = true;
            this.Depto.Location = new System.Drawing.Point(13, 291);
            this.Depto.Name = "Depto";
            this.Depto.Size = new System.Drawing.Size(36, 13);
            this.Depto.TabIndex = 9;
            this.Depto.Text = "Depto";
            // 
            // cliApellido
            // 
            this.cliApellido.Location = new System.Drawing.Point(122, 54);
            this.cliApellido.Name = "cliApellido";
            this.cliApellido.Size = new System.Drawing.Size(169, 20);
            this.cliApellido.TabIndex = 14;
            // 
            // Piso
            // 
            this.Piso.AutoSize = true;
            this.Piso.Location = new System.Drawing.Point(13, 265);
            this.Piso.Name = "Piso";
            this.Piso.Size = new System.Drawing.Size(50, 13);
            this.Piso.TabIndex = 8;
            this.Piso.Text = "Nro. Piso";
            // 
            // cliLocalidad
            // 
            this.cliLocalidad.Location = new System.Drawing.Point(122, 316);
            this.cliLocalidad.Name = "cliLocalidad";
            this.cliLocalidad.Size = new System.Drawing.Size(183, 20);
            this.cliLocalidad.TabIndex = 24;
            // 
            // cliTipoDoc
            // 
            this.cliTipoDoc.AutoCompleteCustomSource.AddRange(new string[] {
            "DNI",
            "Pasaporte",
            "Cedula",
            "Libreta Enrolamiento"});
            this.cliTipoDoc.FormattingEnabled = true;
            this.cliTipoDoc.Location = new System.Drawing.Point(122, 79);
            this.cliTipoDoc.Name = "cliTipoDoc";
            this.cliTipoDoc.Size = new System.Drawing.Size(149, 21);
            this.cliTipoDoc.TabIndex = 15;
            // 
            // cliDpto
            // 
            this.cliDpto.Location = new System.Drawing.Point(122, 291);
            this.cliDpto.Name = "cliDpto";
            this.cliDpto.Size = new System.Drawing.Size(39, 20);
            this.cliDpto.TabIndex = 23;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(13, 58);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(48, 13);
            this.Apellido.TabIndex = 2;
            this.Apellido.Text = "Apellido*";
            // 
            // cliPiso
            // 
            this.cliPiso.Location = new System.Drawing.Point(122, 265);
            this.cliPiso.Name = "cliPiso";
            this.cliPiso.Size = new System.Drawing.Size(39, 20);
            this.cliPiso.TabIndex = 22;
            // 
            // TipoDoc
            // 
            this.TipoDoc.AutoSize = true;
            this.TipoDoc.Location = new System.Drawing.Point(13, 83);
            this.TipoDoc.Name = "TipoDoc";
            this.TipoDoc.Size = new System.Drawing.Size(58, 13);
            this.TipoDoc.TabIndex = 3;
            this.TipoDoc.Text = "Tipo Doc.*";
            // 
            // cliDireccion
            // 
            this.cliDireccion.Location = new System.Drawing.Point(122, 182);
            this.cliDireccion.Name = "cliDireccion";
            this.cliDireccion.Size = new System.Drawing.Size(217, 20);
            this.cliDireccion.TabIndex = 19;
            // 
            // Dni
            // 
            this.Dni.AutoSize = true;
            this.Dni.Location = new System.Drawing.Point(13, 109);
            this.Dni.Name = "Dni";
            this.Dni.Size = new System.Drawing.Size(50, 13);
            this.Dni.TabIndex = 4;
            this.Dni.Text = "Nro. Dni*";
            // 
            // cliTelefono
            // 
            this.cliTelefono.Location = new System.Drawing.Point(122, 156);
            this.cliTelefono.Name = "cliTelefono";
            this.cliTelefono.Size = new System.Drawing.Size(121, 20);
            this.cliTelefono.TabIndex = 18;
            // 
            // cliDni
            // 
            this.cliDni.Location = new System.Drawing.Point(122, 104);
            this.cliDni.Name = "cliDni";
            this.cliDni.Size = new System.Drawing.Size(110, 20);
            this.cliDni.TabIndex = 16;
            // 
            // cliEmail
            // 
            this.cliEmail.Location = new System.Drawing.Point(122, 130);
            this.cliEmail.Name = "cliEmail";
            this.cliEmail.Size = new System.Drawing.Size(183, 20);
            this.cliEmail.TabIndex = 17;
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(13, 187);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(34, 13);
            this.Direccion.TabIndex = 7;
            this.Direccion.Text = "Calle*";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(13, 135);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(39, 13);
            this.Email.TabIndex = 5;
            this.Email.Text = "E-mail*";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(13, 161);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(53, 13);
            this.Telefono.TabIndex = 6;
            this.Telefono.Text = "Teléfono*";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(411, 509);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 30;
            this.buttonGuardar.Text = "Siguiente";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsu.Location = new System.Drawing.Point(72, 9);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(65, 17);
            this.lblUsu.TabIndex = 31;
            this.lblUsu.Text = "Usuario: ";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(384, 9);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 17);
            this.lblEstado.TabIndex = 32;
            this.lblEstado.Text = "Estado: ";
            // 
            // AMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 544);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblUsu);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonGuardar);
            this.Name = "AMCliente";
            this.Text = "AMCliente";
            this.Load += new System.EventHandler(this.AMCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox cliCiudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nroCalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cuil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label FechaNac;
        private System.Windows.Forms.DateTimePicker cliFechaNac;
        private System.Windows.Forms.Label CodPostal;
        private System.Windows.Forms.TextBox cliNombre;
        private System.Windows.Forms.Label Localidad;
        private System.Windows.Forms.TextBox cliCodPostal;
        private System.Windows.Forms.Label Depto;
        private System.Windows.Forms.TextBox cliApellido;
        private System.Windows.Forms.Label Piso;
        private System.Windows.Forms.TextBox cliLocalidad;
        private System.Windows.Forms.ComboBox cliTipoDoc;
        private System.Windows.Forms.TextBox cliDpto;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.TextBox cliPiso;
        private System.Windows.Forms.Label TipoDoc;
        private System.Windows.Forms.TextBox cliDireccion;
        private System.Windows.Forms.Label Dni;
        private System.Windows.Forms.TextBox cliTelefono;
        private System.Windows.Forms.TextBox cliDni;
        private System.Windows.Forms.TextBox cliEmail;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label lblUsu;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label5;

    }
}