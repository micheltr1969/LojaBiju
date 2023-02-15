using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAPP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin fLogin = new frmLogin();
            DialogResult retorno = fLogin.ShowDialog();

            if (retorno == DialogResult.OK)
            {
                Application.Run(new frmPrincipal());
            }
            else
            {
                fLogin.Close();
            }

        }
    }
}
