using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGB.Menu.FormsFilhos
{
    public partial class F_Editoras : Form
    {
        private readonly string usuario;

        public F_Editoras(string user)
        {
            InitializeComponent();
            usuario = user;
        }
    }
}
