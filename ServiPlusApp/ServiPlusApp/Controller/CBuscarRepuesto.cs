using ServiPlusApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller
{
    class CBuscarRepuesto
    {
        public static DataTable Buscar_Repuesto(string dato)
        {
            return DBuscarRepuesto.Buscar_Repuesto(dato);
        }

    }
}
