using ServiPlusApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller
{
    public class CServicios
    {

        public static DataTable Mostrar_Servicios()
        {
            return DServicios.Mostrar_Servicios();
        }
    }
}
