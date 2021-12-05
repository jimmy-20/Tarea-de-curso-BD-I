using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using ServiPlusApp.Controller;
using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Enums;
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

        private IAcciones formulario;

        public Mantenimiento(string mode)
        {
            InitializeComponent();
            this.mode = mode;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

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
                txtIdMecanico.Text = row.Cells[0].Value.ToString();
                txtMecanicoFullname.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
            }
            else if (btnVehEstado)
            {
                txtMarcaVehiculo.Text = row.Cells[3].Value.ToString();
                txtModeloVehiculo.Text = row.Cells[4].Value.ToString();
                txtAñoVehiculo.Text = row.Cells[5].Value.ToString();
            }
            else if (btnSerEstado)
            {
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
                lblSubtotalServicios.Text = (Convert.ToInt32(dgvServicios[2, dgvServicios.RowCount - 1].Value.ToString())+ Convert.ToInt32(lblSubtotalServicios.Text.ToString())).ToString();
                lblDescuentoTotalServicios.Text = (Convert.ToInt32(dgvServicios[3, dgvServicios.RowCount - 1].Value) + Convert.ToInt32(lblDescuentoTotalServicios.Text.ToString())).ToString();
                lblTotalServicios.Text = (Convert.ToInt32(lblSubtotalServicios.Text) - Convert.ToInt32(lblDescuentoTotalServicios.Text)).ToString();
            }

            btnClosePanelBuscador_Click(null, null);

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEstado.ForeColor = Color.Black;
        }

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
            dgvServicios.Rows.Remove(row); //Elimino la fila


            lblCantServicios.Text = dgvServicios.RowCount.ToString(); //Actualizo el contador de servicios

            lblSubtotalServicios.Text = (Convert.ToInt32(lblSubtotalServicios.Text) - Convert.ToInt32(row.Cells[2].Value.ToString())).ToString();
           
            lblDescuentoTotalServicios.Text = (Convert.ToInt32(lblDescuentoTotalServicios.Text) - Convert.ToInt32(row.Cells[3].Value.ToString())).ToString();
           
            lblTotalServicios.Text = (Convert.ToInt32(lblSubtotalServicios.Text) - Convert.ToInt32(lblDescuentoTotalServicios.Text)).ToString();

           
        }

        private void btnVaciarServicios_Click(object sender, EventArgs e)
        {
            dgvServicios.Rows.Clear();

            lblCantServicios.Text = "0";
            lblSubtotalServicios.Text = "0";
            lblDescuentoTotalServicios.Text = "0";
            lblTotalServicios.Text = "0";
        }

        private void btnSecundarioBuscarServicios_Click(object sender, EventArgs e)
        {
            btnBuscar_Click(btnBuscarServicio, null);
        }

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
                            dgvBuscador.Rows[row.Index].Visible = false;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void lblFiltroTodos_Click(object sender, EventArgs e)
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
    }
}
