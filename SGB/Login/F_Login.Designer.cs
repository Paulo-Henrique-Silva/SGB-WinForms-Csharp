namespace SGB.Login
{
    partial class F_Login
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Login));
            this.Pnl_Principal = new System.Windows.Forms.Panel();
            this.Llb_Criador = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Pnl_Principal
            // 
            this.Pnl_Principal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pnl_Principal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pnl_Principal.BackgroundImage")));
            this.Pnl_Principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pnl_Principal.Location = new System.Drawing.Point(383, 70);
            this.Pnl_Principal.Name = "Pnl_Principal";
            this.Pnl_Principal.Size = new System.Drawing.Size(570, 560);
            this.Pnl_Principal.TabIndex = 0;
            // 
            // Llb_Criador
            // 
            this.Llb_Criador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Llb_Criador.AutoSize = true;
            this.Llb_Criador.BackColor = System.Drawing.Color.Transparent;
            this.Llb_Criador.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llb_Criador.LinkArea = new System.Windows.Forms.LinkArea(12, 32);
            this.Llb_Criador.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Llb_Criador.Location = new System.Drawing.Point(549, 650);
            this.Llb_Criador.Name = "Llb_Criador";
            this.Llb_Criador.Size = new System.Drawing.Size(263, 27);
            this.Llb_Criador.TabIndex = 16;
            this.Llb_Criador.TabStop = true;
            this.Llb_Criador.Text = "Criado por: Paulo-Henrique-Silva";
            this.Llb_Criador.UseCompatibleTextRendering = true;
            this.Llb_Criador.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            // 
            // F_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1320, 689);
            this.Controls.Add(this.Llb_Criador);
            this.Controls.Add(this.Pnl_Principal);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Name = "F_Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Principal;
        private System.Windows.Forms.LinkLabel Llb_Criador;
    }
}

