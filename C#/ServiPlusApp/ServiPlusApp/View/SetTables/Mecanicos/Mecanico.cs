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

namespace ServiPlusApp.View.Set_Tables.Mecanicos
{
    public partial class Mecanico : Form
    {
        string mode;
        public Mecanico(string mode)
        {
            InitializeComponent();
            this.mode = mode;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
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

        private void bunifuDropdown1_Enter(object sender, EventArgs e)
        {
            BunifuDropdown dropdown = (BunifuDropdown)sender;
            dropdown.BorderColor = Color.FromArgb(3, 83, 151);
        }

        private void bunifuDropdown1_Leave(object sender, EventArgs e)
        {
            BunifuDropdown dropdown = (BunifuDropdown)sender;
            dropdown.BorderColor = Color.Maroon;
        }

        private void Mecanico_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.AddRange(Estados.Mecanico);
            cmbEspecialidad.Items.AddRange(Especialidades.Mecanico);

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

        private void btnUpSalario_Click(object sender, EventArgs e)
        {
            txtSalario.Text = (Convert.ToInt32(txtSalario.Text) + 1).ToString();
        }
        private void btnSDownalario_Click(object sender, EventArgs e)
        {
            txtSalario.Text = (Convert.ToInt32(txtSalario.Text) - 1).ToString();
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            BunifuDropdown dropdown = (BunifuDropdown)sender;

            dropdown.ForeColor = Color.Black;
        }

       
    }
}
