using ServiPlusApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller
{
    public class CBuscarServicio
    {
        public static DataTable Buscar_Servicio(string dato)
        {
            return DBuscarServicio.Buscar_Servicio(dato);
        }
    }
}
