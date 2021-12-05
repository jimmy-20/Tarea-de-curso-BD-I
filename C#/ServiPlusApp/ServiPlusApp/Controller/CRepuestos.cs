using Bunifu.UI.WinForms;
using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Model;
using ServiPlusApp.View.Set_Tables.Repuestos;
using ServiPlusApp.View.Tablas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller
{
    public class CRepuestos : IAcciones 
    {
        private BunifuDataGridView TablaRepuestos;

        public CRepuestos(BunifuDataGridView TablaRepuestos)
        {
            this.TablaRepuestos = TablaRepuestos;
        }

        public void Ver()
        {
            TablaRepuestos.DataSource = DRepuestos.Mostrar_Repuestos();
            TablaRepuestos.Columns[0].Visible = false;
        }

        public void Agregar()
        {
            Repuesto repuesto = new Repuesto("Nuevo");
            repuesto.ShowDialog();
        }

        public void Editar()
        {
            Repuesto repuesto = new Repuesto("Modificar");
            repuesto.ShowDialog();
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
            TablaRepuestos.DataSource = DRepuestos.Buscar_Repuesto(text);
        }

        public static DataTable Table_Repuestos()
        {
            return DRepuestos.Mostrar_Repuestos();
        }
    }
}
