namespace SGB.Controles
{
    partial class CustomGroupBox
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
            this.Pnl_Right = new System.Windows.Forms.Panel();
            this.Pnl_Bot = new System.Windows.Forms.Panel();
            this.Pnl_Left = new System.Windows.Forms.Panel();
            this.Pnl_Top = new System.Windows.Forms.Panel();
            this.Lbl_Principal = new System.Windows.Forms.Label();
            this.Pnl_BackGround = new System.Windows.Forms.Panel();
            this.Pnl_BackGround.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Right
            // 
            this.Pnl_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_Right.Location = new System.Drawing.Point(220, 0);
            this.Pnl_Right.Name = "Pnl_Right";
            this.Pnl_Right.Size = new System.Drawing.Size(1, 149);
            this.Pnl_Right.TabIndex = 0;
            // 
            // Pnl_Bot
            // 
            this.Pnl_Bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Bot.Location = new System.Drawing.Point(1, 148);
            this.Pnl_Bot.Name = "Pnl_Bot";
            this.Pnl_Bot.Size = new System.Drawing.Size(219, 1);
            this.Pnl_Bot.TabIndex = 1;
            // 
            // Pnl_Left
            // 
            this.Pnl_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_Left.Location = new System.Drawing.Point(0, 1);
            this.Pnl_Left.Name = "Pnl_Left";
            this.Pnl_Left.Size = new System.Drawing.Size(1, 148);
            this.Pnl_Left.TabIndex = 2;
            // 
            // Pnl_Top
            // 
            this.Pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Top.Name = "Pnl_Top";
            this.Pnl_Top.Size = new System.Drawing.Size(220, 1);
            this.Pnl_Top.TabIndex = 3;
            // 
            // Lbl_Principal
            // 
            this.Lbl_Principal.AutoSize = true;
            this.Lbl_Principal.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_Principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Principal.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Principal.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Principal.Name = "Lbl_Principal";
            this.Lbl_Principal.Size = new System.Drawing.Size(110, 16);
            this.Lbl_Principal.TabIndex = 4;
            this.Lbl_Principal.Text = "customGroupBox";
            // 
            // Pnl_BackGround
            // 
            this.Pnl_BackGround.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_BackGround.Controls.Add(this.Pnl_Bot);
            this.Pnl_BackGround.Controls.Add(this.Pnl_Left);
            this.Pnl_BackGround.Controls.Add(this.Pnl_Top);
            this.Pnl_BackGround.Controls.Add(this.Pnl_Right);
            this.Pnl_BackGround.Location = new System.Drawing.Point(0, 3);
            this.Pnl_BackGround.Name = "Pnl_BackGround";
            this.Pnl_BackGround.Size = new System.Drawing.Size(221, 149);
            this.Pnl_BackGround.TabIndex = 5;
            // 
            // CustomGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbl_Principal);
            this.Controls.Add(this.Pnl_BackGround);
            this.Name = "CustomGroupBox";
            this.Size = new System.Drawing.Size(221, 152);
            this.Pnl_BackGround.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Right;
        private System.Windows.Forms.Panel Pnl_Bot;
        private System.Windows.Forms.Panel Pnl_Left;
        private System.Windows.Forms.Panel Pnl_Top;
        private System.Windows.Forms.Label Lbl_Principal;
        private System.Windows.Forms.Panel Pnl_BackGround;
    }
}
