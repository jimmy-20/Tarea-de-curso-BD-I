using ServiPlusApp.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiPlusApp.View.Tablas
{
    public partial class MostrarTabla : Form
    {
        String tableName;
        public MostrarTabla(string TableName)
        {
            InitializeComponent();
            this.tableName = TableName;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TablaUsuarios_Load(object sender, EventArgs e)
        {

            lblTableName.Text = tableName;

            switch (tableName)
            {
                case "Vehiculos":
                    {
                        dgvTablas.DataSource = CVehiculos.Mostrar_Vehiculos();


                        dgvTablas.Columns[0].Visible = false;
                      //  dgvUsuarios.Columns[1].Visible = false;
                        break;
                    }
                case "Clientes":
                    {
                        dgvTablas.DataSource = CClientes.Table_Clientes();


                        dgvTablas.Columns[0].Visible = false;
                       // dgvUsuarios.Columns[1].Visible = false;
                        break;

                    }
                case "Servicios":
                    {
                        dgvTablas.DataSource = CServicios.Mostrar_Servicios();


                        dgvTablas.Columns[0].Visible = false;
                      //  dgvUsuarios.Columns[1].Visible = false;
                        break;

                    }
                case "Mecanicos":
                    {
                        dgvTablas.DataSource = CMecanicos.Mostrar_Mecanicos();


                        dgvTablas.Columns[0].Visible = false;
                      //  dgvUsuarios.Columns[1].Visible = false;
                        break;

                    }
                case "Usuarios":
                    {
                        dgvTablas.DataSource = CUser.Table_Usuarios();


                        dgvTablas.Columns[0].Visible = false;
                        dgvTablas.Columns[1].Visible = false;
                        break;

                    }
                case "ReMantenimientos":
                    {
                        //dgvUsuarios.DataSource = CUser.Table_Usuarios();


                        //dgvUsuarios.Columns[0].Visible = false;
                        //dgvUsuarios.Columns[1].Visible = false;
                        break;

                    }
                case "ReRepuestos":
                    {
                        //dgvUsuarios.DataSource = CUser.Table_Usuarios();


                        //dgvUsuarios.Columns[0].Visible = false;
                        //dgvUsuarios.Columns[1].Visible = false;
                        break;

                    }
                case "OpRepuestos":
                    {
                        dgvTablas.DataSource = CRepuestos.Mostrar_Repuestos();


                        dgvTablas.Columns[0].Visible = false;
                        dgvTablas.Columns[1].Visible = false;
                        break;

                    }
                case "OpMantenimientos":
                    {
                        dgvTablas.DataSource = CMantenimientos.Mostrar_Mantenimientos();


                        dgvTablas.Columns[0].Visible = false;
                        dgvTablas.Columns[1].Visible = false;
                        break;

                    }
                default:
                    break;
            }
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //if (tbcTablas.TabPages.Count == 0)
            //{
            //    return;
            //}


            //if (tbcTablas.SelectedTab == tpUsuarios)
            //{
            //    if (dgvUsuarios == null)
            //    {
            //        return;
            //    }
            //    dgvUsuarios.DataSource = CBuscarUsuario.Buscar_Usuario(this.txtSearch.Text);
            //}

            //if (tbcTablas.SelectedTab == tpClientes)
            //{
            //    if (dgvClientes == null)
            //    {
            //        return;
            //    }
            //    dgvClientes.DataSource = CBuscarCliente.Buscar_Cliente(this.txtSearch.Text);
            //}

            //if (tbcTablas.SelectedTab == tpMecanicos)
            //{
            //    if (dgvMecanicos == null)
            //    {
            //        return;
            //    }
            //    dgvMecanicos.DataSource = CBuscarMecanico.Buscar_Mecanico(this.txtSearch.Text);
            //}

            //if (tbcTablas.SelectedTab == tpServicios)
            //{
            //    if (dgvServicios == null)
            //    {
            //        return;
            //    }
            //    dgvServicios.DataSource = CBuscarServicio.Buscar_Servicio(this.txtSearch.Text);
            //}

            //if (tbcTablas.SelectedTab == tpVehiculos)
            //{
            //    if (dgvVehiculos == null)
            //    {
            //        return;
            //    }
            //    dgvVehiculos.DataSource = CBuscarVehiculo.Buscar_vehiculo(this.txtSearch.Text);
            //}

            //if (tbcTablas.SelectedTab == tpRepuestos)
            //{
            //    if (dgvRepuestos == null)
            //    {
            //        return;
            //    }
            //    dgvRepuestos.DataSource = CBuscarRepuesto.Buscar_Repuesto(this.txtSearch.Text);
            //}

            //if (tbcTablas.SelectedTab == tpMantenimientos)
            //{
            //    if (dgvMantenimientos == null)
            //    {
            //        return;
            //    }
            //    dgvMantenimientos.DataSource = CBuscarMantenimiento.Buscar_Mantenimiento(this.txtSearch.Text);
            //}

        }
    }
}
