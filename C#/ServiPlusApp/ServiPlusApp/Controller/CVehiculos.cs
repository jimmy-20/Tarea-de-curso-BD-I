using Bunifu.UI.WinForms;
using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Model;
using ServiPlusApp.View.Agregar;
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
        private BunifuDataGridView TablaVehiculos;

        public CVehiculos(BunifuDataGridView TablaVehiculos)
        {
            this.TablaVehiculos = TablaVehiculos;
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
            TablaVehiculos.DataSource = DVehiculos.Mostrar_Vehiculos();
            TablaVehiculos.Columns[0].Visible = false;
            TablaVehiculos.Columns[1].Visible = false;
        }

        public void Agregar()
        {
            Vehiculos vehiculos = new Vehiculos("Nuevo");
            vehiculos.ShowDialog();
        }

        public void Editar()
        {
            Vehiculos vehiculos = new Vehiculos("Modificar");
            vehiculos.ShowDialog();
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
            TablaVehiculos.DataSource = DVehiculos.Buscar_Vehiculo(text);
            TablaVehiculos.Columns[0].Visible = false;
        }
    }
}
