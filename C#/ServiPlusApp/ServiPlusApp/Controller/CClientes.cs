using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Model;
using ServiPlusApp.View.Agregar.Cliente;
using ServiPlusApp.View.Tablas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ServiPlusApp.Controller
{
    public class CClientes : IAcciones 
    {
        public ShowTable FrmCliente { get; set; }

        public CClientes(ShowTable FrmCliente)
        {
            this.FrmCliente = FrmCliente;
        }

        public void Agregar()
        {
            Clientes clientes = new Clientes("Nuevo");
            clientes.ShowDialog();
        }

        public void Editar()
        {
            Clientes clientes = new Clientes("Modificar");
            clientes.ShowDialog();
        }

        public void Estado()
        {
            if (Fabrica.SiFilaSeleccionada(FrmCliente.DgvTablas) == false)
            {
                return;
            }

            DataGridViewRow row = FrmCliente.DgvTablas.SelectedRows[0];
            int id = Convert.ToInt32(FrmCliente.DgvTablas.SelectedRows[0].Cells[0].Value);

            DClientes.Cambiar_Estado(id);
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

        public void Ver()
        {
            FrmCliente.DgvTablas.DataSource = DClientes.Tabla_Clientes();
            FrmCliente.DgvTablas.Columns[0].Visible = false;
        }

        public static DataTable Table_Clientes()
        {
            return DClientes.Tabla_Clientes();
        }

        public static DataTable Buscar_Cliente(string dato)
        {
            return DClientes.Buscar_Cliente(dato);
        }

        public void Buscar(string text)
        {
            FrmCliente.DgvTablas.DataSource = DClientes.Buscar_Cliente(text);
            FrmCliente.DgvTablas.Columns[0].Visible = false;
        }
    }
}
