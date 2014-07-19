namespace FrbaCommerce.Comprar_Ofertar
{
    partial class Preguntar
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtPreg = new System.Windows.Forms.TextBox();
            this.btnPreg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ingrese su pregunta";
            // 
            // txtPreg
            // 
            this.txtPreg.Location = new System.Drawing.Point(44, 66);
            this.txtPreg.Multiline = true;
            this.txtPreg.Name = "txtPreg";
            this.txtPreg.Size = new System.Drawing.Size(435, 145);
            this.txtPreg.TabIndex = 8;
            // 
            // btnPreg
            // 
            this.btnPreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreg.Location = new System.Drawing.Point(198, 235);
            this.btnPreg.Name = "btnPreg";
            this.btnPreg.Size = new System.Drawing.Size(127, 37);
            this.btnPreg.TabIndex = 9;
            this.btnPreg.Text = "Preguntar";
            this.btnPreg.UseVisualStyleBackColor = true;
            this.btnPreg.Click += new System.EventHandler(this.btnPreg_Click);
            // 
            // Preguntar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 296);
            this.Controls.Add(this.btnPreg);
            this.Controls.Add(this.txtPreg);
            this.Controls.Add(this.label6);
            this.Name = "Preguntar";
            this.Text = "Preguntar";
            this.Load += new System.EventHandler(this.Preguntar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPreg;
        private System.Windows.Forms.Button btnPreg;
    }
}