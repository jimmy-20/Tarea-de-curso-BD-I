using ServiPlusApp.View.Set_Tables.Mecanicos;
using ServiPlusApp.View.Set_Tables.Repuestos;
using ServiPlusApp.View.Set_Tables.Servicios;
using ServiPlusApp.View.Set_Tables.Usuarios;
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

            //Application.Run(new SplashScreen());
            //Application.Run(new Login());
            //Application.Run(new Welcome("Massiel Fonseca", "Massiel", "ADMIN", "SISTEMAS"));
            //Application.Run(new Operaciones("Leonardo Antonio Duarte Rodríguez", "leoduartejr", "Admin", "Sistemas"));
         
            Application.Run(new Repuesto());
        }
    }
}
