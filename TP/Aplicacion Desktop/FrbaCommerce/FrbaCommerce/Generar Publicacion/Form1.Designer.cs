namespace FrbaCommerce.Generar_Publicacion
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
            this.txt_desc = new System.Windows.Forms.RichTextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.lst_rubros = new System.Windows.Forms.CheckedListBox();
            this.cmb_visib = new System.Windows.Forms.ComboBox();
            this.cmb_tipoPub = new System.Windows.Forms.ComboBox();
            this.cmb_preg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cal_fechaVenc = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_publicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(86, 297);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(99, 20);
            this.txt_stock.TabIndex = 1;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(57, 46);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(429, 204);
            this.txt_desc.TabIndex = 2;
            this.txt_desc.Text = "";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(86, 365);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(68, 20);
            this.txt_precio.TabIndex = 3;
            
            // 2014-06-17 - JPB - Linea comentada debido a que da error. Solucionar.
            //this.txt_precio.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            
            // 
            // lst_rubros
            // 
            this.lst_rubros.FormattingEnabled = true;
            this.lst_rubros.Location = new System.Drawing.Point(548, 268);
            this.lst_rubros.Name = "lst_rubros";
            this.lst_rubros.Size = new System.Drawing.Size(129, 169);
            this.lst_rubros.TabIndex = 4;
            // 
            // cmb_visib
            // 
            this.cmb_visib.FormattingEnabled = true;
            this.cmb_visib.Location = new System.Drawing.Point(86, 401);
            this.cmb_visib.Name = "cmb_visib";
            this.cmb_visib.Size = new System.Drawing.Size(123, 21);
            this.cmb_visib.TabIndex = 5;
            // 
            // cmb_tipoPub
            // 
            this.cmb_tipoPub.FormattingEnabled = true;
            this.cmb_tipoPub.Location = new System.Drawing.Point(86, 266);
            this.cmb_tipoPub.Name = "cmb_tipoPub";
            this.cmb_tipoPub.Size = new System.Drawing.Size(123, 21);
            this.cmb_tipoPub.TabIndex = 6;
            this.cmb_tipoPub.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmb_preg
            // 
            this.cmb_preg.FormattingEnabled = true;
            this.cmb_preg.Location = new System.Drawing.Point(92, 446);
            this.cmb_preg.Name = "cmb_preg";
            this.cmb_preg.Size = new System.Drawing.Size(43, 21);
            this.cmb_preg.TabIndex = 7;
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
            this.label2.Location = new System.Drawing.Point(-1, 301);
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
            // cal_fechaVenc
            // 
            this.cal_fechaVenc.Location = new System.Drawing.Point(322, 282);
            this.cal_fechaVenc.Name = "cal_fechaVenc";
            this.cal_fechaVenc.TabIndex = 11;
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
            this.label5.Location = new System.Drawing.Point(-1, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Visibilidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 453);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 586);
            this.Controls.Add(this.btn_publicar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cal_fechaVenc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_preg);
            this.Controls.Add(this.cmb_tipoPub);
            this.Controls.Add(this.cmb_visib);
            this.Controls.Add(this.lst_rubros);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_stock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.RichTextBox txt_desc;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.CheckedListBox lst_rubros;
        private System.Windows.Forms.ComboBox cmb_visib;
        private System.Windows.Forms.ComboBox cmb_tipoPub;
        private System.Windows.Forms.ComboBox cmb_preg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar cal_fechaVenc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_publicar;
    }
}