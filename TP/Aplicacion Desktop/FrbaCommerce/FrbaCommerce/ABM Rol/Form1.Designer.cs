namespace FrbaCommerce.ABM_Rol
{
    partial class Alta_Rol
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
            this.label2 = new System.Windows.Forms.Label();
            this.rolNombre = new System.Windows.Forms.TextBox();
            this.rolFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Listado de \r\nFuncionalidades:";
            // 
            // rolNombre
            // 
            this.rolNombre.Location = new System.Drawing.Point(108, 19);
            this.rolNombre.Name = "rolNombre";
            this.rolNombre.Size = new System.Drawing.Size(100, 20);
            this.rolNombre.TabIndex = 2;
            // 
            // rolFuncionalidades
            // 
            this.rolFuncionalidades.FormattingEnabled = true;
            this.rolFuncionalidades.Location = new System.Drawing.Point(108, 46);
            this.rolFuncionalidades.Name = "rolFuncionalidades";
            this.rolFuncionalidades.Size = new System.Drawing.Size(120, 34);
            this.rolFuncionalidades.TabIndex = 3;
            // 
            // Alta_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 540);
            this.Controls.Add(this.rolFuncionalidades);
            this.Controls.Add(this.rolNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Alta_Rol";
            this.Text = "Alta Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rolNombre;
        private System.Windows.Forms.CheckedListBox rolFuncionalidades;
    }
}