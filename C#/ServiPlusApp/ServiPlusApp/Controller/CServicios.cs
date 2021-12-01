using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Model;
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
        private ShowTable FrmServicio;
        public CServicios(ShowTable FrmServicio)
        {
            this.FrmServicio = FrmServicio;
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
            FrmServicio.DgvTablas.DataSource = DServicios.Mostrar_Servicios();
            FrmServicio.DgvTablas.Columns[0].Visible = false;
        }

        public void Agregar()
        {
           
        }

        public void Editar()
        {
          
        }

        public void Estado()
        {
            if (Fabrica.SiFilaSeleccionada(FrmServicio.DgvTablas) == false)
            {
                return;
            }

            int id = Convert.ToInt32(FrmServicio.DgvTablas.SelectedRows[0].Cells[0].Value);
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
            FrmServicio.DgvTablas.DataSource = DServicios.Buscar_Servicio(text);
        }
    }
}
