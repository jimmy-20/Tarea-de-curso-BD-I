using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Model;
using ServiPlusApp.View.Set_Tables.Mecanicos;
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
    public class CMecanicos : IAcciones
    {
        private ShowTable FrmMecanico;
        public CMecanicos(ShowTable FrmMecanico)
        {
            this.FrmMecanico = FrmMecanico;
        }
        public void Ver()
        {
            FrmMecanico.DgvTablas.DataSource = DMecanicos.Mostrar_Mecanicos();
            FrmMecanico.DgvTablas.Columns[0].Visible = false;
        }

        public void Agregar()
        {
            Mecanico mecanico = new Mecanico("Nuevo");
            mecanico.ShowDialog();
        }

        public void Editar()
        {
            Mecanico mecanico = new Mecanico("Modificar");
            mecanico.ShowDialog();
        }

        public void Estado()
        {
            if (Fabrica.SiFilaSeleccionada(FrmMecanico.DgvTablas) == false)
            {
                return;
            }

            DataGridViewRow row = FrmMecanico.DgvTablas.SelectedRows[0];

            int id = Convert.ToInt32(row.Cells[0].Value);
            DMecanicos.Cambiar_Estado_Mecanico(id);
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
            FrmMecanico.DgvTablas.DataSource = DMecanicos.Buscar_Mecanico(text);
        }
    }
}
