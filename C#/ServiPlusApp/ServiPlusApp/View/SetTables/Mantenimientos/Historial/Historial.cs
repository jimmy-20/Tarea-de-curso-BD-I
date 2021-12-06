using Bunifu.UI.WinForms.BunifuButton;
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

namespace ServiPlusApp.View.SetTables.Mantenimientos.Historial
{
    public partial class Historial : Form
    {
        int IdVehiculo; //este es el id del vehiculo al cual quieres ver todos sus repuestos y servicios
        public Historial(int IdVehiculo)
        {
            InitializeComponent();
            this.IdVehiculo = IdVehiculo;
        }

        private IAcciones formulario;

        private int borderSize = 3;
        private Size formSize;

        private void Historial_Load(object sender, EventArgs e)
        {
            btnTabServicios_Click(null,null);
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

        #region Eventos btnCambio de Historial
        private void btnTabRepuestos_Click(object sender, EventArgs e)
        {
            btnTabRepuestos.Size = new Size(184, 47);
            btnTabServicios.Size = new Size(182, 45);
            //Aqui debes poner en practica el metodo que te haga el PA para buscar esos repuestos por el idVehiculo

        }

        private void btnTabServicios_Click(object sender, EventArgs e)
        {
            btnTabRepuestos.Size = new Size(182, 45);
            btnTabServicios.Size = new Size(184, 47);
            //Aqui debes poner en practica el metodo que te haga el PA para buscar esos servicios por el idVehiculo
        }
        private void btnTabRepuestos_MouseMove(object sender, MouseEventArgs e)
        {
            btnTabRepuestos.Size = new Size(184, 47);

        }
        private void btnTabRepuestos_MouseLeave(object sender, EventArgs e)
        {
            btnTabRepuestos.Size = new Size(182, 45);
        }

        private void btnTabServicios_MouseMove(object sender, MouseEventArgs e)
        {
            btnTabServicios.Size = new Size(184, 47);
        }

        private void btnTabServicios_MouseLeave(object sender, EventArgs e)
        {
            btnTabServicios.Size = new Size(182, 45);
        }
        #endregion

        #region Botones de Ventana

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }




        #endregion

       
    }
}
