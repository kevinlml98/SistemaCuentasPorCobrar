using BackOffice.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    static class Program
    {
        public static bool IsValid = false;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmInicio());
            if (IsValid )
            {
                Application.Run(new frmMenu());
            }
        }

    }
}
