﻿namespace Clinica_Frba.Cancelar_Atencion
{
    partial class SetMotivoCancelarPeriodo
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
            this.SuspendLayout();
            // 
            // motivoTextBox
            // 
            this.motivoTextBox.MaxLength = 255;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.Text = "ingrese el motivo de la cancelacion del periodo";
            // 
            // SetMotivoCancelarPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 204);
            this.Name = "SetMotivoCancelarPeriodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}