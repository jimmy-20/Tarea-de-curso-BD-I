﻿using ServiPlusApp.Controller.Factory;
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
    public class CMecanicos : IAcciones
    {
        private MostrarTabla FrmMecanico;
        public CMecanicos(MostrarTabla FrmMecanico)
        {
            this.FrmMecanico = FrmMecanico;
        }
        public static DataTable Mostrar_Mecanicos()
        {
            return DMecanicos.Mostrar_Mecanicos();
        }

        public static DataTable Buscar_Mecanico(string dato)
        {
            return DMecanicos.Buscar_Mecanico(dato);
        }

        public void Ver()
        {
            throw new NotImplementedException();
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
            if (Fabrica.SiFilaSeleccionada(FrmMecanico.DgvTablas) == false)
            {
                return;
            }

            DataGridViewRow row = FrmMecanico.DgvTablas.SelectedRows[0];

            int id = Convert.ToInt32(row.Cells[0].Value);
            
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
