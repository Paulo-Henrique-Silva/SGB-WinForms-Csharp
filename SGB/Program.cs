using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGB
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login.F_Login login = new Login.F_Login();

            Application.Run(login);

            if (login.Logou)
                Application.Run(new MenuPrincipal.F_MenuPrincipal());
        }
    }
}
