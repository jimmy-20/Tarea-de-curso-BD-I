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
    public class CMantenimientos : IAcciones
    {
        ShowTable FrmMantenimiento;
        public CMantenimientos(ShowTable Formulario)
        {
            this.FrmMantenimiento = Formulario;
        }


        public void Ver()
        {
            FrmMantenimiento.DgvTablas.DataSource = DMantenimientos.Mostrar_Mantenimientos();
          //  FrmMantenimiento.DgvTablas.Columns[0].Visible = false;
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
            FrmMantenimiento.DgvTablas.DataSource = DMantenimientos.Buscar_Mantenimiento(text);
        }
    }
}
