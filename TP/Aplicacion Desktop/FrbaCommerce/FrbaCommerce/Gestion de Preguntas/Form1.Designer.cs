namespace FrbaCommerce.Gestion_de_Preguntas
{
    partial class Gestion_de_Preguntas
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
            this.gb_opciones = new System.Windows.Forms.GroupBox();
            this.btn_ver_respuestas = new System.Windows.Forms.Button();
            this.btn_responder_preguntas = new System.Windows.Forms.Button();
            this.gb_usuario = new System.Windows.Forms.GroupBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.gb_responder_preguntas = new System.Windows.Forms.GroupBox();
            this.btn_responder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_respuesta = new System.Windows.Forms.RichTextBox();
            this.lst_preguntas = new System.Windows.Forms.ListBox();
            this.gb_ver_respuestas = new System.Windows.Forms.GroupBox();
            this.dg_respuestas = new System.Windows.Forms.DataGridView();
            this.gb_opciones.SuspendLayout();
            this.gb_usuario.SuspendLayout();
            this.gb_responder_preguntas.SuspendLayout();
            this.gb_ver_respuestas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_respuestas)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_opciones
            // 
            this.gb_opciones.Controls.Add(this.btn_ver_respuestas);
            this.gb_opciones.Controls.Add(this.btn_responder_preguntas);
            this.gb_opciones.Location = new System.Drawing.Point(20, 48);
            this.gb_opciones.Name = "gb_opciones";
            this.gb_opciones.Size = new System.Drawing.Size(309, 93);
            this.gb_opciones.TabIndex = 0;
            this.gb_opciones.TabStop = false;
            this.gb_opciones.Text = "Opciones";
            // 
            // btn_ver_respuestas
            // 
            this.btn_ver_respuestas.Location = new System.Drawing.Point(154, 32);
            this.btn_ver_respuestas.Name = "btn_ver_respuestas";
            this.btn_ver_respuestas.Size = new System.Drawing.Size(111, 40);
            this.btn_ver_respuestas.TabIndex = 1;
            this.btn_ver_respuestas.Text = "Ver Respuestas";
            this.btn_ver_respuestas.UseVisualStyleBackColor = true;
            this.btn_ver_respuestas.Click += new System.EventHandler(this.btn_ver_respuestas_Click);
            // 
            // btn_responder_preguntas
            // 
            this.btn_responder_preguntas.Location = new System.Drawing.Point(37, 33);
            this.btn_responder_preguntas.Name = "btn_responder_preguntas";
            this.btn_responder_preguntas.Size = new System.Drawing.Size(111, 39);
            this.btn_responder_preguntas.TabIndex = 0;
            this.btn_responder_preguntas.Text = "Responder Preguntas";
            this.btn_responder_preguntas.UseVisualStyleBackColor = true;
            this.btn_responder_preguntas.Click += new System.EventHandler(this.btn_responder_preguntas_Click);
            // 
            // gb_usuario
            // 
            this.gb_usuario.Controls.Add(this.lbl_usuario);
            this.gb_usuario.Location = new System.Drawing.Point(20, 6);
            this.gb_usuario.Name = "gb_usuario";
            this.gb_usuario.Size = new System.Drawing.Size(322, 36);
            this.gb_usuario.TabIndex = 1;
            this.gb_usuario.TabStop = false;
            this.gb_usuario.Text = "Usuario Logueado";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(10, 16);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(49, 13);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuario: ";
            // 
            // gb_responder_preguntas
            // 
            this.gb_responder_preguntas.Controls.Add(this.btn_responder);
            this.gb_responder_preguntas.Controls.Add(this.label2);
            this.gb_responder_preguntas.Controls.Add(this.label1);
            this.gb_responder_preguntas.Controls.Add(this.txt_respuesta);
            this.gb_responder_preguntas.Controls.Add(this.lst_preguntas);
            this.gb_responder_preguntas.Location = new System.Drawing.Point(20, 160);
            this.gb_responder_preguntas.Name = "gb_responder_preguntas";
            this.gb_responder_preguntas.Size = new System.Drawing.Size(849, 432);
            this.gb_responder_preguntas.TabIndex = 2;
            this.gb_responder_preguntas.TabStop = false;
            this.gb_responder_preguntas.Text = "Responder Preguntas";
            this.gb_responder_preguntas.Visible = false;
            // 
            // btn_responder
            // 
            this.btn_responder.Location = new System.Drawing.Point(418, 317);
            this.btn_responder.Name = "btn_responder";
            this.btn_responder.Size = new System.Drawing.Size(397, 52);
            this.btn_responder.TabIndex = 4;
            this.btn_responder.Text = "Responder";
            this.btn_responder.UseVisualStyleBackColor = true;
            this.btn_responder.Click += new System.EventHandler(this.btn_responder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Respuesta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preguntas: (Seleccionar pregunta a responder)";
            // 
            // txt_respuesta
            // 
            this.txt_respuesta.Location = new System.Drawing.Point(418, 59);
            this.txt_respuesta.Name = "txt_respuesta";
            this.txt_respuesta.Size = new System.Drawing.Size(401, 241);
            this.txt_respuesta.TabIndex = 1;
            this.txt_respuesta.Text = "";
            // 
            // lst_preguntas
            // 
            this.lst_preguntas.FormattingEnabled = true;
            this.lst_preguntas.Location = new System.Drawing.Point(22, 59);
            this.lst_preguntas.Name = "lst_preguntas";
            this.lst_preguntas.Size = new System.Drawing.Size(345, 355);
            this.lst_preguntas.TabIndex = 0;
            // 
            // gb_ver_respuestas
            // 
            this.gb_ver_respuestas.Controls.Add(this.dg_respuestas);
            this.gb_ver_respuestas.Location = new System.Drawing.Point(20, 162);
            this.gb_ver_respuestas.Name = "gb_ver_respuestas";
            this.gb_ver_respuestas.Size = new System.Drawing.Size(849, 430);
            this.gb_ver_respuestas.TabIndex = 3;
            this.gb_ver_respuestas.TabStop = false;
            this.gb_ver_respuestas.Text = "Ver Respuestas";
            // 
            // dg_respuestas
            // 
            this.dg_respuestas.AllowUserToOrderColumns = true;
            this.dg_respuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_respuestas.Location = new System.Drawing.Point(21, 21);
            this.dg_respuestas.Name = "dg_respuestas";
            this.dg_respuestas.Size = new System.Drawing.Size(798, 384);
            this.dg_respuestas.TabIndex = 1;
            this.dg_respuestas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_respuestas_CellContentClick);
            // 
            // Gestion_de_Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 641);
            this.Controls.Add(this.gb_ver_respuestas);
            this.Controls.Add(this.gb_usuario);
            this.Controls.Add(this.gb_opciones);
            this.Controls.Add(this.gb_responder_preguntas);
            this.Name = "Gestion_de_Preguntas";
            this.Text = "Gestion de Preguntas";
            this.Load += new System.EventHandler(this.Gestion_de_Preguntas_Load);
            this.gb_opciones.ResumeLayout(false);
            this.gb_usuario.ResumeLayout(false);
            this.gb_usuario.PerformLayout();
            this.gb_responder_preguntas.ResumeLayout(false);
            this.gb_responder_preguntas.PerformLayout();
            this.gb_ver_respuestas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_respuestas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_opciones;
        private System.Windows.Forms.GroupBox gb_usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Button btn_ver_respuestas;
        private System.Windows.Forms.Button btn_responder_preguntas;
        private System.Windows.Forms.GroupBox gb_responder_preguntas;
        private System.Windows.Forms.GroupBox gb_ver_respuestas;
        private System.Windows.Forms.DataGridView dg_respuestas;
        private System.Windows.Forms.ListBox lst_preguntas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_respuesta;
        private System.Windows.Forms.Button btn_responder;
        private System.Windows.Forms.Label label2;
    }
}