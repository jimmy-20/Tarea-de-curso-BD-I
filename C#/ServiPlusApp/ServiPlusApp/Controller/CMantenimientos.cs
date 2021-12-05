using Bunifu.UI.WinForms;
using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Model;
using ServiPlusApp.View.Mantenimientos;
using ServiPlusApp.View.Tablas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller
{
    public class CMantenimientos : IAcciones
    {
       BunifuDataGridView TablaMantenimientos;
        public CMantenimientos(BunifuDataGridView TablaMantenimientos)
        {
            this.TablaMantenimientos = TablaMantenimientos;
        }


        public void Ver()
        {
            TablaMantenimientos.DataSource = DMantenimientos.Mostrar_Mantenimientos();
            TablaMantenimientos.Columns[0].Visible = false;
        }

        public void Agregar()
        {
            Mantenimiento mantenimiento = new Mantenimiento("Nuevo");
            mantenimiento.ShowDialog();
        }

        public void Editar()
        {
            Mantenimiento mantenimiento = new Mantenimiento("Modificar");
            mantenimiento.ShowDialog();
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
            TablaMantenimientos.DataSource = DMantenimientos.Buscar_Mantenimiento(text);
        }
    }
}
