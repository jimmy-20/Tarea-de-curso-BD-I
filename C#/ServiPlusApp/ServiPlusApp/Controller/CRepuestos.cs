﻿using ServiPlusApp.Controller.Factory;
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
    public class CRepuestos : IAcciones 
    {
        private MostrarTabla FrmRepuesto;

        public CRepuestos(MostrarTabla FrmRepuesto)
        {
            this.FrmRepuesto = FrmRepuesto;
        }

        public void Ver()
        {
            FrmRepuesto.DgvTablas.DataSource = DRepuestos.Mostrar_Repuestos();
            FrmRepuesto.DgvTablas.Columns[0].Visible = false;
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
            FrmRepuesto.DgvTablas.DataSource = DRepuestos.Buscar_Repuesto(text);
        }
    }
}