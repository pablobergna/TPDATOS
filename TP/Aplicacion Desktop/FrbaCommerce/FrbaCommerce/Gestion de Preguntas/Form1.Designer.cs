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
            this.gb_ver_respuestas = new System.Windows.Forms.GroupBox();
            this.lst_respuestas = new System.Windows.Forms.ListBox();
            this.dg_respuestas = new System.Windows.Forms.DataGridView();
            this.gb_opciones.SuspendLayout();
            this.gb_usuario.SuspendLayout();
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
            this.gb_responder_preguntas.Location = new System.Drawing.Point(17, 153);
            this.gb_responder_preguntas.Name = "gb_responder_preguntas";
            this.gb_responder_preguntas.Size = new System.Drawing.Size(661, 309);
            this.gb_responder_preguntas.TabIndex = 2;
            this.gb_responder_preguntas.TabStop = false;
            this.gb_responder_preguntas.Text = "Responder Preguntas";
            this.gb_responder_preguntas.Visible = false;
            // 
            // gb_ver_respuestas
            // 
            this.gb_ver_respuestas.Controls.Add(this.dg_respuestas);
            this.gb_ver_respuestas.Controls.Add(this.lst_respuestas);
            this.gb_ver_respuestas.Location = new System.Drawing.Point(17, 153);
            this.gb_ver_respuestas.Name = "gb_ver_respuestas";
            this.gb_ver_respuestas.Size = new System.Drawing.Size(661, 309);
            this.gb_ver_respuestas.TabIndex = 3;
            this.gb_ver_respuestas.TabStop = false;
            this.gb_ver_respuestas.Text = "Ver Respuestas";
            // 
            // lst_respuestas
            // 
            this.lst_respuestas.FormattingEnabled = true;
            this.lst_respuestas.Location = new System.Drawing.Point(25, 27);
            this.lst_respuestas.Name = "lst_respuestas";
            this.lst_respuestas.Size = new System.Drawing.Size(456, 264);
            this.lst_respuestas.TabIndex = 0;
            this.lst_respuestas.SelectedIndexChanged += new System.EventHandler(this.lst_respuestas_SelectedIndexChanged);
            // 
            // dg_respuestas
            // 
            this.dg_respuestas.AllowUserToOrderColumns = true;
            this.dg_respuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_respuestas.Location = new System.Drawing.Point(505, 31);
            this.dg_respuestas.Name = "dg_respuestas";
            this.dg_respuestas.Size = new System.Drawing.Size(140, 259);
            this.dg_respuestas.TabIndex = 1;
            // 
            // Gestion_de_Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 474);
            this.Controls.Add(this.gb_ver_respuestas);
            this.Controls.Add(this.gb_responder_preguntas);
            this.Controls.Add(this.gb_usuario);
            this.Controls.Add(this.gb_opciones);
            this.Name = "Gestion_de_Preguntas";
            this.Text = "Gestion de Preguntas";
            this.Load += new System.EventHandler(this.Gestion_de_Preguntas_Load);
            this.gb_opciones.ResumeLayout(false);
            this.gb_usuario.ResumeLayout(false);
            this.gb_usuario.PerformLayout();
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
        private System.Windows.Forms.ListBox lst_respuestas;
        private System.Windows.Forms.DataGridView dg_respuestas;
    }
}