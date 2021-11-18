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
        public static DataTable Mostrar_Vehiculos()
        {
            return DVehiculos.Mostrar_Vehiculos();
        }

        public static DataTable Buscar_vehiculo(string dato)
        {
            return DVehiculos.Buscar_Vehiculo(dato);
        }
    }
}
