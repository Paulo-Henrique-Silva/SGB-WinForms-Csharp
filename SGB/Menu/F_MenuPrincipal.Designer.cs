namespace SGB.Menu
{
    partial class F_MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_MenuPrincipal));
            this.Stc_Principal = new System.Windows.Forms.SplitContainer();
            this.Stc_Lateral = new System.Windows.Forms.SplitContainer();
            this.Pnl_SubMenuMarcas = new System.Windows.Forms.Panel();
            this.Pbx_Logo = new System.Windows.Forms.PictureBox();
            this.Btn_Sair = new SGB.Controles.CustomButton();
            this.Btn_Historico = new SGB.Controles.CustomButton();
            this.Btn_Estatisticas = new SGB.Controles.CustomButton();
            this.Btn_Usuarios = new SGB.Controles.CustomButton();
            this.Btn_Generos = new SGB.Controles.CustomButton();
            this.Btn_Editoras = new SGB.Controles.CustomButton();
            this.Btn_Autores = new SGB.Controles.CustomButton();
            this.Btn_Marcas = new SGB.Controles.CustomButton();
            this.Btn_Clientes = new SGB.Controles.CustomButton();
            this.Btn_Livros = new SGB.Controles.CustomButton();
            this.Btn_Alugueis = new SGB.Controles.CustomButton();
            this.Btn_Vendas = new SGB.Controles.CustomButton();
            this.Btn_User = new SGB.Controles.CustomButton();
            this.Btn_Quebrar = new SGB.Controles.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.Stc_Principal)).BeginInit();
            this.Stc_Principal.Panel1.SuspendLayout();
            this.Stc_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stc_Lateral)).BeginInit();
            this.Stc_Lateral.Panel1.SuspendLayout();
            this.Stc_Lateral.Panel2.SuspendLayout();
            this.Stc_Lateral.SuspendLayout();
            this.Pnl_SubMenuMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Stc_Principal
            // 
            this.Stc_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stc_Principal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.Stc_Principal.IsSplitterFixed = true;
            this.Stc_Principal.Location = new System.Drawing.Point(0, 0);
            this.Stc_Principal.Name = "Stc_Principal";
            // 
            // Stc_Principal.Panel1
            // 
            this.Stc_Principal.Panel1.Controls.Add(this.Stc_Lateral);
            this.Stc_Principal.Size = new System.Drawing.Size(1320, 689);
            this.Stc_Principal.SplitterDistance = 300;
            this.Stc_Principal.TabIndex = 0;
            // 
            // Stc_Lateral
            // 
            this.Stc_Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Stc_Lateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stc_Lateral.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.Stc_Lateral.IsSplitterFixed = true;
            this.Stc_Lateral.Location = new System.Drawing.Point(0, 0);
            this.Stc_Lateral.Name = "Stc_Lateral";
            // 
            // Stc_Lateral.Panel1
            // 
            this.Stc_Lateral.Panel1.AutoScroll = true;
            this.Stc_Lateral.Panel1.Controls.Add(this.Btn_Sair);
            this.Stc_Lateral.Panel1.Controls.Add(this.Btn_Historico);
            this.Stc_Lateral.Panel1.Controls.Add(this.Btn_Estatisticas);
            this.Stc_Lateral.Panel1.Controls.Add(this.Btn_Usuarios);
            this.Stc_Lateral.Panel1.Controls.Add(this.Pnl_SubMenuMarcas);
            this.Stc_Lateral.Panel1.Controls.Add(this.Btn_Marcas);
            this.Stc_Lateral.Panel1.Controls.Add(this.Btn_Clientes);
            this.Stc_Lateral.Panel1.Controls.Add(this.Btn_Livros);
            this.Stc_Lateral.Panel1.Controls.Add(this.Btn_Alugueis);
            this.Stc_Lateral.Panel1.Controls.Add(this.Btn_Vendas);
            this.Stc_Lateral.Panel1.Controls.Add(this.Btn_User);
            this.Stc_Lateral.Panel1.Controls.Add(this.Pbx_Logo);
            // 
            // Stc_Lateral.Panel2
            // 
            this.Stc_Lateral.Panel2.Controls.Add(this.Btn_Quebrar);
            this.Stc_Lateral.Size = new System.Drawing.Size(300, 689);
            this.Stc_Lateral.SplitterDistance = 269;
            this.Stc_Lateral.TabIndex = 0;
            // 
            // Pnl_SubMenuMarcas
            // 
            this.Pnl_SubMenuMarcas.Controls.Add(this.Btn_Generos);
            this.Pnl_SubMenuMarcas.Controls.Add(this.Btn_Editoras);
            this.Pnl_SubMenuMarcas.Controls.Add(this.Btn_Autores);
            this.Pnl_SubMenuMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_SubMenuMarcas.Location = new System.Drawing.Point(0, 400);
            this.Pnl_SubMenuMarcas.Name = "Pnl_SubMenuMarcas";
            this.Pnl_SubMenuMarcas.Size = new System.Drawing.Size(252, 150);
            this.Pnl_SubMenuMarcas.TabIndex = 0;
            this.Pnl_SubMenuMarcas.Visible = false;
            // 
            // Pbx_Logo
            // 
            this.Pbx_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pbx_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Pbx_Logo.Image")));
            this.Pbx_Logo.Location = new System.Drawing.Point(0, 0);
            this.Pbx_Logo.Name = "Pbx_Logo";
            this.Pbx_Logo.Size = new System.Drawing.Size(252, 100);
            this.Pbx_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pbx_Logo.TabIndex = 0;
            this.Pbx_Logo.TabStop = false;
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Sair.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Sair.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Sair.BorderRadius = 0;
            this.Btn_Sair.BorderSize = 0;
            this.Btn_Sair.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Sair.FlatAppearance.BorderSize = 0;
            this.Btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sair.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.Btn_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sair.Location = new System.Drawing.Point(0, 700);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Sair.Size = new System.Drawing.Size(252, 50);
            this.Btn_Sair.TabIndex = 29;
            this.Btn_Sair.Text = "SAIR";
            this.Btn_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sair.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.Btn_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_Historico
            // 
            this.Btn_Historico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Historico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Historico.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Historico.BorderRadius = 0;
            this.Btn_Historico.BorderSize = 0;
            this.Btn_Historico.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Historico.FlatAppearance.BorderSize = 0;
            this.Btn_Historico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Historico.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Historico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Historico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Historico.Location = new System.Drawing.Point(0, 650);
            this.Btn_Historico.Name = "Btn_Historico";
            this.Btn_Historico.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Historico.Size = new System.Drawing.Size(252, 50);
            this.Btn_Historico.TabIndex = 28;
            this.Btn_Historico.Text = "HISTÓRICO";
            this.Btn_Historico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Historico.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Historico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Historico.UseVisualStyleBackColor = false;
            // 
            // Btn_Estatisticas
            // 
            this.Btn_Estatisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Estatisticas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Estatisticas.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Estatisticas.BorderRadius = 0;
            this.Btn_Estatisticas.BorderSize = 0;
            this.Btn_Estatisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Estatisticas.FlatAppearance.BorderSize = 0;
            this.Btn_Estatisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Estatisticas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Estatisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Estatisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Estatisticas.Location = new System.Drawing.Point(0, 600);
            this.Btn_Estatisticas.Name = "Btn_Estatisticas";
            this.Btn_Estatisticas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Estatisticas.Size = new System.Drawing.Size(252, 50);
            this.Btn_Estatisticas.TabIndex = 27;
            this.Btn_Estatisticas.Text = "ESTATÍSTICAS";
            this.Btn_Estatisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Estatisticas.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Estatisticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Estatisticas.UseVisualStyleBackColor = false;
            // 
            // Btn_Usuarios
            // 
            this.Btn_Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Usuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Usuarios.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Usuarios.BorderRadius = 0;
            this.Btn_Usuarios.BorderSize = 0;
            this.Btn_Usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Usuarios.FlatAppearance.BorderSize = 0;
            this.Btn_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Usuarios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Usuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Usuarios.Location = new System.Drawing.Point(0, 550);
            this.Btn_Usuarios.Name = "Btn_Usuarios";
            this.Btn_Usuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Usuarios.Size = new System.Drawing.Size(252, 50);
            this.Btn_Usuarios.TabIndex = 26;
            this.Btn_Usuarios.Text = "USUÁRIOS";
            this.Btn_Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Usuarios.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Usuarios.UseVisualStyleBackColor = false;
            // 
            // Btn_Generos
            // 
            this.Btn_Generos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Generos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Generos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Generos.BorderRadius = 0;
            this.Btn_Generos.BorderSize = 1;
            this.Btn_Generos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Generos.FlatAppearance.BorderSize = 0;
            this.Btn_Generos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Generos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Generos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Generos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Generos.Location = new System.Drawing.Point(0, 100);
            this.Btn_Generos.Name = "Btn_Generos";
            this.Btn_Generos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Btn_Generos.Size = new System.Drawing.Size(252, 50);
            this.Btn_Generos.TabIndex = 24;
            this.Btn_Generos.Text = "GÊNEROS LITERÁRIOS";
            this.Btn_Generos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Generos.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Generos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Generos.UseVisualStyleBackColor = false;
            // 
            // Btn_Editoras
            // 
            this.Btn_Editoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Editoras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Editoras.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Editoras.BorderRadius = 0;
            this.Btn_Editoras.BorderSize = 1;
            this.Btn_Editoras.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Editoras.FlatAppearance.BorderSize = 0;
            this.Btn_Editoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editoras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Editoras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Editoras.Location = new System.Drawing.Point(0, 50);
            this.Btn_Editoras.Name = "Btn_Editoras";
            this.Btn_Editoras.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Btn_Editoras.Size = new System.Drawing.Size(252, 50);
            this.Btn_Editoras.TabIndex = 23;
            this.Btn_Editoras.Text = "EDITORAS";
            this.Btn_Editoras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Editoras.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Editoras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Editoras.UseVisualStyleBackColor = false;
            // 
            // Btn_Autores
            // 
            this.Btn_Autores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Autores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Autores.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Autores.BorderRadius = 0;
            this.Btn_Autores.BorderSize = 1;
            this.Btn_Autores.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Autores.FlatAppearance.BorderSize = 0;
            this.Btn_Autores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Autores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Autores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Autores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Autores.Location = new System.Drawing.Point(0, 0);
            this.Btn_Autores.Name = "Btn_Autores";
            this.Btn_Autores.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Btn_Autores.Size = new System.Drawing.Size(252, 50);
            this.Btn_Autores.TabIndex = 22;
            this.Btn_Autores.Text = "AUTORES";
            this.Btn_Autores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Autores.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Autores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Autores.UseVisualStyleBackColor = false;
            // 
            // Btn_Marcas
            // 
            this.Btn_Marcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Marcas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Marcas.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Marcas.BorderRadius = 0;
            this.Btn_Marcas.BorderSize = 0;
            this.Btn_Marcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Marcas.FlatAppearance.BorderSize = 0;
            this.Btn_Marcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Marcas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Marcas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Marcas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Marcas.Location = new System.Drawing.Point(0, 350);
            this.Btn_Marcas.Name = "Btn_Marcas";
            this.Btn_Marcas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Marcas.Size = new System.Drawing.Size(252, 50);
            this.Btn_Marcas.TabIndex = 21;
            this.Btn_Marcas.Text = "MARCAS LITERÁRIAS";
            this.Btn_Marcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Marcas.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Marcas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Marcas.UseVisualStyleBackColor = false;
            // 
            // Btn_Clientes
            // 
            this.Btn_Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Clientes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Clientes.BorderRadius = 0;
            this.Btn_Clientes.BorderSize = 0;
            this.Btn_Clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Clientes.FlatAppearance.BorderSize = 0;
            this.Btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clientes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Clientes.Location = new System.Drawing.Point(0, 300);
            this.Btn_Clientes.Name = "Btn_Clientes";
            this.Btn_Clientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Clientes.Size = new System.Drawing.Size(252, 50);
            this.Btn_Clientes.TabIndex = 20;
            this.Btn_Clientes.Text = "CLIENTES";
            this.Btn_Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Clientes.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Clientes.UseVisualStyleBackColor = false;
            // 
            // Btn_Livros
            // 
            this.Btn_Livros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Livros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Livros.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Livros.BorderRadius = 0;
            this.Btn_Livros.BorderSize = 0;
            this.Btn_Livros.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Livros.FlatAppearance.BorderSize = 0;
            this.Btn_Livros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Livros.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Livros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Livros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Livros.Location = new System.Drawing.Point(0, 250);
            this.Btn_Livros.Name = "Btn_Livros";
            this.Btn_Livros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Livros.Size = new System.Drawing.Size(252, 50);
            this.Btn_Livros.TabIndex = 19;
            this.Btn_Livros.Text = "LIVROS";
            this.Btn_Livros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Livros.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Livros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Livros.UseVisualStyleBackColor = false;
            // 
            // Btn_Alugueis
            // 
            this.Btn_Alugueis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Alugueis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Alugueis.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Alugueis.BorderRadius = 0;
            this.Btn_Alugueis.BorderSize = 0;
            this.Btn_Alugueis.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Alugueis.FlatAppearance.BorderSize = 0;
            this.Btn_Alugueis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Alugueis.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Alugueis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Alugueis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Alugueis.Location = new System.Drawing.Point(0, 200);
            this.Btn_Alugueis.Name = "Btn_Alugueis";
            this.Btn_Alugueis.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Alugueis.Size = new System.Drawing.Size(252, 50);
            this.Btn_Alugueis.TabIndex = 18;
            this.Btn_Alugueis.Text = "ALUGUÉIS";
            this.Btn_Alugueis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Alugueis.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Alugueis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Alugueis.UseVisualStyleBackColor = false;
            // 
            // Btn_Vendas
            // 
            this.Btn_Vendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Vendas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_Vendas.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Vendas.BorderRadius = 0;
            this.Btn_Vendas.BorderSize = 0;
            this.Btn_Vendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Vendas.FlatAppearance.BorderSize = 0;
            this.Btn_Vendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Vendas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Vendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Vendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Vendas.Location = new System.Drawing.Point(0, 150);
            this.Btn_Vendas.Name = "Btn_Vendas";
            this.Btn_Vendas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Vendas.Size = new System.Drawing.Size(252, 50);
            this.Btn_Vendas.TabIndex = 17;
            this.Btn_Vendas.Text = "VENDAS";
            this.Btn_Vendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Vendas.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Vendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Vendas.UseVisualStyleBackColor = false;
            // 
            // Btn_User
            // 
            this.Btn_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_User.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.Btn_User.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_User.BorderRadius = 0;
            this.Btn_User.BorderSize = 0;
            this.Btn_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_User.FlatAppearance.BorderSize = 0;
            this.Btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_User.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_User.Image = ((System.Drawing.Image)(resources.GetObject("Btn_User.Image")));
            this.Btn_User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_User.Location = new System.Drawing.Point(0, 100);
            this.Btn_User.Name = "Btn_User";
            this.Btn_User.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_User.Size = new System.Drawing.Size(252, 50);
            this.Btn_User.TabIndex = 16;
            this.Btn_User.Text = "NOME_USER";
            this.Btn_User.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_User.UseVisualStyleBackColor = false;
            // 
            // Btn_Quebrar
            // 
            this.Btn_Quebrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.Btn_Quebrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.Btn_Quebrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Quebrar.BorderRadius = 0;
            this.Btn_Quebrar.BorderSize = 0;
            this.Btn_Quebrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Quebrar.FlatAppearance.BorderSize = 0;
            this.Btn_Quebrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Quebrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Quebrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Quebrar.Location = new System.Drawing.Point(0, 0);
            this.Btn_Quebrar.Name = "Btn_Quebrar";
            this.Btn_Quebrar.Size = new System.Drawing.Size(27, 689);
            this.Btn_Quebrar.TabIndex = 15;
            this.Btn_Quebrar.Text = "<";
            this.Btn_Quebrar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Btn_Quebrar.UseVisualStyleBackColor = false;
            this.Btn_Quebrar.Click += new System.EventHandler(this.Btn_Quebrar_Click);
            // 
            // F_MenuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1320, 689);
            this.Controls.Add(this.Stc_Principal);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Name = "F_MenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Stc_Principal.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Stc_Principal)).EndInit();
            this.Stc_Principal.ResumeLayout(false);
            this.Stc_Lateral.Panel1.ResumeLayout(false);
            this.Stc_Lateral.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Stc_Lateral)).EndInit();
            this.Stc_Lateral.ResumeLayout(false);
            this.Pnl_SubMenuMarcas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Stc_Principal;
        private System.Windows.Forms.SplitContainer Stc_Lateral;
        private System.Windows.Forms.PictureBox Pbx_Logo;
        private Controles.CustomButton Btn_Quebrar;
        private Controles.CustomButton Btn_Vendas;
        private Controles.CustomButton Btn_User;
        private Controles.CustomButton Btn_Marcas;
        private Controles.CustomButton Btn_Clientes;
        private Controles.CustomButton Btn_Livros;
        private Controles.CustomButton Btn_Alugueis;
        private Controles.CustomButton Btn_Sair;
        private Controles.CustomButton Btn_Historico;
        private Controles.CustomButton Btn_Estatisticas;
        private Controles.CustomButton Btn_Usuarios;
        private System.Windows.Forms.Panel Pnl_SubMenuMarcas;
        private Controles.CustomButton Btn_Generos;
        private Controles.CustomButton Btn_Editoras;
        private Controles.CustomButton Btn_Autores;
    }
}