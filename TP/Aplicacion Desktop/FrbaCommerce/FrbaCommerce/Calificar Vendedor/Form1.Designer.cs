namespace FrbaCommerce.Calificar_Vendedor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Calificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Estrellas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.ComboBox();
            this.Comentario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Calificacion = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Calificacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Comentario);
            this.groupBox1.Controls.Add(this.Calificar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Estrellas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Producto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Producto";
            // 
            // Calificar
            // 
            this.Calificar.Location = new System.Drawing.Point(6, 202);
            this.Calificar.Name = "Calificar";
            this.Calificar.Size = new System.Drawing.Size(211, 29);
            this.Calificar.TabIndex = 5;
            this.Calificar.Text = "Calificar";
            this.Calificar.UseVisualStyleBackColor = true;
            this.Calificar.Click += new System.EventHandler(this.Calificar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estrellas:";
            // 
            // Estrellas
            // 
            this.Estrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Estrellas.FormattingEnabled = true;
            this.Estrellas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Estrellas.Location = new System.Drawing.Point(74, 85);
            this.Estrellas.Name = "Estrellas";
            this.Estrellas.Size = new System.Drawing.Size(143, 21);
            this.Estrellas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comentario: ";
            // 
            // Producto
            // 
            this.Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Producto.FormattingEnabled = true;
            this.Producto.Location = new System.Drawing.Point(6, 19);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(214, 21);
            this.Producto.TabIndex = 0;
            //this.Producto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Comentario
            // 
            this.Comentario.Location = new System.Drawing.Point(12, 128);
            this.Comentario.MaxLength = 250;
            this.Comentario.Multiline = true;
            this.Comentario.Name = "Comentario";
            this.Comentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Comentario.Size = new System.Drawing.Size(208, 53);
            this.Comentario.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calificación:";
            // 
            // Calificacion
            // 
            this.Calificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Calificacion.FormattingEnabled = true;
            this.Calificacion.Location = new System.Drawing.Point(76, 53);
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.Size = new System.Drawing.Size(141, 21);
            this.Calificacion.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 267);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calificar Vendedor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Estrellas;
        private System.Windows.Forms.TextBox Comentario;
        private System.Windows.Forms.ComboBox Calificacion;
        private System.Windows.Forms.Label label4;
    }
}