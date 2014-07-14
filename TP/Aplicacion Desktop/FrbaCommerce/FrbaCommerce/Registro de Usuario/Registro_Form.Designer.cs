namespace FrbaCommerce.Registro_de_Usuario
{
    partial class Registro_Form
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
            this.usr_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usr_pass = new System.Windows.Forms.TextBox();
            this.btn_reg_siguiente = new System.Windows.Forms.Button();
            this.btn_reg_canelar = new System.Windows.Forms.Button();
            this.reg_comboRoles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // usr_nombre
            // 
            this.usr_nombre.Location = new System.Drawing.Point(266, 73);
            this.usr_nombre.Name = "usr_nombre";
            this.usr_nombre.Size = new System.Drawing.Size(100, 20);
            this.usr_nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rol";
            // 
            // usr_pass
            // 
            this.usr_pass.Location = new System.Drawing.Point(275, 121);
            this.usr_pass.Name = "usr_pass";
            this.usr_pass.PasswordChar = '*';
            this.usr_pass.Size = new System.Drawing.Size(100, 20);
            this.usr_pass.TabIndex = 4;
            // 
            // btn_reg_siguiente
            // 
            this.btn_reg_siguiente.Location = new System.Drawing.Point(471, 163);
            this.btn_reg_siguiente.Name = "btn_reg_siguiente";
            this.btn_reg_siguiente.Size = new System.Drawing.Size(75, 23);
            this.btn_reg_siguiente.TabIndex = 6;
            this.btn_reg_siguiente.Text = "Siguiente";
            this.btn_reg_siguiente.UseVisualStyleBackColor = true;
            this.btn_reg_siguiente.Click += new System.EventHandler(this.btn_reg_siguiente_Click);
            // 
            // btn_reg_canelar
            // 
            this.btn_reg_canelar.Location = new System.Drawing.Point(471, 56);
            this.btn_reg_canelar.Name = "btn_reg_canelar";
            this.btn_reg_canelar.Size = new System.Drawing.Size(75, 23);
            this.btn_reg_canelar.TabIndex = 7;
            this.btn_reg_canelar.Text = "Cancelar";
            this.btn_reg_canelar.UseVisualStyleBackColor = true;
            this.btn_reg_canelar.Click += new System.EventHandler(this.btn_reg_canelar_Click);
            // 
            // reg_comboRoles
            // 
            this.reg_comboRoles.FormattingEnabled = true;
            this.reg_comboRoles.Location = new System.Drawing.Point(275, 165);
            this.reg_comboRoles.Name = "reg_comboRoles";
            this.reg_comboRoles.Size = new System.Drawing.Size(121, 21);
            this.reg_comboRoles.TabIndex = 8;
            // 
            // Registro_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.reg_comboRoles);
            this.Controls.Add(this.btn_reg_canelar);
            this.Controls.Add(this.btn_reg_siguiente);
            this.Controls.Add(this.usr_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usr_nombre);
            this.Name = "Registro_Form";
            this.Text = "Registracion";
            this.Load += new System.EventHandler(this.Registro_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usr_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usr_pass;
        private System.Windows.Forms.Button btn_reg_siguiente;
        private System.Windows.Forms.Button btn_reg_canelar;
        private System.Windows.Forms.ComboBox reg_comboRoles;
    }
}