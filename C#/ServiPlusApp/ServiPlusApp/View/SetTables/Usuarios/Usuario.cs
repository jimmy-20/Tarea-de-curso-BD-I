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

namespace ServiPlusApp.View.Set_Tables.Usuarios
{
    public partial class Usuario : Form
    {
        string mode;

        public Usuario(string mode)
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

        private void Usuario_Load(object sender, EventArgs e)
        {
            cmbEspecialidad.Items.AddRange(Especialidades.Colaborador);
            cmbEstado.Items.AddRange(Estados.Usuario);
            cmbRol.Items.AddRange(Enum.GetValues(typeof(Roles)).Cast<object>().ToArray());

            if (mode.Equals("Nuevo"))
            {
                btnGuardar.Visible = true;
                btnModificar.Visible = false;
            }
            else
            {
                btnGuardar.Visible = false;
                btnModificar.Visible = true;
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            pnlUsuario.Visible = true;
            pnlDatosUsuario.Visible = false;
            txtUsername.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            pnlUsuario.Visible = false;
            pnlDatosUsuario.Visible = true;
        }

       
    }
}
