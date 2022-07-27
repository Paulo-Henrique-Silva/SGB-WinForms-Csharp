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

        public F_MenuPrincipal()
        {
            InitializeComponent();
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
                Stc_Principal.SplitterDistance = Btn_Quebrar.Width + Pbx_Logo.Width;
                Stc_Lateral.Panel1Collapsed = false;
                Btn_Quebrar.Text = "<";
            }
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
    }
}
