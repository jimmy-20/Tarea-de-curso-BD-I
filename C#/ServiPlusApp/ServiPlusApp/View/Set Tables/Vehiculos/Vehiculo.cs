using Netsystek.Controls.NskControls;
using ServiPlusApp.Controller;
using ServiPlusApp.Controller.Factory;
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

namespace ServiPlusApp.View.Agregar
{
    public partial class Vehiculos : Form
    {
        string Mode;

        public Vehiculos(string Mode)
        {
            InitializeComponent();
            this.Mode = Mode;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            TablaClientes_Load();

            if (Mode.Equals("Nuevo"))
            {
                btnGuardar.Visible = true;
                btnModificar.Visible = false;
            }
            else
            {
                btnGuardar.Visible = false;
                btnModificar.Visible = true;
            }
            txtNombres.Focus();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Txt_Enter(object sender, EventArgs e)
        {
            NskTextBox txt = (NskTextBox)sender;

            txt.Font = new Font(txt.Font.FontFamily, 14);
        }

        private void Txt_Leave(object sender, EventArgs e)
        {
            NskTextBox txt = (NskTextBox)sender;

            txt.Font = new Font(txt.Font.FontFamily, 12);
        }

        private void lblSeleccionarCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlNuevoCliente.Visible = false;
            pnlSeleccionarCliente.Visible = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            pnlNuevoCliente.Visible = true;
            pnlSeleccionarCliente.Visible = false;
        }

        private void btnLimpiarSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            btnLimpiarSearch.Visible = false;
        }

        #region Mostrar Tablas

        private void TablaClientes_Load()
        {
            dgvClientes.DataSource = CClientes.Table_Clientes();
            dgvClientes.Columns[0].Visible = false;
        }

        #endregion

        #region Buscar en Tablas
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length != 0)
            {
                btnLimpiarSearch.Visible = true;
            }
            else
            {
                btnLimpiarSearch.Visible = false;
            }

            if (dgvClientes == null)
            {
                return;
            }
            dgvClientes.DataSource = CClientes.Buscar_Cliente(txtSearch.Text);
        }

        #endregion

        private void dgvClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            DataGridViewRow dr = null;
            if (dgvClientes.SelectedRows.Count > 0)
            {
                dr = dgvClientes.CurrentRow;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
            if (txtSearch.Text == "")
            {
                txtNombres.Texts = dr.Cells[1].Value.ToString();
                txtApellidos.Texts = dr.Cells[2].Value.ToString();
                txtTelefono.Texts = dr.Cells[3].Value.ToString();
                txtCorreo.Texts = dr.Cells[5].Value.ToString();
                txtDireccion.Texts = dr.Cells[4].Value.ToString();
                txtEstado.Texts = dr.Cells[6].Value.ToString();
            }
            else
            {
                txtNombres.Texts = dr.Cells[0].Value.ToString();
                txtApellidos.Texts = dr.Cells[1].Value.ToString();
                txtTelefono.Texts = dr.Cells[2].Value.ToString();
                txtCorreo.Texts = dr.Cells[4].Value.ToString();
                txtDireccion.Texts = dr.Cells[3].Value.ToString();
                txtEstado.Texts = dr.Cells[5].Value.ToString();
            }
         

            btnVolver_Click(btnVolver, null);
            txtMarca.Focus();

           
        }

        private void lblSeleccionarCliente_MouseMove(object sender, MouseEventArgs e)
        {
            lblSeleccionarCliente.Font = new Font(lblSeleccionarCliente.Font.FontFamily,12);
        }

        private void lblSeleccionarCliente_MouseLeave(object sender, EventArgs e)
        {
            lblSeleccionarCliente.Font = new Font(lblSeleccionarCliente.Font.FontFamily, 10);

        }
    }
}
