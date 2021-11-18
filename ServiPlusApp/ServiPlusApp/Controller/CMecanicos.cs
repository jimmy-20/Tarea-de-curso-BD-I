using ServiPlusApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller
{
    public class CMecanicos
    {
        public static DataTable Mostrar_Mecanicos()
        {
            return DMecanicos.Mostrar_Mecanicos();
        }

        public static DataTable Buscar_Mecanico(string dato)
        {
            return DMecanicos.Buscar_Mecanico(dato);
        }
    }
}
