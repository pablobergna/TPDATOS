namespace FrbaCommerce.Listado_Estadistico
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mes = new System.Windows.Forms.ComboBox();
            this.Visibilidad = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Reporte = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Trimestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Anio = new System.Windows.Forms.ComboBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dg4Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg4PublicacionesSinCalificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dg3Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg3Calificaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dg2Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg2Facturacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Mes);
            this.groupBox1.Controls.Add(this.Visibilidad);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Reporte);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Trimestre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Anio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView4);
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indique los Filtros";
            // 
            // Mes
            // 
            this.Mes.FormattingEnabled = true;
            this.Mes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Mes.Location = new System.Drawing.Point(59, 93);
            this.Mes.Name = "Mes";
            this.Mes.Size = new System.Drawing.Size(121, 21);
            this.Mes.TabIndex = 16;
            // 
            // Visibilidad
            // 
            this.Visibilidad.FormattingEnabled = true;
            this.Visibilidad.Location = new System.Drawing.Point(259, 96);
            this.Visibilidad.Name = "Visibilidad";
            this.Visibilidad.Size = new System.Drawing.Size(121, 21);
            this.Visibilidad.TabIndex = 15;
            this.Visibilidad.SelectedIndexChanged += new System.EventHandler(this.Visibilidad_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 85);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Visibilidad";
            // 
            // Reporte
            // 
            this.Reporte.FormattingEnabled = true;
            this.Reporte.Items.AddRange(new object[] {
            "Vendedores con mayor cantidad de productos no vendidos",
            "Vendedores con mayor facturación",
            "Vendedores con mayores calificaciones",
            "Clientes con mayor cantidad de publicaciones sin calificar"});
            this.Reporte.Location = new System.Drawing.Point(59, 61);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(321, 21);
            this.Reporte.TabIndex = 5;
            this.Reporte.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Top 5";
            // 
            // Trimestre
            // 
            this.Trimestre.FormattingEnabled = true;
            this.Trimestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.Trimestre.Location = new System.Drawing.Point(259, 29);
            this.Trimestre.Name = "Trimestre";
            this.Trimestre.Size = new System.Drawing.Size(121, 21);
            this.Trimestre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trimestre";
            // 
            // Anio
            // 
            this.Anio.FormattingEnabled = true;
            this.Anio.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014"});
            this.Anio.Location = new System.Drawing.Point(59, 29);
            this.Anio.Name = "Anio";
            this.Anio.Size = new System.Drawing.Size(121, 21);
            this.Anio.TabIndex = 1;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg4Cliente,
            this.dg4PublicacionesSinCalificar});
            this.dataGridView4.Location = new System.Drawing.Point(59, 134);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(321, 150);
            this.dataGridView4.TabIndex = 13;
            // 
            // dg4Cliente
            // 
            this.dg4Cliente.HeaderText = "Cliente";
            this.dg4Cliente.Name = "dg4Cliente";
            this.dg4Cliente.ReadOnly = true;
            // 
            // dg4PublicacionesSinCalificar
            // 
            this.dg4PublicacionesSinCalificar.HeaderText = "Publicaciones Sin Calificar";
            this.dg4PublicacionesSinCalificar.Name = "dg4PublicacionesSinCalificar";
            this.dg4PublicacionesSinCalificar.ReadOnly = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg3Vendedor,
            this.dg3Calificaciones});
            this.dataGridView3.Location = new System.Drawing.Point(59, 134);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(321, 150);
            this.dataGridView3.TabIndex = 12;
            // 
            // dg3Vendedor
            // 
            this.dg3Vendedor.HeaderText = "Vendedor";
            this.dg3Vendedor.Name = "dg3Vendedor";
            this.dg3Vendedor.ReadOnly = true;
            // 
            // dg3Calificaciones
            // 
            this.dg3Calificaciones.HeaderText = "Calificaciones";
            this.dg3Calificaciones.Name = "dg3Calificaciones";
            this.dg3Calificaciones.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg2Vendedor,
            this.dg2Facturacion});
            this.dataGridView2.Location = new System.Drawing.Point(59, 134);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(321, 150);
            this.dataGridView2.TabIndex = 11;
            // 
            // dg2Vendedor
            // 
            this.dg2Vendedor.HeaderText = "Vendedor";
            this.dg2Vendedor.Name = "dg2Vendedor";
            this.dg2Vendedor.ReadOnly = true;
            // 
            // dg2Facturacion
            // 
            this.dg2Facturacion.HeaderText = "Facturacion";
            this.dg2Facturacion.Name = "dg2Facturacion";
            this.dg2Facturacion.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 323);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Listado Estadistico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Anio;
        private System.Windows.Forms.ComboBox Reporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Trimestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg3Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg3Calificaciones;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg2Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg2Facturacion;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg4Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg4PublicacionesSinCalificar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Visibilidad;
        private System.Windows.Forms.ComboBox Mes;
    }
}