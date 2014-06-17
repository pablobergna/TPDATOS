namespace FrbaCommerce.Facturar_Publicaciones
{
    partial class FacturarPublicaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgFacturarPublicaciones = new System.Windows.Forms.DataGridView();
            this.dgfpSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgfpDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgfpCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgfpImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Emisora = new System.Windows.Forms.ComboBox();
            this.Banco = new System.Windows.Forms.ComboBox();
            this.Numero = new System.Windows.Forms.TextBox();
            this.Vencimiento = new System.Windows.Forms.TextBox();
            this.CodigoDeSeguridad = new System.Windows.Forms.TextBox();
            this.Pagar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturarPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pagar);
            this.groupBox1.Controls.Add(this.CodigoDeSeguridad);
            this.groupBox1.Controls.Add(this.Vencimiento);
            this.groupBox1.Controls.Add(this.Numero);
            this.groupBox1.Controls.Add(this.Banco);
            this.groupBox1.Controls.Add(this.Emisora);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgFacturarPublicaciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione lo que desea Rendir";
            // 
            // dgFacturarPublicaciones
            // 
            this.dgFacturarPublicaciones.AllowUserToAddRows = false;
            this.dgFacturarPublicaciones.AllowUserToDeleteRows = false;
            this.dgFacturarPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacturarPublicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgfpSeleccionar,
            this.dgfpDescripcion,
            this.dgfpCantidad,
            this.dgfpImporte});
            this.dgFacturarPublicaciones.Location = new System.Drawing.Point(3, 16);
            this.dgFacturarPublicaciones.Name = "dgFacturarPublicaciones";
            this.dgFacturarPublicaciones.ReadOnly = true;
            this.dgFacturarPublicaciones.Size = new System.Drawing.Size(443, 150);
            this.dgFacturarPublicaciones.TabIndex = 0;
            // 
            // dgfpSeleccionar
            // 
            this.dgfpSeleccionar.HeaderText = "Seleccionar";
            this.dgfpSeleccionar.Name = "dgfpSeleccionar";
            this.dgfpSeleccionar.ReadOnly = true;
            // 
            // dgfpDescripcion
            // 
            this.dgfpDescripcion.HeaderText = "Descripcion";
            this.dgfpDescripcion.Name = "dgfpDescripcion";
            this.dgfpDescripcion.ReadOnly = true;
            // 
            // dgfpCantidad
            // 
            this.dgfpCantidad.HeaderText = "Cantidad";
            this.dgfpCantidad.Name = "dgfpCantidad";
            this.dgfpCantidad.ReadOnly = true;
            // 
            // dgfpImporte
            // 
            this.dgfpImporte.HeaderText = "Importe";
            this.dgfpImporte.Name = "dgfpImporte";
            this.dgfpImporte.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forma de Pago:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Credito"});
            this.comboBox1.Location = new System.Drawing.Point(94, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Emisora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Banco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vencimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Codigo de Seguridad";
            // 
            // Emisora
            // 
            this.Emisora.FormattingEnabled = true;
            this.Emisora.Items.AddRange(new object[] {
            "Visa",
            "Mastercard"});
            this.Emisora.Location = new System.Drawing.Point(373, 180);
            this.Emisora.Name = "Emisora";
            this.Emisora.Size = new System.Drawing.Size(121, 21);
            this.Emisora.TabIndex = 8;
            // 
            // Banco
            // 
            this.Banco.FormattingEnabled = true;
            this.Banco.Items.AddRange(new object[] {
            "Citibank",
            "Santander Rio",
            "Galicia"});
            this.Banco.Location = new System.Drawing.Point(373, 206);
            this.Banco.Name = "Banco";
            this.Banco.Size = new System.Drawing.Size(121, 21);
            this.Banco.TabIndex = 9;
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(372, 233);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(121, 20);
            this.Numero.TabIndex = 10;
            // 
            // Vencimiento
            // 
            this.Vencimiento.Location = new System.Drawing.Point(372, 256);
            this.Vencimiento.Name = "Vencimiento";
            this.Vencimiento.Size = new System.Drawing.Size(121, 20);
            this.Vencimiento.TabIndex = 11;
            // 
            // CodigoDeSeguridad
            // 
            this.CodigoDeSeguridad.Location = new System.Drawing.Point(372, 282);
            this.CodigoDeSeguridad.Name = "CodigoDeSeguridad";
            this.CodigoDeSeguridad.Size = new System.Drawing.Size(121, 20);
            this.CodigoDeSeguridad.TabIndex = 12;
            // 
            // Pagar
            // 
            this.Pagar.Location = new System.Drawing.Point(9, 246);
            this.Pagar.Name = "Pagar";
            this.Pagar.Size = new System.Drawing.Size(202, 23);
            this.Pagar.TabIndex = 13;
            this.Pagar.Text = "Pagar";
            this.Pagar.UseVisualStyleBackColor = true;
            this.Pagar.Click += new System.EventHandler(this.Pagar_Click);
            // 
            // FacturarPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 336);
            this.Controls.Add(this.groupBox1);
            this.Name = "FacturarPublicaciones";
            this.Text = "Facturar Publicaciones";
            this.Load += new System.EventHandler(this.FacturarPublicaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturarPublicaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgFacturarPublicaciones;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgfpSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgfpDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgfpCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgfpImporte;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox Banco;
        private System.Windows.Forms.ComboBox Emisora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Pagar;
        private System.Windows.Forms.TextBox CodigoDeSeguridad;
        private System.Windows.Forms.TextBox Vencimiento;
        private System.Windows.Forms.TextBox Numero;
    }
}