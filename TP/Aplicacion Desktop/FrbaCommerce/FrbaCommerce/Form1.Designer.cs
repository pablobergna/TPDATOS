namespace FrbaCommerce
{
    partial class Form1
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
		
		/* esta sería la parte de logica que va, es el login*/
		  private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.logUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logPassw = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // logUser
            // 
            this.logUser.Location = new System.Drawing.Point(74, 32);
            this.logUser.Name = "logUser";
            this.logUser.Size = new System.Drawing.Size(138, 20);
            this.logUser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // logPassw
            // 
            this.logPassw.Location = new System.Drawing.Point(74, 70);
            this.logPassw.Name = "logPassw";
            this.logPassw.Size = new System.Drawing.Size(138, 20);
            this.logPassw.TabIndex = 5;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(74, 135);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(162, 135);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.logPassw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logUser);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox logUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logPassw;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button button1;

    }


		/* esta logíca no debería ir acá, sino en la ventana main
        private void InitializeComponent()
        {
            this.HistorialClientes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CalificarVendedor = new System.Windows.Forms.Button();
            this.FacturarPublicaciones = new System.Windows.Forms.Button();
            this.ListadoEstadistico = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HistorialClientes
            // 
            this.HistorialClientes.Location = new System.Drawing.Point(33, 31);
            this.HistorialClientes.Name = "HistorialClientes";
            this.HistorialClientes.Size = new System.Drawing.Size(130, 23);
            this.HistorialClientes.TabIndex = 0;
            this.HistorialClientes.Text = "Historial Clientes";
            this.HistorialClientes.UseVisualStyleBackColor = true;
            this.HistorialClientes.Click += new System.EventHandler(this.HistorialClientes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListadoEstadistico);
            this.groupBox1.Controls.Add(this.FacturarPublicaciones);
            this.groupBox1.Controls.Add(this.CalificarVendedor);
            this.groupBox1.Controls.Add(this.HistorialClientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secciones";
            // 
            // CalificarVendedor
            // 
            this.CalificarVendedor.Location = new System.Drawing.Point(33, 60);
            this.CalificarVendedor.Name = "CalificarVendedor";
            this.CalificarVendedor.Size = new System.Drawing.Size(130, 23);
            this.CalificarVendedor.TabIndex = 1;
            this.CalificarVendedor.Text = "Calificar Vendedor";
            this.CalificarVendedor.UseVisualStyleBackColor = true;
            this.CalificarVendedor.Click += new System.EventHandler(this.CalificarVendedor_Click);
            // 
            // FacturarPublicaciones
            // 
            this.FacturarPublicaciones.Location = new System.Drawing.Point(33, 89);
            this.FacturarPublicaciones.Name = "FacturarPublicaciones";
            this.FacturarPublicaciones.Size = new System.Drawing.Size(130, 23);
            this.FacturarPublicaciones.TabIndex = 2;
            this.FacturarPublicaciones.Text = "Facturar Publicaciones";
            this.FacturarPublicaciones.UseVisualStyleBackColor = true;
            this.FacturarPublicaciones.Click += new System.EventHandler(this.FacturarPublicaciones_Click);
            // 
            // ListadoEstadistico
            // 
            this.ListadoEstadistico.Location = new System.Drawing.Point(33, 117);
            this.ListadoEstadistico.Name = "ListadoEstadistico";
            this.ListadoEstadistico.Size = new System.Drawing.Size(130, 23);
            this.ListadoEstadistico.TabIndex = 3;
            this.ListadoEstadistico.Text = "Listado Estadistico";
            this.ListadoEstadistico.UseVisualStyleBackColor = true;
            this.ListadoEstadistico.Click += new System.EventHandler(this.ListadoEstadistico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 183);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "FRBA Commerce";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HistorialClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CalificarVendedor;
        private System.Windows.Forms.Button FacturarPublicaciones;
        private System.Windows.Forms.Button ListadoEstadistico;
    }
	*/
	
	
}

