using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGB.Menu.FormsFilhos.Conta
{
    public partial class F_DadosConta : Form
    {
        private readonly F_MenuPrincipal FormPai;

        public F_DadosConta(F_MenuPrincipal form)
        {
            InitializeComponent();
            FormPai = form; 
        }

        private void Btn_AlterarSenha_Click(object sender, EventArgs e)
        {
            FormPai.MudaFormFilho(new F_AlterarSenha(FormPai));
        }
    }
}
