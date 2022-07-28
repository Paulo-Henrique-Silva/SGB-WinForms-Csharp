using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGB.Menu
{
    public partial class F_MenuPrincipal : Form
    {
        /// <summary>
        /// Retorna se o usuário deslogou da conta.
        /// </summary>
        public bool Deslogou { get; set; }

        private Form FormFilho = new Form();

        public F_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Btn_Marcas_Click(object sender, EventArgs e)
        {
            Pnl_SubMenuMarcas.Visible = !Pnl_SubMenuMarcas.Visible; //torna visível o submenu
        }

        private void Btn_User_Click(object sender, EventArgs e)
        {
            MudaFormFilho(new FormsFilhos.F_Conta(string.Empty));
        }

        private void Btn_Clientes_Click(object sender, EventArgs e)
        {
            MudaFormFilho(new FormsFilhos.F_Clientes(string.Empty));
        }

        private void Btn_Alugueis_Click(object sender, EventArgs e)
        {
            MudaFormFilho(new FormsFilhos.F_Alugueis(string.Empty));
        }

        private void Btn_Livros_Click(object sender, EventArgs e)
        {
            MudaFormFilho(new FormsFilhos.F_Livros(string.Empty));
        }

        private void Btn_Vendas_Click(object sender, EventArgs e)
        {
            MudaFormFilho(new FormsFilhos.F_Vendas(string.Empty));
        }

        private void Btn_Autores_Click(object sender, EventArgs e)
        {
            MudaFormFilho(new FormsFilhos.F_Autores(string.Empty));
        }

        private void Btn_Editoras_Click(object sender, EventArgs e)
        {
            MudaFormFilho(new FormsFilhos.F_Editoras(string.Empty));
        }

        private void Btn_Generos_Click(object sender, EventArgs e)
        {
            MudaFormFilho(new FormsFilhos.F_Generos(string.Empty));
        }

        private void Btn_Usuarios_Click(object sender, EventArgs e)
        {
            MudaFormFilho(new FormsFilhos.F_Usuarios(string.Empty));
        }

        private void Btn_Estatisticas_Click(object sender, EventArgs e)
        {
            MudaFormFilho(new FormsFilhos.F_Estatisticas(string.Empty));
        }

        private void Btn_Historico_Click(object sender, EventArgs e)
        {
            MudaFormFilho(new FormsFilhos.F_Historico(string.Empty));
        }

        /// <summary>
        /// Sai da conta autal e volta à tela de login. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja voltar à interface de login?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Deslogou = true;
                Close();
            }
        }

        /// <summary>
        /// Reduz o menu lateral com base no texto do botão.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Quebrar_Click(object sender, EventArgs e)
        {
            if (Btn_Quebrar.Text == "<")
            {
                Stc_Principal.SplitterDistance = Btn_Quebrar.Width;
                Stc_Lateral.Panel1Collapsed = true;
                Btn_Quebrar.Text = ">";
            }
            else if (Btn_Quebrar.Text == ">")
            {
                Stc_Principal.SplitterDistance = Btn_Quebrar.Width + 252;
                Stc_Lateral.Panel1Collapsed = false;
                Btn_Quebrar.Text = "<";
            }
        }

        private void MudaFormFilho(Form form)
        {
            if (FormFilho.GetType() != form.GetType())
            {
                FormFilho.Close();
                Stc_Principal.Panel2.Controls.Remove(FormFilho);

                form.Dock = DockStyle.Fill;
                form.TopLevel = false;

                Stc_Principal.Panel2.Controls.Add(form);
                form.Show();
                FormFilho = form;
            }
        }
    }
}
