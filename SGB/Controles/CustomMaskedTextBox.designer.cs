namespace SGB.Controles
{
    partial class CustomMaskedTextBox
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
            this.Mbx_Pricipal = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.Mbx_Pricipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mbx_Pricipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mbx_Pricipal.Location = new System.Drawing.Point(7, 7);
            this.Mbx_Pricipal.Margin = new System.Windows.Forms.Padding(0);
            this.Mbx_Pricipal.Name = "textBox1";
            this.Mbx_Pricipal.Size = new System.Drawing.Size(236, 16);
            this.Mbx_Pricipal.TabIndex = 0;
            // 
            // CustomMaskedTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.Mbx_Pricipal);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomMaskedTextBox";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Mbx_Pricipal;
    }
}
