using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGB.Login
{
    public partial class F_Login : Form
    {
        /// <summary>
        /// Forma filho atual do formulário.
        /// </summary>
        private Form FormFilho = new Form();

        public F_Login()
        {
            InitializeComponent();
            MudaFormFilho(new FormsFilhos.F_Entrar());
        }

        /// <summary>
        /// Troca o form filho (tela) do fomulário de login.
        /// </summary>
        /// <param name="form"></param>
        private void MudaFormFilho(Form form)
        {
            FormFilho.Close();
            panel1.Controls.Remove(FormFilho);

            form.Dock = DockStyle.Fill;
            form.TopLevel = false;

            panel1.Controls.Add(form);
            form.Show();
            FormFilho = form;
        }
    }
}
