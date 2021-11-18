using ServiPlusApp.View.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiPlusApp.View
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Operaciones("Massiel Fonseca","Massiel","Admin"));
            //Application.Run(new TablaUsuarios());
            //Application.Run(new SplashScreen());
            Application.Run(new Welcome("Massiel Fonseca","Massiel","ADMIN"));
        }
    }
}
