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
    public partial class F_Sobre : Form
    {
        private F_Login formPai;

        public F_Sobre(F_Login form)
        {
            InitializeComponent();
            formPai = form;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            formPai.MudaFormFilho(new F_Entrar(formPai));
        }
    }
}
