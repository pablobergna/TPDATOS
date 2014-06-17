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
        private void InitializeComponent()
        {
            this.HistorialClientes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CalificarVendedor = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.CalificarVendedor);
            this.groupBox1.Controls.Add(this.HistorialClientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 146);
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
    }
}

