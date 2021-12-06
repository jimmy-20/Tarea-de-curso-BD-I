using Bunifu.UI.WinForms;
using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Model;
using ServiPlusApp.View.Mantenimientos;
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
    public class CMantenimientos : IAcciones
    {
        private BunifuDataGridView TablaMantenimientos;
        private Mantenimiento mantenimiento;

        public CMantenimientos(BunifuDataGridView TablaMantenimientos)
        {
            this.TablaMantenimientos = TablaMantenimientos;
        }


        public void Ver()
        {
            TablaMantenimientos.DataSource = DMantenimientos.Mostrar_Mantenimientos();
            TablaMantenimientos.Columns[0].Visible = false;
            TablaMantenimientos.Columns[1].Visible = false;
        }

        public void Agregar()
        {
            mantenimiento = new Mantenimiento("Nuevo");
            mantenimiento.btnGuardar.Click += new EventHandler(Insertar_Mantenimiento);
            DeshabilitarTxt();

            mantenimiento.btnCancelar.Click += new EventHandler(Cancelar_Datos);

            mantenimiento.ShowDialog();
        }

        private void Cancelar_Datos(object sender, EventArgs e)
        {
            mantenimiento.txtIdCliente.Clear();
            mantenimiento.txtFullnameCliente.Clear();
            mantenimiento.txtTelefCliente.Clear();
            mantenimiento.txtDireccionCliente.Clear();

            mantenimiento.txtMarcaVehiculo.Clear();
            mantenimiento.txtModeloVehiculo.Clear();
            mantenimiento.txtAñoVehiculo.Clear();

            mantenimiento.txtMecanicoFullname.Clear();
            mantenimiento.txtIdMecanico.Clear();
        }

        private void Insertar_Mantenimiento(object sender, EventArgs e)
        {
            int IdVehiculo = mantenimiento.IdVehiculo;
            DateTime FechaEntrada = mantenimiento.dpFechaDeIngreso.Value.Date;
            DateTime FechaSalida = mantenimiento.dpFechaDeSalida.Value.Date;
            int IdMecanico = Convert.ToInt32(mantenimiento.txtIdMecanico.Text);

            int IdServicio = 0;
            IdServicio = Convert.ToInt32(mantenimiento.dgvServicios.Rows[0].Cells[0].Value);
            DMantenimientos.Insertar_Mantenimiento(IdVehiculo, FechaEntrada, FechaSalida, IdMecanico, IdServicio);

            if (mantenimiento.dgvServicios.Rows.Count > 1)
            {
                int IdMantenimiento = Convert.ToInt32(DMantenimientos.Escalar_Buscar_Mantenimiento().Rows[0].ItemArray[0]);
                foreach (DataGridViewRow row in mantenimiento.dgvServicios.Rows)
                {
                    IdServicio = Convert.ToInt32(row.Cells[0].Value);
                    IdMecanico = Convert.ToInt32(row.Cells[6].Value);

                    DMantenimientos.Asignar_Servicio(IdMantenimiento, IdMecanico, IdServicio);
                }
            }

            MessageBox.Show("Mantenimiento insertado", "SERVIPLUS",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Editar()
        {
            if (Fabrica.SiFilaSeleccionada(TablaMantenimientos) is false)
            {
                return;
            }

            mantenimiento = new Mantenimiento("Modificar");
            mantenimiento.btnModificar.Click += new EventHandler(Editar_Mantenimiento);

            DeshabilitarTxt();

            DataGridViewRow row = TablaMantenimientos.CurrentRow;

            int IdMantenimiento = Convert.ToInt32(row.Cells[0].Value);
            int IdVehiculo = Convert.ToInt32(row.Cells[1].Value);

            string Marca = row.Cells[3].Value.ToString();
            string Modelo = row.Cells[4].Value.ToString();
            int Año = Convert.ToInt32(row.Cells[5].Value);

            DateTime FechaEntrada = Convert.ToDateTime(row.Cells[6].Value);
            DateTime FechaSalida = Convert.ToDateTime(row.Cells[7].Value);

            DataTable dt = DVehiculos.Escalar_Buscar_Vehiculo(IdVehiculo);

            int IdCliente = Convert.ToInt32(dt.Rows[0][0]);
            string Nombre = dt.Rows[0][1].ToString() + ' ' + dt.Rows[0][2].ToString();
            string Telefono = dt.Rows[0][3].ToString();
            string Direccion = dt.Rows[0][4].ToString();

            mantenimiento.IdMantenimiento = IdMantenimiento;

            mantenimiento.txtIdCliente.Text = IdCliente.ToString();
            mantenimiento.txtFullnameCliente.Text = Nombre;
            mantenimiento.txtTelefCliente.Text = Telefono;
            mantenimiento.txtDireccionCliente.Text = Direccion;

            mantenimiento.txtMarcaVehiculo.Text = Marca;
            mantenimiento.txtModeloVehiculo.Text = Modelo;
            mantenimiento.txtAñoVehiculo.Text = Año.ToString();

            mantenimiento.dpFechaDeIngreso.Value = FechaEntrada;
            mantenimiento.dpFechaDeSalida.Value = FechaSalida;


            mantenimiento.ShowDialog();
        }

        private void Editar_Mantenimiento(object sender, EventArgs e)
        {
        }

        public void Estado()
        {
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
            TablaMantenimientos.DataSource = DMantenimientos.Buscar_Mantenimiento(text);
        }
        private void DeshabilitarTxt()
        {
            mantenimiento.txtIdCliente.Enabled = false;
            mantenimiento.txtIdMecanico.Enabled = false;
            mantenimiento.txtMecanicoFullname.Enabled = false;
            mantenimiento.txtFullnameCliente.Enabled = false;
            mantenimiento.txtTelefCliente.Enabled = false;
            mantenimiento.txtDireccionCliente.Enabled = false;
            mantenimiento.txtMarcaVehiculo.Enabled = false;
            mantenimiento.txtModeloVehiculo.Enabled = false;
            mantenimiento.txtAñoVehiculo.Enabled = false;
        }
    }
}
