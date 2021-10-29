using ServiPlusApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller
{
    public class CBuscarMecanico
    {
        public static DataTable Buscar_Mecanico(string dato)
        {
            return DBuscarMecanico.Buscar_Mecanico(dato);
        }
    }
}
