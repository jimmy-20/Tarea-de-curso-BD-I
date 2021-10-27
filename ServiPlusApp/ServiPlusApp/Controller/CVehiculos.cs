using ServiPlusApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller
{
    public class CVehiculos
    {
        public static DataTable Table_Vehiculos()
        {
            return DMecanicos.Mostrar_Mecanicos();
        }
    }
}
