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
using System.Windows.Controls;
using System.Windows.Forms;

namespace ServiPlusApp.Controller
{
    public class CClientes : IAcciones 
    {
        public ShowTable FrmCliente { get; set; }
        private Clientes clientes;

        public CClientes(ShowTable FrmCliente)
        {
            this.FrmCliente = FrmCliente;
        }

        public void Agregar()
        {
            clientes = new Clientes("Nuevo");
            clientes.btnNuevo.Click += new EventHandler(Insertar_Cliente);

            clientes.ShowDialog();

        }

        private void Insertar_Cliente(object sender, EventArgs e)
        {
            if (SiCamposVacios() is false)
            {
                return;
            }

            char delimitador = ' ';

            string[] Nombres = clientes.txtNombres.Text.Split(delimitador);
            string[] Apellidos = clientes.txtApellidos.Text.Split(delimitador);
            string Direccion = clientes.txtDireccion.Text;
            string Correo = clientes.txtCorreo.Text;
            string Telefono = clientes.txtTelefono.Text;

            string PrimerNombre = Nombres[0];
            string SegundoNombre = Nombres[1];
            string PrimerApellido = Apellidos[0];
            string SegundoApellido = Apellidos[1];


            DClientes.Insertar_Cliente(PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,Direccion,Correo,Telefono);
            Ver();
        }

        public void Editar()
        {
            if (Fabrica.SiFilaSeleccionada(FrmCliente.DgvTablas) is false)
            {
                return;
            }

            clientes = new Clientes("Modificar");

            DataGridViewRow row = FrmCliente.DgvTablas.SelectedRows[0];

            clientes.txtNombres.Text = row.Cells[1].Value.ToString();
            clientes.txtApellidos.Text = row.Cells[2].Value.ToString();
            clientes.txtTelefono.Text = row.Cells[3].Value.ToString();
            clientes.txtDireccion.Text = row.Cells[4].Value.ToString();
            clientes.txtCorreo.Text = row.Cells[5].Value.ToString();

            clientes.btnModificar.Click += new EventHandler(Editar_Cliente);
            clientes.ShowDialog();
        }

        private void Editar_Cliente(object sender, EventArgs e)
        {
            if (SiCamposVacios() is false)
            {
                return;
            }

            int IdCliente = Convert.ToInt32(FrmCliente.DgvTablas.SelectedRows[0].Cells[0].Value);

            char delimitador = ' ';

            string[] Nombres = clientes.txtNombres.Text.Split(delimitador);
            string[] Apellidos = clientes.txtApellidos.Text.Split(delimitador);
            string Direccion = clientes.txtDireccion.Text;
            string Correo = clientes.txtCorreo.Text;
            string Telefono = clientes.txtTelefono.Text;

            string PrimerNombre = Nombres[0];
            string SegundoNombre = Nombres[1];
            string PrimerApellido = Apellidos[0];
            string SegundoApellido = Apellidos[1];

            DClientes.Editar_Cliente(IdCliente,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,Direccion,Correo,Telefono);

            Ver();
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

        private bool SiCamposVacios()
        {
            if (clientes.txtNombres.Text == "" || clientes.txtApellidos.Text == "")
            {
                MessageBox.Show("Los campos del nombre del cliente tienen que tener información", "Campos obligatorios"
                                , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (clientes.txtTelefono.Text == "" || clientes.txtCorreo.Text == "" || clientes.txtDireccion.Text == "")
            {
                MessageBox.Show("Se necesita por lo menos, una forma de comunicación con el cliente", "Campos obligatorios"
                                , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
