using ServiPlusApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller
{
    class CHistorial
    {
        public static DataTable Historial_Header(int IdVehiculo)
        {
            return DMantenimientos.Historial_Header(IdVehiculo);
        } 

        public static DataTable Historial_Mantenimientos(int IdVehiculo)
        {
            return DMantenimientos.Historial_Mantenimientos(IdVehiculo);
        }

        public static DataTable Historial_Mantenimientos_Servicios(int IdMantenimiento)
        {
            return DMantenimientos.Mostrar_Mantenimientos_Servicios(IdMantenimiento);
        }

        public static DataTable Historial_Mantenimiento_Repuestos(int IdDetalleMantenimiento)
        {
            return DMantenimientos.Mostrar_Mantenimientos_Servicios(IdDetalleMantenimiento);
        }
    }
}
