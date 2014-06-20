namespace FrbaCommerce.Abm_Empresa
{
    partial class Alta_Empresa
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
            this.razonSocial = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.empRazSocial = new System.Windows.Forms.TextBox();
            this.empMail = new System.Windows.Forms.TextBox();
            this.empTelefono = new System.Windows.Forms.TextBox();
            this.empDireccion = new System.Windows.Forms.TextBox();
            this.empNroPiso = new System.Windows.Forms.TextBox();
            this.empDpto = new System.Windows.Forms.TextBox();
            this.empLocalidad = new System.Windows.Forms.TextBox();
            this.empCodPostal = new System.Windows.Forms.TextBox();
            this.empCiudad = new System.Windows.Forms.ComboBox();
            this.empCuit = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.empFechaCre = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // razonSocial
            // 
            this.razonSocial.AutoSize = true;
            this.razonSocial.Location = new System.Drawing.Point(15, 22);
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.Size = new System.Drawing.Size(73, 13);
            this.razonSocial.TabIndex = 0;
            this.razonSocial.Text = "Razón Social:";
            this.razonSocial.Click += new System.EventHandler(this.label1_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(15, 49);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(39, 13);
            this.email.TabIndex = 1;
            this.email.Text = "E-Mail:";
            // 
            // telefono
            // 
            this.telefono.AutoSize = true;
            this.telefono.Location = new System.Drawing.Point(15, 73);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(52, 13);
            this.telefono.TabIndex = 2;
            this.telefono.Text = "Teléfono:";
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.Location = new System.Drawing.Point(15, 102);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(52, 13);
            this.direccion.TabIndex = 3;
            this.direccion.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nro. Piso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dpto.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Localidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Código Postal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ciudad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "CUIT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nombre de\r\nContacto:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 26);
            this.label9.TabIndex = 12;
            this.label9.Text = "Fecha de \r\nCreación:";
            // 
            // empRazSocial
            // 
            this.empRazSocial.Location = new System.Drawing.Point(96, 20);
            this.empRazSocial.Name = "empRazSocial";
            this.empRazSocial.Size = new System.Drawing.Size(212, 20);
            this.empRazSocial.TabIndex = 13;
            // 
            // empMail
            // 
            this.empMail.Location = new System.Drawing.Point(96, 46);
            this.empMail.Name = "empMail";
            this.empMail.Size = new System.Drawing.Size(212, 20);
            this.empMail.TabIndex = 14;
            // 
            // empTelefono
            // 
            this.empTelefono.Location = new System.Drawing.Point(96, 73);
            this.empTelefono.Name = "empTelefono";
            this.empTelefono.Size = new System.Drawing.Size(121, 20);
            this.empTelefono.TabIndex = 15;
            // 
            // empDireccion
            // 
            this.empDireccion.Location = new System.Drawing.Point(96, 99);
            this.empDireccion.Name = "empDireccion";
            this.empDireccion.Size = new System.Drawing.Size(230, 20);
            this.empDireccion.TabIndex = 16;
            // 
            // empNroPiso
            // 
            this.empNroPiso.Location = new System.Drawing.Point(96, 125);
            this.empNroPiso.Name = "empNroPiso";
            this.empNroPiso.Size = new System.Drawing.Size(43, 20);
            this.empNroPiso.TabIndex = 17;
            // 
            // empDpto
            // 
            this.empDpto.Location = new System.Drawing.Point(96, 151);
            this.empDpto.Name = "empDpto";
            this.empDpto.Size = new System.Drawing.Size(43, 20);
            this.empDpto.TabIndex = 18;
            // 
            // empLocalidad
            // 
            this.empLocalidad.Location = new System.Drawing.Point(96, 177);
            this.empLocalidad.Name = "empLocalidad";
            this.empLocalidad.Size = new System.Drawing.Size(121, 20);
            this.empLocalidad.TabIndex = 19;
            // 
            // empCodPostal
            // 
            this.empCodPostal.Location = new System.Drawing.Point(96, 203);
            this.empCodPostal.Name = "empCodPostal";
            this.empCodPostal.Size = new System.Drawing.Size(64, 20);
            this.empCodPostal.TabIndex = 20;
            // 
            // empCiudad
            // 
            this.empCiudad.FormattingEnabled = true;
            this.empCiudad.Location = new System.Drawing.Point(96, 230);
            this.empCiudad.Name = "empCiudad";
            this.empCiudad.Size = new System.Drawing.Size(150, 21);
            this.empCiudad.TabIndex = 21;
            // 
            // empCuit
            // 
            this.empCuit.Location = new System.Drawing.Point(96, 258);
            this.empCuit.Name = "empCuit";
            this.empCuit.Size = new System.Drawing.Size(121, 20);
            this.empCuit.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 23;
            // 
            // empFechaCre
            // 
            this.empFechaCre.Location = new System.Drawing.Point(96, 319);
            this.empFechaCre.Name = "empFechaCre";
            this.empFechaCre.Size = new System.Drawing.Size(200, 20);
            this.empFechaCre.TabIndex = 24;
            // 
            // Alta_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 540);
            this.Controls.Add(this.empFechaCre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.empCuit);
            this.Controls.Add(this.empCiudad);
            this.Controls.Add(this.empCodPostal);
            this.Controls.Add(this.empLocalidad);
            this.Controls.Add(this.empDpto);
            this.Controls.Add(this.empNroPiso);
            this.Controls.Add(this.empDireccion);
            this.Controls.Add(this.empTelefono);
            this.Controls.Add(this.empMail);
            this.Controls.Add(this.empRazSocial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.email);
            this.Controls.Add(this.razonSocial);
            this.Name = "Alta_Empresa";
            this.Text = "Alta Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label razonSocial;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label telefono;
        private System.Windows.Forms.Label direccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox empRazSocial;
        private System.Windows.Forms.TextBox empMail;
        private System.Windows.Forms.TextBox empTelefono;
        private System.Windows.Forms.TextBox empDireccion;
        private System.Windows.Forms.TextBox empNroPiso;
        private System.Windows.Forms.TextBox empDpto;
        private System.Windows.Forms.TextBox empLocalidad;
        private System.Windows.Forms.TextBox empCodPostal;
        private System.Windows.Forms.ComboBox empCiudad;
        private System.Windows.Forms.TextBox empCuit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker empFechaCre;
    }
}