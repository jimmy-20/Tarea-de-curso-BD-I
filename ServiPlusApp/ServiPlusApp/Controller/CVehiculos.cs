using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Model;
using ServiPlusApp.View.Tablas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller
{
    public class CVehiculos : IAcciones 
    {
        private MostrarTabla FrmVehiculo;

        public CVehiculos(MostrarTabla FrmVehiculo)
        {
            this.FrmVehiculo = FrmVehiculo;
        }
        public static DataTable Mostrar_Vehiculos()
        {
            return DVehiculos.Mostrar_Vehiculos();
        }

        public static DataTable Buscar_vehiculo(string dato)
        {
            return DVehiculos.Buscar_Vehiculo(dato);
        }

        public void Ver()
        {
            FrmVehiculo.DgvTablas.DataSource = DVehiculos.Mostrar_Vehiculos();
            FrmVehiculo.DgvTablas.Columns[0].Visible = false;
            FrmVehiculo.DgvTablas.Columns[1].Visible = false;
        }

        public void Agregar()
        {
            throw new NotImplementedException();
        }

        public void Editar()
        {
            throw new NotImplementedException();
        }

        public void Estado()
        {
            throw new NotImplementedException();
        }

        public void Guardar()
        {
            throw new NotImplementedException();
        }

        public void Cancelar()
        {
            throw new NotImplementedException();
        }

        public void Buscar(string text)
        {
            throw new NotImplementedException();
        }
    }
}
