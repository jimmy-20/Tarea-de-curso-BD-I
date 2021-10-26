using ServiPlusApp.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller
{
    public class CClientes
    {
        public static DataTable Table_Clientes()
        {
            return DClientes.Tabla_Clientes();
        }
    }
}
