using Bunifu.UI.WinForms;
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

namespace ServiPlusApp.View.Agregar.Cliente
{
    public partial class Clientes : Form
    {

        string mode;
        public Clientes(string mode)
        {
            InitializeComponent();
            this.mode = mode;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case "Nuevo":
                    btnNuevo.Visible = true;
                    btnModificar.Visible = false;
                    break;
                case "Modificar":
                    btnNuevo.Visible = false;
                    btnModificar.Visible = true;
                    break;
                default:
                    break;
            }

            cmbEstado.Items.AddRange(Estados.Cliente);
        }
        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            BunifuDropdown dropdown = (BunifuDropdown)sender;

            dropdown.ForeColor = Color.Black;
        }
    }
}
