namespace FrbaCommerce.Abm_Visibilidad
{
    partial class Alta_Visibilidad
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.visCodigo = new System.Windows.Forms.TextBox();
            this.visDescrip = new System.Windows.Forms.TextBox();
            this.visPrecio = new System.Windows.Forms.TextBox();
            this.visPorcentaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio por \r\nPublicar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Porcentaje \r\nde la Venta:";
            // 
            // visCodigo
            // 
            this.visCodigo.Location = new System.Drawing.Point(96, 20);
            this.visCodigo.Name = "visCodigo";
            this.visCodigo.Size = new System.Drawing.Size(131, 20);
            this.visCodigo.TabIndex = 4;
            // 
            // visDescrip
            // 
            this.visDescrip.Location = new System.Drawing.Point(96, 47);
            this.visDescrip.Name = "visDescrip";
            this.visDescrip.Size = new System.Drawing.Size(233, 20);
            this.visDescrip.TabIndex = 5;
            // 
            // visPrecio
            // 
            this.visPrecio.Location = new System.Drawing.Point(96, 80);
            this.visPrecio.Name = "visPrecio";
            this.visPrecio.Size = new System.Drawing.Size(100, 20);
            this.visPrecio.TabIndex = 6;
            // 
            // visPorcentaje
            // 
            this.visPorcentaje.Location = new System.Drawing.Point(96, 114);
            this.visPorcentaje.Name = "visPorcentaje";
            this.visPorcentaje.Size = new System.Drawing.Size(100, 20);
            this.visPorcentaje.TabIndex = 7;
            // 
            // Alta_Visibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 540);
            this.Controls.Add(this.visPorcentaje);
            this.Controls.Add(this.visPrecio);
            this.Controls.Add(this.visDescrip);
            this.Controls.Add(this.visCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Alta_Visibilidad";
            this.Text = "Alta Visibilidad de Publicación";
            this.Load += new System.EventHandler(this.Alta_Visibilidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox visCodigo;
        private System.Windows.Forms.TextBox visDescrip;
        private System.Windows.Forms.TextBox visPrecio;
        private System.Windows.Forms.TextBox visPorcentaje;
    }
}