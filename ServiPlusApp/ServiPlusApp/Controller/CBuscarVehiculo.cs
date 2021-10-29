using ServiPlusApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller
{
    public class CBuscarVehiculo
    {
        public static DataTable Buscar_vehiculo(string dato)
        {
            return DBuscarVehiculo.Buscar_Vehiculo(dato);
        }
    }
}
