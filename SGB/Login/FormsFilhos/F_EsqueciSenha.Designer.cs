namespace SGB.Login.FormsFilhos
{
    partial class F_EsqueciSenha
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Tbx_Cpf = new SGB.Controles.CustomTextBox();
            this.Lbl_Cpf = new System.Windows.Forms.Label();
            this.Tbx_User = new SGB.Controles.CustomTextBox();
            this.Lbl_User = new System.Windows.Forms.Label();
            this.Tbx_NovaSenha = new SGB.Controles.CustomTextBox();
            this.Lbl_NovaSenha = new System.Windows.Forms.Label();
            this.Btn_Mudar = new SGB.Controles.CustomButton();
            this.Btn_Ver = new SGB.Controles.CustomButton();
            this.Llb_Voltar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_Titulo.Location = new System.Drawing.Point(104, 35);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(169, 30);
            this.Lbl_Titulo.TabIndex = 9;
            this.Lbl_Titulo.Text = "MUDAR SENHA";
            // 
            // Tbx_Cpf
            // 
            this.Tbx_Cpf.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Tbx_Cpf.BackColor = System.Drawing.SystemColors.Window;
            this.Tbx_Cpf.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Tbx_Cpf.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Tbx_Cpf.BorderRadius = 5;
            this.Tbx_Cpf.BorderSize = 3;
            this.Tbx_Cpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Cpf.Location = new System.Drawing.Point(101, 219);
            this.Tbx_Cpf.Margin = new System.Windows.Forms.Padding(4);
            this.Tbx_Cpf.MaxLength = 32767;
            this.Tbx_Cpf.Multiline = false;
            this.Tbx_Cpf.Name = "Tbx_Cpf";
            this.Tbx_Cpf.Padding = new System.Windows.Forms.Padding(10);
            this.Tbx_Cpf.PasswordChar = false;
            this.Tbx_Cpf.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Tbx_Cpf.PlaceholderText = "";
            this.Tbx_Cpf.ReadOnly = false;
            this.Tbx_Cpf.Size = new System.Drawing.Size(350, 42);
            this.Tbx_Cpf.TabIndex = 16;
            this.Tbx_Cpf.Texts = "";
            this.Tbx_Cpf.UnderlinedStyle = false;
            // 
            // Lbl_Cpf
            // 
            this.Lbl_Cpf.AutoSize = true;
            this.Lbl_Cpf.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Cpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_Cpf.Location = new System.Drawing.Point(97, 194);
            this.Lbl_Cpf.Name = "Lbl_Cpf";
            this.Lbl_Cpf.Size = new System.Drawing.Size(37, 21);
            this.Lbl_Cpf.TabIndex = 15;
            this.Lbl_Cpf.Text = "CPF";
            // 
            // Tbx_User
            // 
            this.Tbx_User.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Tbx_User.BackColor = System.Drawing.SystemColors.Window;
            this.Tbx_User.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Tbx_User.BorderFocusColor = System.Drawing.Color.Red;
            this.Tbx_User.BorderRadius = 5;
            this.Tbx_User.BorderSize = 3;
            this.Tbx_User.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_User.Location = new System.Drawing.Point(101, 126);
            this.Tbx_User.Margin = new System.Windows.Forms.Padding(4);
            this.Tbx_User.MaxLength = 7;
            this.Tbx_User.Multiline = false;
            this.Tbx_User.Name = "Tbx_User";
            this.Tbx_User.Padding = new System.Windows.Forms.Padding(10);
            this.Tbx_User.PasswordChar = false;
            this.Tbx_User.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Tbx_User.PlaceholderText = "";
            this.Tbx_User.ReadOnly = false;
            this.Tbx_User.Size = new System.Drawing.Size(350, 42);
            this.Tbx_User.TabIndex = 14;
            this.Tbx_User.Texts = "";
            this.Tbx_User.UnderlinedStyle = false;
            // 
            // Lbl_User
            // 
            this.Lbl_User.AutoSize = true;
            this.Lbl_User.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_User.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_User.Location = new System.Drawing.Point(97, 101);
            this.Lbl_User.Name = "Lbl_User";
            this.Lbl_User.Size = new System.Drawing.Size(64, 21);
            this.Lbl_User.TabIndex = 13;
            this.Lbl_User.Text = "Usuário";
            // 
            // Tbx_NovaSenha
            // 
            this.Tbx_NovaSenha.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Tbx_NovaSenha.BackColor = System.Drawing.SystemColors.Window;
            this.Tbx_NovaSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Tbx_NovaSenha.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Tbx_NovaSenha.BorderRadius = 5;
            this.Tbx_NovaSenha.BorderSize = 3;
            this.Tbx_NovaSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_NovaSenha.Location = new System.Drawing.Point(101, 416);
            this.Tbx_NovaSenha.Margin = new System.Windows.Forms.Padding(4);
            this.Tbx_NovaSenha.MaxLength = 32767;
            this.Tbx_NovaSenha.Multiline = false;
            this.Tbx_NovaSenha.Name = "Tbx_NovaSenha";
            this.Tbx_NovaSenha.Padding = new System.Windows.Forms.Padding(10);
            this.Tbx_NovaSenha.PasswordChar = false;
            this.Tbx_NovaSenha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Tbx_NovaSenha.PlaceholderText = "";
            this.Tbx_NovaSenha.ReadOnly = true;
            this.Tbx_NovaSenha.Size = new System.Drawing.Size(254, 42);
            this.Tbx_NovaSenha.TabIndex = 19;
            this.Tbx_NovaSenha.Texts = "";
            this.Tbx_NovaSenha.UnderlinedStyle = false;
            // 
            // Lbl_NovaSenha
            // 
            this.Lbl_NovaSenha.AutoSize = true;
            this.Lbl_NovaSenha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NovaSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_NovaSenha.Location = new System.Drawing.Point(97, 391);
            this.Lbl_NovaSenha.Name = "Lbl_NovaSenha";
            this.Lbl_NovaSenha.Size = new System.Drawing.Size(92, 21);
            this.Lbl_NovaSenha.TabIndex = 18;
            this.Lbl_NovaSenha.Text = "Nova senha";
            // 
            // Btn_Mudar
            // 
            this.Btn_Mudar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Mudar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Mudar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Mudar.BorderRadius = 5;
            this.Btn_Mudar.BorderSize = 0;
            this.Btn_Mudar.FlatAppearance.BorderSize = 0;
            this.Btn_Mudar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Mudar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mudar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Mudar.Location = new System.Drawing.Point(215, 305);
            this.Btn_Mudar.Name = "Btn_Mudar";
            this.Btn_Mudar.Size = new System.Drawing.Size(140, 42);
            this.Btn_Mudar.TabIndex = 21;
            this.Btn_Mudar.Text = "Mudar";
            this.Btn_Mudar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Mudar.UseVisualStyleBackColor = false;
            // 
            // Btn_Ver
            // 
            this.Btn_Ver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Ver.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Ver.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Ver.BorderRadius = 5;
            this.Btn_Ver.BorderSize = 0;
            this.Btn_Ver.FlatAppearance.BorderSize = 0;
            this.Btn_Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ver.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Ver.Location = new System.Drawing.Point(367, 416);
            this.Btn_Ver.Name = "Btn_Ver";
            this.Btn_Ver.Size = new System.Drawing.Size(84, 42);
            this.Btn_Ver.TabIndex = 22;
            this.Btn_Ver.Text = "Ver";
            this.Btn_Ver.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Ver.UseVisualStyleBackColor = false;
            // 
            // Llb_Voltar
            // 
            this.Llb_Voltar.AutoSize = true;
            this.Llb_Voltar.BackColor = System.Drawing.Color.Transparent;
            this.Llb_Voltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llb_Voltar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Llb_Voltar.Location = new System.Drawing.Point(259, 506);
            this.Llb_Voltar.Name = "Llb_Voltar";
            this.Llb_Voltar.Size = new System.Drawing.Size(51, 21);
            this.Llb_Voltar.TabIndex = 23;
            this.Llb_Voltar.TabStop = true;
            this.Llb_Voltar.Text = "Voltar";
            this.Llb_Voltar.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Llb_Voltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llb_Voltar_LinkClicked);
            // 
            // F_EsqueciSenha
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 560);
            this.Controls.Add(this.Llb_Voltar);
            this.Controls.Add(this.Btn_Ver);
            this.Controls.Add(this.Btn_Mudar);
            this.Controls.Add(this.Tbx_NovaSenha);
            this.Controls.Add(this.Lbl_NovaSenha);
            this.Controls.Add(this.Tbx_Cpf);
            this.Controls.Add(this.Lbl_Cpf);
            this.Controls.Add(this.Tbx_User);
            this.Controls.Add(this.Lbl_User);
            this.Controls.Add(this.Lbl_Titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "F_EsqueciSenha";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Entrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private Controles.CustomTextBox Tbx_Cpf;
        private System.Windows.Forms.Label Lbl_Cpf;
        private Controles.CustomTextBox Tbx_User;
        private System.Windows.Forms.Label Lbl_User;
        private Controles.CustomTextBox Tbx_NovaSenha;
        private System.Windows.Forms.Label Lbl_NovaSenha;
        private Controles.CustomButton Btn_Mudar;
        private Controles.CustomButton Btn_Ver;
        private System.Windows.Forms.LinkLabel Llb_Voltar;
    }
}