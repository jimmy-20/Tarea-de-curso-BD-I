using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Model;
using ServiPlusApp.View.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller
{
    public class CUsuarios : IAcciones 
    {
        private ShowTable FrmUsuario;

        public CUsuarios(ShowTable FrmUsuario)
        {
            this.FrmUsuario = FrmUsuario;
        }

        public void Agregar()
        {
            throw new NotImplementedException();
        }

        public void Buscar(string text)
        {
            FrmUsuario.DgvTablas.DataSource = DUser.Buscar_Usuario(text);
        }

        public void Cancelar()
        {
            throw new NotImplementedException();
        }

        public void Editar()
        {
            throw new NotImplementedException();
        }

        public void Estado()
        {
            if (Fabrica.SiFilaSeleccionada(FrmUsuario.DgvTablas) == false)
            {
                return;
            }

            int id = Convert.ToInt32(FrmUsuario.DgvTablas.SelectedRows[0].Cells[0].Value);
            DUser.Cambiar_Estado_Usuario(id);

            Ver();
        }

        public void Guardar()
        {
            throw new NotImplementedException();
        }

        public void Ver()
        {
            FrmUsuario.DgvTablas.DataSource = DUser.Tabla_Usuarios();
        }
    }
}
