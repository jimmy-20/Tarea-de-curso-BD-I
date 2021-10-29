using ServiPlusApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller
{
    public class CBuscarMantenimiento
    {
        public static DataTable Buscar_Mantenimiento(string dato)
        {
            return DBuscarMantenimiento.Buscar_Mantenimiento(dato);
        }
    }
}
