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

namespace ServiPlusApp.View.Set_Tables.Servicios
{
    public partial class Servicio : Form
    {
        public Servicio(string mode)
        {
            InitializeComponent();
            this.mode = mode;
        }
        string mode;


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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Servicio_Load(object sender, EventArgs e)
        {
            cmbTipoDeMatenimiento.Items.AddRange(TiposDeMantenimientos.Servicios);
            cmbEstado.Items.AddRange(Estados.Servicio);

            switch (mode)
            {
                case "Nuevo":
                    btnGuardar.Visible = true;
                    btnModificar.Visible = false;
                    break;
                case "Modificar":
                    btnGuardar.Visible = false;
                    btnModificar.Visible = true;
                    break;
                default:
                    break;
            }

        }

        private void spnPrecio_ValueChanged(object sender, EventArgs e)
        {
            txtPrecio.Texts = spnPrecio.Value.ToString();
        }

        private void txtPrecio__TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Texts is null || txtPrecio.Texts == "")
            {
                spnPrecio.Value = 0;
                return;
            }

            spnPrecio.Value = Convert.ToDecimal(txtPrecio.Texts);
        }

        private void cmbTipoDeMatenimiento_Enter(object sender, EventArgs e)
        {
            txtTipoDeMantenimiento.BorderColor = Color.DarkMagenta;
        }

        private void cmbTipoDeMatenimiento_Leave(object sender, EventArgs e)
        {
            txtTipoDeMantenimiento.BorderColor = Color.White;
        }

        private void cmbEstado_Enter(object sender, EventArgs e)
        {
            txtEstado.BorderColor = Color.DarkMagenta;
        }

        private void cmbEstado_Leave(object sender, EventArgs e)
        {
            txtEstado.BorderColor = Color.White;
        }

        private void spnPrecio_Enter(object sender, EventArgs e)
        {
            txtPrecio.BorderColor = Color.DarkMagenta;
        }

        private void spnPrecio_Leave(object sender, EventArgs e)
        {
            txtPrecio.BorderColor = Color.White;
        }

        private void txtPrecio_Enter(object sender, EventArgs e)
        {
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Texts = "0,00";
        }

       
    }
}
