using Bunifu.UI.WinForms;
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
        public BunifuDataGridView TablaClientes;

        public CClientes(BunifuDataGridView TablaClientes)
        {
            this.TablaClientes = TablaClientes;
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
            if (Fabrica.SiFilaSeleccionada(TablaClientes) == false)
            {
                return;
            }

            DataGridViewRow row = TablaClientes.SelectedRows[0];
            int id = Convert.ToInt32(TablaClientes.SelectedRows[0].Cells[0].Value);

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
            TablaClientes.DataSource = DClientes.Tabla_Clientes();
            TablaClientes.Columns[0].Visible = false;
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
            TablaClientes.DataSource = DClientes.Buscar_Cliente(text);
            TablaClientes.Columns[0].Visible = false;
        }
    }
}
