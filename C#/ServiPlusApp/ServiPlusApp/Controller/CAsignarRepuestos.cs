using Bunifu.UI.WinForms;
using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Model;
using ServiPlusApp.View.SetTables.Asignar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller
{
    class CAsignarRepuestos : IAcciones
    {
        BunifuDataGridView TablaMantenimientos;
        public CAsignarRepuestos(BunifuDataGridView TablaMantenimientos)
        {
            this.TablaMantenimientos = TablaMantenimientos;
        }
        public void Agregar()
        {
            Repuesto repuesto = new Repuesto();
            repuesto.ShowDialog();
        }

        public void Buscar(string text)
        {
            TablaMantenimientos.DataSource = DAsignarRepuestos.Buscar_Mantenimiento(text);
        }

        public void Cancelar()
        {
            throw new NotImplementedException();
        }

        public void Editar()
        {
            Repuesto repuesto = new Repuesto();
            repuesto.ShowDialog();
        }

        public void Estado()
        {
            Repuesto repuesto = new Repuesto();
            repuesto.ShowDialog();
        }

        public void Guardar()
        {
            throw new NotImplementedException();
        }

        public void Ver()
        {
            TablaMantenimientos.DataSource = DAsignarRepuestos.Tabla_Mantenimientos();
        }

        public static DataTable Mostrar_Mantenimientos_Servicios(int IdMantenimiento)
        {
            return DAsignarRepuestos.Mostrar_Mantenimientos_Servicios(IdMantenimiento);
        }

        public static DataTable Mostrar_Servicios_Repuestos(int IdDetMantenimiento)
        {
            return DAsignarRepuestos.Mostrar_Servicios_Repuestos(IdDetMantenimiento);
        }

        public static DataTable Asignar_Repuesto(int IdDetMantenimiento, int IdServicio, int cantidad)
        {
            return DAsignarRepuestos.Asignar_Repuesto(IdDetMantenimiento,IdServicio,cantidad);
        }
    }
}
