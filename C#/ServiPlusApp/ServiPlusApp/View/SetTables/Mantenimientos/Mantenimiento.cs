using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using ServiPlusApp.Controller;
using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Enums;
using ServiPlusApp.Model;
using ServiPlusApp.View.SetTables.Mantenimientos.Historial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BunifuDropdown = Bunifu.UI.WinForms.BunifuDropdown;

namespace ServiPlusApp.View.Mantenimientos
{
    public partial class Mantenimiento : Form
    {
        string mode;
        public int IdVehiculo = 0;
        public int IdMantenimiento;
        public Historial historial;

        private IAcciones formulario;
        public Mantenimiento(string mode)
        {
            InitializeComponent();
            this.mode = mode;

            label14.Text = "IVA";

            dgvServicios.Columns[3].HeaderText = "Tipo";
            dgvServicios.Columns[4].HeaderText = "Mecanico";
            dgvServicios.Columns.Add(new DataGridViewTextBoxColumn());
            dgvServicios.Columns[6].Visible = true;

        }

        #region Mover Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion 

        #region Eventos del Formularios
        private void Mantenimiento_Load(object sender, EventArgs e)
        {

            switch (mode)
            {
                case "Nuevo":
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    break;
                case "Modificar":
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    break;
                default:
                    break;
            }

            cmbEstado.Items.AddRange(Estados.Mantenimiento);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion


        #region Eventos de los botones Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BunifuIconButton btn = (BunifuIconButton)sender;

            pnlBuscador.Visible = true;
            pnlDatosMant2.Visible = false;
            SeparadorBuscador.LineColor = Color.Crimson;

            formulario = null;
            formulario = Fabrica.FormController(dgvBuscador, btn.Tag.ToString());
            formulario.Ver();

            TablaDestino(btn.Tag.ToString());
        }

        bool btnMecEstado = false;
        bool btnCtsEstado = false;
        bool btnVehEstado = false;
        bool btnSerEstado = false;

        private void TablaDestino(string dato)
        {
            btnMecEstado = false;
            btnCtsEstado = false;
            btnVehEstado = false;
            btnSerEstado = false;

            switch (dato)
            {
                case "Mecanicos":
                    bunifuTransition1.Show(btnSecundarioBuscarServicios);

                    btnMecEstado = true;
                    break;
                case "Clientes":
                    bunifuTransition1.Show(btnSecundarioBuscarServicios);

                    btnCtsEstado = true;
                    break;
                case "Vehiculos":
                    bunifuTransition1.Show(btnSecundarioBuscarServicios);

                    btnVehEstado = true;
                    break;
                case "Servicios":
                    btnSecundarioBuscarServicios.Visible = false;
                    btnSerEstado = true;
                    break;
                default:
                    break;
            }
        }

        private void btnSecundarioBuscarServicios_Click(object sender, EventArgs e)
        {
            btnBuscar_Click(btnBuscarServicio, null);
        }

        #endregion


        #region Eventos Panel Buscador
        private void btnClosePanelBuscador_Click(object sender, EventArgs e)
        {
            pnlBuscador.Visible = false;
            pnlDatosMant2.Visible = true;
            SeparadorBuscador.LineColor = Color.DodgerBlue;

            btnSecundarioBuscarServicios.Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            formulario.Buscar(txtSearch.Text);

            if (rbtnTodos.Checked)
            {
                rbtnFiltroMostrarPor_Click(rbtnTodos, null);
            }
            else if (rbtnHabilitados.Checked)
            {
                rbtnFiltroMostrarPor_Click(rbtnHabilitados, null);
            }
            else if (rbtnDeshabilitado.Checked)
            {
                rbtnFiltroMostrarPor_Click(rbtnDeshabilitado, null);
            }

        }

        #region Filtro del Panel Buscador

        private void rbtnFiltroMostrarPor_Click(object sender, EventArgs e)
        {
            BunifuRadioButton rbtn = (BunifuRadioButton)sender;

            switch (rbtn.Tag)
            {
                case "Todos":
                    foreach (DataGridViewRow row in dgvBuscador.Rows)
                    {
                        dgvBuscador.Rows[row.Index].Visible = true;
                    }
                    break;
                case "Habilitado":
                    foreach (DataGridViewRow row in dgvBuscador.Rows)
                    {
                        if (dgvBuscador[dgvBuscador.ColumnCount - 1, row.Index].Value.Equals(rbtn.Tag))
                        {
                            dgvBuscador.Rows[row.Index].Visible = true;
                        }
                        else
                        {
                            this.dgvBuscador.CurrentCell = null;
                            dgvBuscador.Rows[row.Index].Visible = false;
                        }
                    }
                    break;
                case "Deshabilitado":
                    foreach (DataGridViewRow row in dgvBuscador.Rows)
                    {
                        if (dgvBuscador[dgvBuscador.ColumnCount - 1, row.Index].Value.Equals(rbtn.Tag))
                        {
                            dgvBuscador.Rows[row.Index].Visible = true;
                        }
                        else
                        {
                            this.dgvBuscador.CurrentCell = null;
                            dgvBuscador.Rows[row.Index].Visible = false;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void lblFiltro_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            rbtnTodos.Checked = false;
            rbtnHabilitados.Checked = false;
            rbtnDeshabilitado.Checked = false;

            switch (lbl.Tag)
            {
                case "Todos":
                    rbtnTodos.Checked = true;
                    rbtnFiltroMostrarPor_Click(rbtnTodos, null);
                    break;
                case "Habilitado":
                    rbtnHabilitados.Checked = true;
                    rbtnFiltroMostrarPor_Click(rbtnTodos, null);
                    break;
                case "Deshabilitado":
                    rbtnDeshabilitado.Checked = true;
                    rbtnFiltroMostrarPor_Click(rbtnTodos, null);
                    break;
                default:
                    break;
            }
        }

        #endregion

        int index = 0;
        private void dgvBuscador_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvBuscador.CurrentRow;

            if (btnCtsEstado)
            {
                txtIdCliente.Text = row.Cells[0].Value.ToString();
                txtFullnameCliente.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
                txtTelefCliente.Text = row.Cells[3].Value.ToString();
                txtDireccionCliente.Text = row.Cells[4].Value.ToString();


            }
            else if (btnMecEstado)
            {
                if (dgvServicios.Rows.Count <= 0)
                {
                    MessageBox.Show("Seleccione al menos 1 servicio para asignar el mecanico", "Sin ningun servicio",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtIdMecanico.Text = row.Cells[0].Value.ToString();
                txtMecanicoFullname.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
                dgvServicios.Rows[dgvServicios.Rows.Count - 1].Cells[4].Value = txtMecanicoFullname.Text;
                dgvServicios.Rows[dgvServicios.Rows.Count - 1].Cells[6].Value = txtIdMecanico.Text;


            }
            else if (btnVehEstado)
            {

                IdVehiculo = Convert.ToInt32(row.Cells[0].Value);
                txtMarcaVehiculo.Text = row.Cells[3].Value.ToString();
                txtModeloVehiculo.Text = row.Cells[4].Value.ToString();
                txtAñoVehiculo.Text = row.Cells[5].Value.ToString();

                DataTable clientes = DVehiculos.Escalar_Buscar_Vehiculo(IdVehiculo);

                txtIdCliente.Text = clientes.Rows[0][0].ToString();
                txtFullnameCliente.Text = clientes.Rows[0][1].ToString() + ' ' + clientes.Rows[0][2].ToString();
                txtTelefCliente.Text = clientes.Rows[0][3].ToString();
                txtDireccionCliente.Text = clientes.Rows[0][4].ToString();
            }
            else if (btnSerEstado)
            {
                if (dgvServicios.Rows.Count != 0)
                {
                    if (dgvServicios.Rows[dgvServicios.Rows.Count - 1].Cells[4].Value is null || dgvServicios.Rows[dgvServicios.Rows.Count - 1].Cells[4].Value.Equals(""))
                    {
                        MessageBox.Show("Asigne primero el mecanico para asignar otro servicio", "Sin mecanico",
                                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                index = dgvServicios.Rows.Add();

                foreach (DataGridViewColumn column in dgvBuscador.Columns)
                {
                    if (dgvBuscador.Columns[column.Index].Name.Equals("Estado"))
                    {
                        continue;
                    }
                    dgvServicios[column.Index, index].Value = dgvBuscador[column.Index, row.Index].Value;
                }

                lblCantServicios.Text = dgvServicios.RowCount.ToString(); //Actualizo el contador
                lblSubtotalServicios.Text = (Convert.ToDouble(dgvServicios[2, dgvServicios.RowCount - 1].Value.ToString()) + Convert.ToDouble(lblSubtotalServicios.Text.ToString())).ToString();
                lblIVA.Text = (Convert.ToDouble(lblSubtotalServicios.Text) * 0.15).ToString();
                lblTotalServicios.Text = (Convert.ToDouble(lblSubtotalServicios.Text) + Convert.ToDouble(lblIVA.Text)).ToString();
            }

            btnClosePanelBuscador_Click(null, null);

        }


        #endregion


        #region Eventos del panel Servicios

        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell celda = dgvServicios.CurrentCell;

            if (celda.OwningColumn.Name == "SeQuitar")
            {
                EliminarAsignacionDeServicio(celda.OwningRow);
            }
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            if (dgvServicios.CurrentRow == null)
            {
                return;
            }

            EliminarAsignacionDeServicio(dgvServicios.CurrentRow);
        }

        private void EliminarAsignacionDeServicio(DataGridViewRow row)
        {
            dgvServicios.Rows.Remove(row);


            lblCantServicios.Text = dgvServicios.RowCount.ToString();

            lblSubtotalServicios.Text = (Convert.ToInt32(lblSubtotalServicios.Text) - Convert.ToInt32(row.Cells[2].Value.ToString())).ToString();

            lblIVA.Text = (Convert.ToDouble(lblSubtotalServicios.Text) * 0.15).ToString();

            lblTotalServicios.Text = (Convert.ToInt32(lblSubtotalServicios.Text) + Convert.ToInt32(lblIVA.Text)).ToString();
        }

        private void btnVaciarServicios_Click(object sender, EventArgs e)
        {
            dgvServicios.Rows.Clear();

            lblCantServicios.Text = "0";
            lblSubtotalServicios.Text = "0";
            lblIVA.Text = "0";
            lblTotalServicios.Text = "0";
        }


        #endregion

        #region Mantenimiento

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEstado.ForeColor = Color.Black;
        }


        #endregion

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            //Aqui debes validar que haya un vehiculo agregado, es decir,
            //que ya se haya agregado un vehiculo o seleccionado uno,
            //en otras palabras que los paneles de vehiculo este lleno

            if (IdVehiculo == 0)
            {
                MessageBox.Show("Seleccione un vehiculo para ver su historial", "SERVIPLUS",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            historial = new Historial(IdVehiculo);
            historial.ShowDialog();
        }
    }
}
