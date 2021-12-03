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

namespace ServiPlusApp.View.Set_Tables.Repuestos
{
    public partial class Repuesto : Form
    {
        string mode;
        public Repuesto(string mode)
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

        private void Repuesto_Load(object sender, EventArgs e)
        {
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
