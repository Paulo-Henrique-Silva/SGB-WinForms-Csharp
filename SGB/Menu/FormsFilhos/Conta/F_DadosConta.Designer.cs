namespace SGB.Menu.FormsFilhos.Conta
{
    partial class F_DadosConta
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
            this.Pnl_Principal = new System.Windows.Forms.Panel();
            this.Gbx_Dados = new System.Windows.Forms.GroupBox();
            this.Tlp_DadosConta = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_User = new System.Windows.Forms.Label();
            this.Lbl_Cpf = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_NomeSoc = new System.Windows.Forms.Label();
            this.Lbl_NomeGen = new System.Windows.Forms.Label();
            this.Lbl_Cargo = new System.Windows.Forms.Label();
            this.Lbl_DataCad = new System.Windows.Forms.Label();
            this.Lbl_DataAlt = new System.Windows.Forms.Label();
            this.Lbl_HeaderUser = new System.Windows.Forms.Label();
            this.Lbl_HeaderCpf = new System.Windows.Forms.Label();
            this.Lbl_HeaderNome = new System.Windows.Forms.Label();
            this.Lbl_HeaderNomeSoc = new System.Windows.Forms.Label();
            this.Lbl_HeaderGen = new System.Windows.Forms.Label();
            this.Lbl_HeaderCargo = new System.Windows.Forms.Label();
            this.Lbl_HeaderDataCad = new System.Windows.Forms.Label();
            this.Lbl_HeaderDataAlt = new System.Windows.Forms.Label();
            this.Btn_AlterarSenha = new SGB.Controles.CustomButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Pnl_Principal.SuspendLayout();
            this.Gbx_Dados.SuspendLayout();
            this.Tlp_DadosConta.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_Titulo.Location = new System.Drawing.Point(3, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(734, 42);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "NOME_CONTA (NUMERO USER)";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pnl_Principal
            // 
            this.Pnl_Principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Principal.BackColor = System.Drawing.Color.White;
            this.Pnl_Principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Principal.Controls.Add(this.tableLayoutPanel1);
            this.Pnl_Principal.Controls.Add(this.Gbx_Dados);
            this.Pnl_Principal.Location = new System.Drawing.Point(28, 31);
            this.Pnl_Principal.Name = "Pnl_Principal";
            this.Pnl_Principal.Size = new System.Drawing.Size(960, 627);
            this.Pnl_Principal.TabIndex = 1;
            // 
            // Gbx_Dados
            // 
            this.Gbx_Dados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gbx_Dados.Controls.Add(this.Tlp_DadosConta);
            this.Gbx_Dados.Location = new System.Drawing.Point(32, 98);
            this.Gbx_Dados.Name = "Gbx_Dados";
            this.Gbx_Dados.Size = new System.Drawing.Size(901, 501);
            this.Gbx_Dados.TabIndex = 16;
            this.Gbx_Dados.TabStop = false;
            this.Gbx_Dados.Text = "Dados gerais";
            // 
            // Tlp_DadosConta
            // 
            this.Tlp_DadosConta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tlp_DadosConta.ColumnCount = 2;
            this.Tlp_DadosConta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tlp_DadosConta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.Tlp_DadosConta.Controls.Add(this.Lbl_User, 1, 0);
            this.Tlp_DadosConta.Controls.Add(this.Lbl_Cpf, 1, 1);
            this.Tlp_DadosConta.Controls.Add(this.Lbl_Nome, 1, 2);
            this.Tlp_DadosConta.Controls.Add(this.Lbl_NomeSoc, 1, 3);
            this.Tlp_DadosConta.Controls.Add(this.Lbl_NomeGen, 1, 4);
            this.Tlp_DadosConta.Controls.Add(this.Lbl_Cargo, 1, 5);
            this.Tlp_DadosConta.Controls.Add(this.Lbl_DataCad, 1, 6);
            this.Tlp_DadosConta.Controls.Add(this.Lbl_DataAlt, 1, 7);
            this.Tlp_DadosConta.Controls.Add(this.Lbl_HeaderUser, 0, 0);
            this.Tlp_DadosConta.Controls.Add(this.Lbl_HeaderCpf, 0, 1);
            this.Tlp_DadosConta.Controls.Add(this.Lbl_HeaderNome, 0, 2);
            this.Tlp_DadosConta.Controls.Add(this.Lbl_HeaderNomeSoc, 0, 3);
            this.Tlp_DadosConta.Controls.Add(this.Lbl_HeaderGen, 0, 4);
            this.Tlp_DadosConta.Controls.Add(this.Lbl_HeaderCargo, 0, 5);
            this.Tlp_DadosConta.Controls.Add(this.Lbl_HeaderDataCad, 0, 6);
            this.Tlp_DadosConta.Controls.Add(this.Lbl_HeaderDataAlt, 0, 7);
            this.Tlp_DadosConta.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.Tlp_DadosConta.Location = new System.Drawing.Point(17, 50);
            this.Tlp_DadosConta.Name = "Tlp_DadosConta";
            this.Tlp_DadosConta.RowCount = 8;
            this.Tlp_DadosConta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Tlp_DadosConta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Tlp_DadosConta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Tlp_DadosConta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Tlp_DadosConta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Tlp_DadosConta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Tlp_DadosConta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Tlp_DadosConta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Tlp_DadosConta.Size = new System.Drawing.Size(867, 421);
            this.Tlp_DadosConta.TabIndex = 0;
            // 
            // Lbl_User
            // 
            this.Lbl_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Lbl_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_User.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_User.Location = new System.Drawing.Point(173, 0);
            this.Lbl_User.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_User.Name = "Lbl_User";
            this.Lbl_User.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Lbl_User.Size = new System.Drawing.Size(694, 52);
            this.Lbl_User.TabIndex = 9;
            this.Lbl_User.Text = "user";
            this.Lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Cpf
            // 
            this.Lbl_Cpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Lbl_Cpf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Cpf.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_Cpf.Location = new System.Drawing.Point(173, 52);
            this.Lbl_Cpf.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Cpf.Name = "Lbl_Cpf";
            this.Lbl_Cpf.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Lbl_Cpf.Size = new System.Drawing.Size(694, 52);
            this.Lbl_Cpf.TabIndex = 10;
            this.Lbl_Cpf.Text = "cpf";
            this.Lbl_Cpf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Lbl_Nome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Nome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_Nome.Location = new System.Drawing.Point(173, 104);
            this.Lbl_Nome.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Lbl_Nome.Size = new System.Drawing.Size(694, 52);
            this.Lbl_Nome.TabIndex = 11;
            this.Lbl_Nome.Text = "nome";
            this.Lbl_Nome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_NomeSoc
            // 
            this.Lbl_NomeSoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Lbl_NomeSoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_NomeSoc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeSoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_NomeSoc.Location = new System.Drawing.Point(173, 156);
            this.Lbl_NomeSoc.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_NomeSoc.Name = "Lbl_NomeSoc";
            this.Lbl_NomeSoc.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Lbl_NomeSoc.Size = new System.Drawing.Size(694, 52);
            this.Lbl_NomeSoc.TabIndex = 12;
            this.Lbl_NomeSoc.Text = "nome_social";
            this.Lbl_NomeSoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_NomeGen
            // 
            this.Lbl_NomeGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Lbl_NomeGen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_NomeGen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeGen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_NomeGen.Location = new System.Drawing.Point(173, 208);
            this.Lbl_NomeGen.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_NomeGen.Name = "Lbl_NomeGen";
            this.Lbl_NomeGen.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Lbl_NomeGen.Size = new System.Drawing.Size(694, 52);
            this.Lbl_NomeGen.TabIndex = 13;
            this.Lbl_NomeGen.Text = "genero";
            this.Lbl_NomeGen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Cargo
            // 
            this.Lbl_Cargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Lbl_Cargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Cargo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_Cargo.Location = new System.Drawing.Point(173, 260);
            this.Lbl_Cargo.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Cargo.Name = "Lbl_Cargo";
            this.Lbl_Cargo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Lbl_Cargo.Size = new System.Drawing.Size(694, 52);
            this.Lbl_Cargo.TabIndex = 14;
            this.Lbl_Cargo.Text = "cargo";
            this.Lbl_Cargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_DataCad
            // 
            this.Lbl_DataCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Lbl_DataCad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_DataCad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DataCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_DataCad.Location = new System.Drawing.Point(173, 312);
            this.Lbl_DataCad.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_DataCad.Name = "Lbl_DataCad";
            this.Lbl_DataCad.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Lbl_DataCad.Size = new System.Drawing.Size(694, 52);
            this.Lbl_DataCad.TabIndex = 15;
            this.Lbl_DataCad.Text = "data_cad";
            this.Lbl_DataCad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_DataAlt
            // 
            this.Lbl_DataAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Lbl_DataAlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_DataAlt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DataAlt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_DataAlt.Location = new System.Drawing.Point(173, 364);
            this.Lbl_DataAlt.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_DataAlt.Name = "Lbl_DataAlt";
            this.Lbl_DataAlt.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Lbl_DataAlt.Size = new System.Drawing.Size(694, 57);
            this.Lbl_DataAlt.TabIndex = 16;
            this.Lbl_DataAlt.Text = "data_alt";
            this.Lbl_DataAlt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_HeaderUser
            // 
            this.Lbl_HeaderUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Lbl_HeaderUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_HeaderUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HeaderUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_HeaderUser.Location = new System.Drawing.Point(0, 0);
            this.Lbl_HeaderUser.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_HeaderUser.Name = "Lbl_HeaderUser";
            this.Lbl_HeaderUser.Size = new System.Drawing.Size(173, 52);
            this.Lbl_HeaderUser.TabIndex = 1;
            this.Lbl_HeaderUser.Text = "Usuário";
            this.Lbl_HeaderUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_HeaderCpf
            // 
            this.Lbl_HeaderCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Lbl_HeaderCpf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_HeaderCpf.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HeaderCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_HeaderCpf.Location = new System.Drawing.Point(0, 52);
            this.Lbl_HeaderCpf.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_HeaderCpf.Name = "Lbl_HeaderCpf";
            this.Lbl_HeaderCpf.Size = new System.Drawing.Size(173, 52);
            this.Lbl_HeaderCpf.TabIndex = 2;
            this.Lbl_HeaderCpf.Text = "CPF";
            this.Lbl_HeaderCpf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_HeaderNome
            // 
            this.Lbl_HeaderNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Lbl_HeaderNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_HeaderNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HeaderNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_HeaderNome.Location = new System.Drawing.Point(0, 104);
            this.Lbl_HeaderNome.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_HeaderNome.Name = "Lbl_HeaderNome";
            this.Lbl_HeaderNome.Size = new System.Drawing.Size(173, 52);
            this.Lbl_HeaderNome.TabIndex = 3;
            this.Lbl_HeaderNome.Text = "Nome";
            this.Lbl_HeaderNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_HeaderNomeSoc
            // 
            this.Lbl_HeaderNomeSoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Lbl_HeaderNomeSoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_HeaderNomeSoc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HeaderNomeSoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_HeaderNomeSoc.Location = new System.Drawing.Point(0, 156);
            this.Lbl_HeaderNomeSoc.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_HeaderNomeSoc.Name = "Lbl_HeaderNomeSoc";
            this.Lbl_HeaderNomeSoc.Size = new System.Drawing.Size(173, 52);
            this.Lbl_HeaderNomeSoc.TabIndex = 4;
            this.Lbl_HeaderNomeSoc.Text = "Nome social";
            this.Lbl_HeaderNomeSoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_HeaderGen
            // 
            this.Lbl_HeaderGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Lbl_HeaderGen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_HeaderGen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HeaderGen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_HeaderGen.Location = new System.Drawing.Point(0, 208);
            this.Lbl_HeaderGen.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_HeaderGen.Name = "Lbl_HeaderGen";
            this.Lbl_HeaderGen.Size = new System.Drawing.Size(173, 52);
            this.Lbl_HeaderGen.TabIndex = 5;
            this.Lbl_HeaderGen.Text = "Gênero";
            this.Lbl_HeaderGen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_HeaderCargo
            // 
            this.Lbl_HeaderCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Lbl_HeaderCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_HeaderCargo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HeaderCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_HeaderCargo.Location = new System.Drawing.Point(0, 260);
            this.Lbl_HeaderCargo.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_HeaderCargo.Name = "Lbl_HeaderCargo";
            this.Lbl_HeaderCargo.Size = new System.Drawing.Size(173, 52);
            this.Lbl_HeaderCargo.TabIndex = 6;
            this.Lbl_HeaderCargo.Text = "Cargo";
            this.Lbl_HeaderCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_HeaderDataCad
            // 
            this.Lbl_HeaderDataCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Lbl_HeaderDataCad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_HeaderDataCad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HeaderDataCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_HeaderDataCad.Location = new System.Drawing.Point(0, 312);
            this.Lbl_HeaderDataCad.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_HeaderDataCad.Name = "Lbl_HeaderDataCad";
            this.Lbl_HeaderDataCad.Size = new System.Drawing.Size(173, 52);
            this.Lbl_HeaderDataCad.TabIndex = 7;
            this.Lbl_HeaderDataCad.Text = "Data de ingresso";
            this.Lbl_HeaderDataCad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_HeaderDataAlt
            // 
            this.Lbl_HeaderDataAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Lbl_HeaderDataAlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_HeaderDataAlt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HeaderDataAlt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Lbl_HeaderDataAlt.Location = new System.Drawing.Point(0, 364);
            this.Lbl_HeaderDataAlt.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_HeaderDataAlt.Name = "Lbl_HeaderDataAlt";
            this.Lbl_HeaderDataAlt.Size = new System.Drawing.Size(173, 57);
            this.Lbl_HeaderDataAlt.TabIndex = 8;
            this.Lbl_HeaderDataAlt.Text = "Modificado pela última vez";
            this.Lbl_HeaderDataAlt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_AlterarSenha
            // 
            this.Btn_AlterarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(159)))), ((int)(((byte)(61)))));
            this.Btn_AlterarSenha.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(159)))), ((int)(((byte)(61)))));
            this.Btn_AlterarSenha.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_AlterarSenha.BorderRadius = 5;
            this.Btn_AlterarSenha.BorderSize = 0;
            this.Btn_AlterarSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_AlterarSenha.FlatAppearance.BorderSize = 0;
            this.Btn_AlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AlterarSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AlterarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_AlterarSenha.Location = new System.Drawing.Point(743, 3);
            this.Btn_AlterarSenha.Name = "Btn_AlterarSenha";
            this.Btn_AlterarSenha.Size = new System.Drawing.Size(155, 36);
            this.Btn_AlterarSenha.TabIndex = 15;
            this.Btn_AlterarSenha.Text = "Alterar senha";
            this.Btn_AlterarSenha.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_AlterarSenha.UseVisualStyleBackColor = false;
            this.Btn_AlterarSenha.Click += new System.EventHandler(this.Btn_AlterarSenha_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.13097F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.86903F));
            this.tableLayoutPanel1.Controls.Add(this.Lbl_Titulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_AlterarSenha, 1, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 42);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // F_DadosConta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1016, 689);
            this.Controls.Add(this.Pnl_Principal);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_DadosConta";
            this.ShowIcon = false;
            this.Pnl_Principal.ResumeLayout(false);
            this.Gbx_Dados.ResumeLayout(false);
            this.Tlp_DadosConta.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Panel Pnl_Principal;
        private Controles.CustomButton Btn_AlterarSenha;
        private System.Windows.Forms.GroupBox Gbx_Dados;
        private System.Windows.Forms.TableLayoutPanel Tlp_DadosConta;
        private System.Windows.Forms.Label Lbl_HeaderUser;
        private System.Windows.Forms.Label Lbl_User;
        private System.Windows.Forms.Label Lbl_Cpf;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_NomeSoc;
        private System.Windows.Forms.Label Lbl_NomeGen;
        private System.Windows.Forms.Label Lbl_Cargo;
        private System.Windows.Forms.Label Lbl_DataCad;
        private System.Windows.Forms.Label Lbl_DataAlt;
        private System.Windows.Forms.Label Lbl_HeaderCpf;
        private System.Windows.Forms.Label Lbl_HeaderNome;
        private System.Windows.Forms.Label Lbl_HeaderNomeSoc;
        private System.Windows.Forms.Label Lbl_HeaderGen;
        private System.Windows.Forms.Label Lbl_HeaderCargo;
        private System.Windows.Forms.Label Lbl_HeaderDataCad;
        private System.Windows.Forms.Label Lbl_HeaderDataAlt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}