using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGB.Login.FormsFilhos
{
    public partial class F_EsqueciSenha : Form
    {
        private F_Login formPai;

        public F_EsqueciSenha(F_Login form)
        {
            InitializeComponent();
            formPai = form;
        }

        private void Llb_Voltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formPai.MudaFormFilho(new F_Entrar(formPai));
        }
    }
}
