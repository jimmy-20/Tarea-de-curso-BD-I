using Bunifu.UI.WinForms;
using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Model;
using ServiPlusApp.View.Set_Tables.Servicios;
using ServiPlusApp.View.Tablas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiPlusApp.Controller
{
    public class CServicios : IAcciones 
    {
        private BunifuDataGridView TablaServicios;
        public CServicios(BunifuDataGridView TablaServicios)
        {
            this.TablaServicios = TablaServicios;
        }

        public static DataTable Mostrar_Servicios()
        {
            return DServicios.Mostrar_Servicios();
        }

        public static DataTable Buscar_Servicio(string dato)
        {
            return DServicios.Buscar_Servicio(dato);
        }

        public void Ver()
        {
            TablaServicios.DataSource = DServicios.Mostrar_Servicios();
            TablaServicios.Columns[0].Visible = false;
        }

        public void Agregar()
        {
            Servicio servicio = new Servicio("Nuevo");
            servicio.ShowDialog();
        }

        public void Editar()
        {
            Servicio servicio = new Servicio("Modificar");
            servicio.ShowDialog();
        }

        public void Estado()
        {
            if (Fabrica.SiFilaSeleccionada(TablaServicios) == false)
            {
                return;
            }

            int id = Convert.ToInt32(TablaServicios.SelectedRows[0].Cells[0].Value);
            DServicios.Cambiar_Estado_Servicio(id);
            Ver();
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
            TablaServicios.DataSource = DServicios.Buscar_Servicio(text);
        }
    }
}
