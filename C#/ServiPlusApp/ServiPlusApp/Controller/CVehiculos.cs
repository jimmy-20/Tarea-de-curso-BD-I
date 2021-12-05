using Bunifu.UI.WinForms;
using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Model;
using ServiPlusApp.View.Agregar;
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
    public class CVehiculos : IAcciones 
    {
        private BunifuDataGridView TablaVehiculos;
        private Vehiculos vehiculos;
        private int IdCliente;

        public CVehiculos(BunifuDataGridView TablaVehiculos)
        {
            this.TablaVehiculos = TablaVehiculos;
        }
        public static DataTable Mostrar_Vehiculos()
        {
            return DVehiculos.Mostrar_Vehiculos();
        }

        public static DataTable Buscar_vehiculo(string dato)
        {
            return DVehiculos.Buscar_Vehiculo(dato);
        }

        public void Ver()
        {
            TablaVehiculos.DataSource = DVehiculos.Mostrar_Vehiculos();
            TablaVehiculos.Columns[0].Visible = false;
            TablaVehiculos.Columns[1].Visible = false;
        }

        public void Agregar()
        {
            if (Fabrica.SiFilaSeleccionada(TablaVehiculos) is false)
            {
                return;
            }

            vehiculos = new Vehiculos("Nuevo");

            vehiculos.btnGuardar.Click += new EventHandler(Insertar_Vehiculo);

            vehiculos.ShowDialog();
        }

        private void Insertar_Vehiculo(object sender, EventArgs e)
        {
            if (SiCamposVacios() is false)
            {
                return;
            }

            if (DClientes.Buscar_Cliente(vehiculos.txtNombres.Texts + " " + vehiculos.txtApellidos).Rows.Count == 0)
            {
                char delimitador = ' ';

                string[] Nombres = vehiculos.txtNombres.Text.Split(delimitador);
                string[] Apellidos = vehiculos.txtApellidos.Text.Split(delimitador);
                string Direccion = vehiculos.txtDireccion.Text;
                string Correo = vehiculos.txtCorreo.Text;
                string Telefono = vehiculos.txtTelefono.Text;

                string PrimerNombre = Nombres[0];
                string SegundoNombre = Nombres[1];
                string PrimerApellido = Apellidos[0];
                string SegundoApellido = Apellidos[1];

                DClientes.Insertar_Cliente(PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Direccion, Correo, Telefono);
                vehiculos.IdCliente = Convert.ToInt32(DClientes.Buscar_Cliente(PrimerNombre + " " + SegundoNombre + " " + PrimerApellido + " " + SegundoApellido).
                                      Rows[0].ItemArray[0].ToString());
            }

            IdCliente = vehiculos.IdCliente;

            string Marca = vehiculos.txtMarca.Texts;
            string Modelo = vehiculos.txtModelo.Texts;
            int Año = Convert.ToInt32(vehiculos.mascaratxtAño.Text);

            DVehiculos.Insertar_Vehiculo(IdCliente, Marca, Modelo, Año);
        }

        public void Editar()
        {
            if (Fabrica.SiFilaSeleccionada(TablaVehiculos) is false)
            {
                return;
            }

            vehiculos = new Vehiculos("Modificar");

            DataGridViewRow v = TablaVehiculos.SelectedRows[0];
            DataRow c = (DVehiculos.Escalar_Buscar_Vehiculo(Convert.ToInt32(v.Cells[0].Value.ToString()))).Rows[0];

            vehiculos.IdVehiculo = Convert.ToInt32(v.Cells[0].Value);
            vehiculos.IdCliente = Convert.ToInt32(c.ItemArray[0].ToString());

            //Pasando datos de Cliente a Formulario Vehiculo
            vehiculos.txtNombres.Texts = c.ItemArray[1].ToString();
            vehiculos.txtApellidos.Texts = c.ItemArray[2].ToString();
            vehiculos.txtTelefono.Texts = c.ItemArray[3].ToString();
            vehiculos.txtDireccion.Texts = c.ItemArray[4].ToString();
            vehiculos.txtCorreo.Texts = c.ItemArray[5].ToString();

            //Pasando datos de Vehiculo a Formulario Vehiculo
            vehiculos.txtMarca.Texts = v.Cells[3].Value.ToString();
            vehiculos.txtModelo.Texts = v.Cells[4].Value.ToString();
            vehiculos.mascaratxtAño.Text = v.Cells[5].Value.ToString();

            vehiculos.btnModificar.Click += new EventHandler(Editar_Vehiculo);
            vehiculos.ShowDialog();
        }

        private void Editar_Vehiculo(object sender, EventArgs e)
        {
            if (SiCamposVacios() is false)
            {
                return;
            }

            IdCliente = vehiculos.IdCliente;
            int IdVehiculo = vehiculos.IdVehiculo;

            string Marca = vehiculos.txtMarca.Texts;
            string Modelo = vehiculos.txtModelo.Texts;
            int Año = Convert.ToInt32(vehiculos.mascaratxtAño.Text);

            DVehiculos.Editar_Vehiculo(IdVehiculo, IdCliente, Marca, Modelo, Año);
            Ver();
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
            vehiculos.btnCancelar.Click += new EventHandler(Cerrar_Vehiculo);
        }

        private void Cerrar_Vehiculo(object sender, EventArgs e)
        {
            vehiculos.Close();
            vehiculos = null;
        }

        public void Buscar(string text)
        {
            TablaVehiculos.DataSource = DVehiculos.Buscar_Vehiculo(text);
            TablaVehiculos.Columns[0].Visible = false;
        }

        private bool SiCamposVacios()
        {
            if (vehiculos.txtNombres.Texts.Equals("") is true || vehiculos.txtApellidos.Texts.Equals("") is true)
            {
                MessageBox.Show("Rellene el nombre del cliente", "Campos Obligatorios",
                                MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }

            if (vehiculos.txtMarca.Texts == "" || vehiculos.txtModelo.Texts == "" || vehiculos.mascaratxtAño.Text == "")
            {
                MessageBox.Show("Rellene los datos del vehiculo", "Campos Obligatorios",
                                MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }

            return true;
        }
    }
}
