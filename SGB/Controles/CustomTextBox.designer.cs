﻿namespace SGB.Controles
{
    partial class CustomTextBox
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tbx_Principal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.Tbx_Principal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbx_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbx_Principal.Location = new System.Drawing.Point(7, 7);
            this.Tbx_Principal.Name = "textBox1";
            this.Tbx_Principal.Size = new System.Drawing.Size(236, 16);
            this.Tbx_Principal.TabIndex = 0;
            this.Tbx_Principal.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // CustomTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.Tbx_Principal);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomTextBox";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbx_Principal;
    }
}
