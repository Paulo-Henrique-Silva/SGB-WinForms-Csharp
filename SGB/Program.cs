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

            Login.F_Login login;
            Menu.F_MenuPrincipal menu;

            //Ciclo que permite que e o usuário deslogue e logue do software.
            do
            {
                Application.Run(login = new Login.F_Login());

                menu = new Menu.F_MenuPrincipal();

                if (login.Logou)
                    Application.Run(menu);
            }
            while (menu.Deslogou);
        }
    }
}
