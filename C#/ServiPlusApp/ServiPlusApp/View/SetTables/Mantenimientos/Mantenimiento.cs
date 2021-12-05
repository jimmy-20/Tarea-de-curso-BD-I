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

        BunifuDataGridView dgv;
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            BunifuIconButton btn = (BunifuIconButton)sender;

            pnlBuscador.Visible = true;
            pnlDatosMant2.Visible = false;
            SeparadorBuscador.Visible = true;

            formulario = null;
            formulario = Fabrica.FormController(dgvBuscador, btn.Tag.ToString());
            formulario.Ver();

            dgv = TablaDestino(btn.Tag.ToString());
        }
        bool btnMecEstado = false;
        bool btnCtsEstado = false;
        bool btnVehEstado = false;
        bool btnSerEstado = false;
        bool btnRepEstado = false;

        private BunifuDataGridView TablaDestino(string dato)
        {
            btnMecEstado = false;
            btnCtsEstado = false;
            btnVehEstado = false;
            btnSerEstado = false;
            btnRepEstado = false;

            switch (dato)
            {
                case "Mecanicos":
                    btnMecEstado = true;
                    return null;
                case "Clientes":
                     btnCtsEstado = true;
                    return null;
                case "Vehiculos":
                     btnVehEstado = true;
                    return null;
                case "Repuestos":
                    btnRepEstado = true;
                    return dgvRepuestos;
                case "Servicios":
                    btnSerEstado = true;
                    return dgvServicios;
                default:
                    return null;
            }
        }

       

        private void btnClosePanelBuscador_Click(object sender, EventArgs e)
        {
            pnlBuscador.Visible = false;
            pnlDatosMant2.Visible = true;
            SeparadorBuscador.Visible = false;
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            formulario.Buscar(txtSearch.Text);
        }


        int index=0;
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
                index = dgv.Rows.Add();
                foreach (DataGridViewColumn column in dgvBuscador.Columns)
                {
                    dgv[column.Index, index].Value = dgvBuscador[column.Index, row.Index].Value;
                }

            }
            else if (btnRepEstado)
            {
                index = dgv.Rows.Add();
                foreach (DataGridViewColumn column in dgvBuscador.Columns)
                {
                    dgv[column.Index, index].Value = dgvBuscador[column.Index, row.Index].Value;
                }

            }

            btnClosePanelBuscador_Click(null, null);
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEstado.ForeColor = Color.Black;
        }
    }
}
