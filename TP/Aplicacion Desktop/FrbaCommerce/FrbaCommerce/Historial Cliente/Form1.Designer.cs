namespace FrbaCommerce.Historial_Cliente
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgCompras = new System.Windows.Forms.DataGridView();
            this.dgcProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgOfertas = new System.Windows.Forms.DataGridView();
            this.dgoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgoSubasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgoFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCalificaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOfertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCalificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Compras",
            "Ofertas",
            "Calificaciones"});
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Operacion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgCompras
            // 
            this.dgCompras.AllowUserToAddRows = false;
            this.dgCompras.AllowUserToDeleteRows = false;
            this.dgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcProducto,
            this.dgcFecha});
            this.dgCompras.Location = new System.Drawing.Point(6, 75);
            this.dgCompras.Name = "dgCompras";
            this.dgCompras.ReadOnly = true;
            this.dgCompras.Size = new System.Drawing.Size(589, 174);
            this.dgCompras.TabIndex = 2;
            this.dgCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCompras_CellContentClick);
            // 
            // dgcProducto
            // 
            this.dgcProducto.HeaderText = "Producto";
            this.dgcProducto.Name = "dgcProducto";
            this.dgcProducto.ReadOnly = true;
            // 
            // dgcFecha
            // 
            this.dgcFecha.HeaderText = "Fecha";
            this.dgcFecha.Name = "dgcFecha";
            this.dgcFecha.ReadOnly = true;
            // 
            // dgOfertas
            // 
            this.dgOfertas.AllowUserToAddRows = false;
            this.dgOfertas.AllowUserToDeleteRows = false;
            this.dgOfertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOfertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgoProducto,
            this.dgoSubasta,
            this.dgoFecha});
            this.dgOfertas.Location = new System.Drawing.Point(6, 75);
            this.dgOfertas.Name = "dgOfertas";
            this.dgOfertas.ReadOnly = true;
            this.dgOfertas.Size = new System.Drawing.Size(589, 174);
            this.dgOfertas.TabIndex = 3;
            // 
            // dgoProducto
            // 
            this.dgoProducto.HeaderText = "Producto";
            this.dgoProducto.Name = "dgoProducto";
            this.dgoProducto.ReadOnly = true;
            // 
            // dgoSubasta
            // 
            this.dgoSubasta.HeaderText = "Subasta";
            this.dgoSubasta.Name = "dgoSubasta";
            this.dgoSubasta.ReadOnly = true;
            // 
            // dgoFecha
            // 
            this.dgoFecha.HeaderText = "Fecha";
            this.dgoFecha.Name = "dgoFecha";
            this.dgoFecha.ReadOnly = true;
            // 
            // dgCalificaciones
            // 
            this.dgCalificaciones.AllowUserToAddRows = false;
            this.dgCalificaciones.AllowUserToDeleteRows = false;
            this.dgCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCalificaciones.Location = new System.Drawing.Point(6, 75);
            this.dgCalificaciones.Name = "dgCalificaciones";
            this.dgCalificaciones.ReadOnly = true;
            this.dgCalificaciones.Size = new System.Drawing.Size(589, 174);
            this.dgCalificaciones.TabIndex = 4;
            this.dgCalificaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCalificaciones_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 257);
            this.Controls.Add(this.dgCalificaciones);
            this.Controls.Add(this.dgOfertas);
            this.Controls.Add(this.dgCompras);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Historial de Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOfertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCalificaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgCompras;
        private System.Windows.Forms.DataGridView dgOfertas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgoSubasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgoFecha;
        private System.Windows.Forms.DataGridView dgCalificaciones;
    }
}