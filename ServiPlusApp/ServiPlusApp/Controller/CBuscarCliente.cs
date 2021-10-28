using ServiPlusApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller
{
    public class CBuscarCliente
    {
        public static DataTable Buscar_Cliente(string dato)
        {
            return DBuscarCliente.Buscar_Usuario(dato);
        }  
    }
}
