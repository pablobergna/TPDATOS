namespace FrbaCommerce
{
    partial class Principal
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
            this.panelInicio = new System.Windows.Forms.Panel();
            this.linkSalir = new System.Windows.Forms.LinkLabel();
            this.login_btnIngresar = new System.Windows.Forms.Button();
            this.link_registro = new System.Windows.Forms.LinkLabel();
            this.login_txtpass = new System.Windows.Forms.TextBox();
            this.login_txtUsr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelPpal = new System.Windows.Forms.Panel();
            this.btnModifPass = new System.Windows.Forms.Button();
            this.linkSalirLogueado = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listaFunciones = new System.Windows.Forms.ListBox();
            this.panelInicio.SuspendLayout();
            this.panelPpal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInicio
            // 
            this.panelInicio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelInicio.Controls.Add(this.linkSalir);
            this.panelInicio.Controls.Add(this.login_btnIngresar);
            this.panelInicio.Controls.Add(this.link_registro);
            this.panelInicio.Controls.Add(this.login_txtpass);
            this.panelInicio.Controls.Add(this.login_txtUsr);
            this.panelInicio.Controls.Add(this.label4);
            this.panelInicio.Controls.Add(this.label3);
            this.panelInicio.Controls.Add(this.label2);
            this.panelInicio.Controls.Add(this.label1);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicio.Location = new System.Drawing.Point(0, 0);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(684, 462);
            this.panelInicio.TabIndex = 0;
            // 
            // linkSalir
            // 
            this.linkSalir.AutoSize = true;
            this.linkSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSalir.Location = new System.Drawing.Point(33, 21);
            this.linkSalir.Name = "linkSalir";
            this.linkSalir.Size = new System.Drawing.Size(40, 20);
            this.linkSalir.TabIndex = 8;
            this.linkSalir.TabStop = true;
            this.linkSalir.Text = "Salir";
            this.linkSalir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSalir_LinkClicked);
            // 
            // login_btnIngresar
            // 
            this.login_btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btnIngresar.Location = new System.Drawing.Point(283, 287);
            this.login_btnIngresar.Name = "login_btnIngresar";
            this.login_btnIngresar.Size = new System.Drawing.Size(102, 33);
            this.login_btnIngresar.TabIndex = 6;
            this.login_btnIngresar.Text = "Ingresar";
            this.login_btnIngresar.UseVisualStyleBackColor = true;
            this.login_btnIngresar.Click += new System.EventHandler(this.login_btnIngresar_Click);
            // 
            // link_registro
            // 
            this.link_registro.AutoSize = true;
            this.link_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_registro.Location = new System.Drawing.Point(254, 352);
            this.link_registro.Name = "link_registro";
            this.link_registro.Size = new System.Drawing.Size(159, 20);
            this.link_registro.TabIndex = 7;
            this.link_registro.TabStop = true;
            this.link_registro.Text = "Deseo Registrarme...";
            this.link_registro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_registro_LinkClicked);
            // 
            // login_txtpass
            // 
            this.login_txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_txtpass.Location = new System.Drawing.Point(308, 238);
            this.login_txtpass.Name = "login_txtpass";
            this.login_txtpass.PasswordChar = '*';
            this.login_txtpass.Size = new System.Drawing.Size(206, 26);
            this.login_txtpass.TabIndex = 5;
            // 
            // login_txtUsr
            // 
            this.login_txtUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_txtUsr.Location = new System.Drawing.Point(308, 187);
            this.login_txtUsr.Name = "login_txtUsr";
            this.login_txtUsr.Size = new System.Drawing.Size(206, 26);
            this.login_txtUsr.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Identifiquese o registrese por favor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bienvenido a FRBACommerce";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelPpal
            // 
            this.panelPpal.Controls.Add(this.btnModifPass);
            this.panelPpal.Controls.Add(this.linkSalirLogueado);
            this.panelPpal.Controls.Add(this.label6);
            this.panelPpal.Controls.Add(this.btnSeleccion);
            this.panelPpal.Controls.Add(this.label5);
            this.panelPpal.Controls.Add(this.listaFunciones);
            this.panelPpal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPpal.Location = new System.Drawing.Point(0, 0);
            this.panelPpal.Name = "panelPpal";
            this.panelPpal.Size = new System.Drawing.Size(684, 462);
            this.panelPpal.TabIndex = 1;
            // 
            // btnModifPass
            // 
            this.btnModifPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifPass.Location = new System.Drawing.Point(108, 375);
            this.btnModifPass.Name = "btnModifPass";
            this.btnModifPass.Size = new System.Drawing.Size(213, 42);
            this.btnModifPass.TabIndex = 8;
            this.btnModifPass.Text = "Modificar mi contraseña";
            this.btnModifPass.UseVisualStyleBackColor = true;
            this.btnModifPass.Click += new System.EventHandler(this.btnModifPass_Click);
            // 
            // linkSalirLogueado
            // 
            this.linkSalirLogueado.AutoSize = true;
            this.linkSalirLogueado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSalirLogueado.Location = new System.Drawing.Point(12, 18);
            this.linkSalirLogueado.Name = "linkSalirLogueado";
            this.linkSalirLogueado.Size = new System.Drawing.Size(106, 20);
            this.linkSalirLogueado.TabIndex = 6;
            this.linkSalirLogueado.TabStop = true;
            this.linkSalirLogueado.Text = "Cerrar Sesion";
            this.linkSalirLogueado.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSalirLogueado_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(149, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(386, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Seleccione una funcionalidad por favor";
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccion.Location = new System.Drawing.Point(361, 375);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(213, 42);
            this.btnSeleccion.TabIndex = 4;
            this.btnSeleccion.Text = "Seleccionar Funcion";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bienvenido a FRBACommerce";
            // 
            // listaFunciones
            // 
            this.listaFunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaFunciones.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listaFunciones.FormattingEnabled = true;
            this.listaFunciones.ItemHeight = 25;
            this.listaFunciones.Location = new System.Drawing.Point(108, 114);
            this.listaFunciones.Name = "listaFunciones";
            this.listaFunciones.Size = new System.Drawing.Size(466, 254);
            this.listaFunciones.TabIndex = 1;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.panelPpal);
            this.Controls.Add(this.panelInicio);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            this.panelPpal.ResumeLayout(false);
            this.panelPpal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_registro;
        private System.Windows.Forms.TextBox login_txtpass;
        private System.Windows.Forms.TextBox login_txtUsr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button login_btnIngresar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelPpal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listaFunciones;
        private System.Windows.Forms.LinkLabel linkSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.LinkLabel linkSalirLogueado;
        private System.Windows.Forms.Button btnModifPass;
    }
}