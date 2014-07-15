﻿namespace FrbaCommerce.Generar_Publicacion
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
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.RichTextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.cmb_preguntas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cal_fechaVencimiento = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_publicar = new System.Windows.Forms.Button();
            this.rb_subasta = new System.Windows.Forms.RadioButton();
            this.rb_compra_inmediata = new System.Windows.Forms.RadioButton();
            this.lst_rubros = new System.Windows.Forms.ListBox();
            this.lst_visibilidad = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(93, 297);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(99, 20);
            this.txt_stock.TabIndex = 1;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(57, 46);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(620, 190);
            this.txt_descripcion.TabIndex = 2;
            this.txt_descripcion.Text = "";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(93, 345);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(68, 20);
            this.txt_precio.TabIndex = 3;
            // 
            // cmb_preguntas
            // 
            this.cmb_preguntas.FormattingEnabled = true;
            this.cmb_preguntas.Location = new System.Drawing.Point(92, 508);
            this.cmb_preguntas.Name = "cmb_preguntas";
            this.cmb_preguntas.Size = new System.Drawing.Size(43, 21);
            this.cmb_preguntas.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipo Publicacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vencimiento";
            // 
            // cal_fechaVencimiento
            // 
            this.cal_fechaVencimiento.Location = new System.Drawing.Point(322, 282);
            this.cal_fechaVencimiento.MaxSelectionCount = 1;
            this.cal_fechaVencimiento.Name = "cal_fechaVencimiento";
            this.cal_fechaVencimiento.TabIndex = 11;
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rubros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Visibilidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 512);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Permitir Preguntas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Descripcion";
            // 
            // btn_publicar
            // 
            this.btn_publicar.Location = new System.Drawing.Point(288, 472);
            this.btn_publicar.Name = "btn_publicar";
            this.btn_publicar.Size = new System.Drawing.Size(124, 56);
            this.btn_publicar.TabIndex = 17;
            this.btn_publicar.Text = "Generar Publicacion";
            this.btn_publicar.UseVisualStyleBackColor = true;
            this.btn_publicar.Click += new System.EventHandler(this.btn_publicar_Click);
            // 
            // rb_subasta
            // 
            this.rb_subasta.AutoSize = true;
            this.rb_subasta.Location = new System.Drawing.Point(93, 269);
            this.rb_subasta.Name = "rb_subasta";
            this.rb_subasta.Size = new System.Drawing.Size(64, 17);
            this.rb_subasta.TabIndex = 18;
            this.rb_subasta.TabStop = true;
            this.rb_subasta.Text = "Subasta";
            this.rb_subasta.UseVisualStyleBackColor = true;
            // 
            // rb_compra_inmediata
            // 
            this.rb_compra_inmediata.AutoSize = true;
            this.rb_compra_inmediata.Location = new System.Drawing.Point(173, 269);
            this.rb_compra_inmediata.Name = "rb_compra_inmediata";
            this.rb_compra_inmediata.Size = new System.Drawing.Size(110, 17);
            this.rb_compra_inmediata.TabIndex = 19;
            this.rb_compra_inmediata.TabStop = true;
            this.rb_compra_inmediata.Text = "Compra Inmediata";
            this.rb_compra_inmediata.UseVisualStyleBackColor = true;
            // 
            // lst_rubros
            // 
            this.lst_rubros.FormattingEnabled = true;
            this.lst_rubros.Location = new System.Drawing.Point(547, 278);
            this.lst_rubros.Name = "lst_rubros";
            this.lst_rubros.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_rubros.Size = new System.Drawing.Size(129, 251);
            this.lst_rubros.TabIndex = 20;
            // 
            // lst_visibilidad
            // 
            this.lst_visibilidad.FormattingEnabled = true;
            this.lst_visibilidad.Location = new System.Drawing.Point(93, 407);
            this.lst_visibilidad.Name = "lst_visibilidad";
            this.lst_visibilidad.Size = new System.Drawing.Size(104, 95);
            this.lst_visibilidad.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 586);
            this.Controls.Add(this.lst_visibilidad);
            this.Controls.Add(this.lst_rubros);
            this.Controls.Add(this.rb_compra_inmediata);
            this.Controls.Add(this.rb_subasta);
            this.Controls.Add(this.btn_publicar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cal_fechaVencimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_preguntas);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_stock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.RichTextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.ComboBox cmb_preguntas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar cal_fechaVencimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_publicar;
        private System.Windows.Forms.RadioButton rb_subasta;
        private System.Windows.Forms.RadioButton rb_compra_inmediata;
        private System.Windows.Forms.ListBox lst_rubros;
        private System.Windows.Forms.ListBox lst_visibilidad;
    }
}