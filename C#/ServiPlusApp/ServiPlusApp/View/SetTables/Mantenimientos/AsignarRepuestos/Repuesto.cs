using Bunifu.UI.WinForms;
using ServiPlusApp.Controller;
using ServiPlusApp.Controller.Factory;
using ServiPlusApp.View.SetTables.Mantenimientos.AsignarRepuestos.Buscador;
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

namespace ServiPlusApp.View.SetTables.Asignar
{
    public partial class Repuesto : Form
    {
        public Repuesto()
        {
            InitializeComponent();
        }

        private IAcciones formulario;
        public DataGridViewRow Row { get; set; }
        //int IdMantenimiento;
        //int IDDetMantenimiento;


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

       
        private void Repuesto_Load(object sender, EventArgs e)
        {
            formulario = Fabrica.FormController(dgvMantenimientos, "OpRepuestos");
            formulario.Ver();

            dgvServiciosAsignados.DataSource = CAsignarRepuestos.Mostrar_Mantenimientos_Servicios(1);


            dgvMantenimientos_SelectionChanged(null, null);
           
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvMantenimientos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMantenimientos.CurrentRow;

            dgvServiciosAsignados.DataSource = CAsignarRepuestos.Mostrar_Mantenimientos_Servicios(Convert.ToInt32(row.Cells[0].Value.ToString()));
           
            dgvServiciosAsignados_SelectionChanged(null, null);
        }

        private void dgvServiciosAsignados_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvServiciosAsignados.CurrentRow;

            dgvRepuestosAsignados.DataSource = CAsignarRepuestos.Mostrar_Servicios_Repuestos(Convert.ToInt32(row.Cells[0].Value.ToString()));

        }

        Buscador buscador;
        DataGridViewRow row;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscador = new Buscador();
            buscador.repuesto = this;
            buscador.ShowDialog(); 


            txtCantidad.Focus();
            txtDescripcion.Text = Row.Cells[1].Value.ToString();
            txtMarca.Text = Row.Cells[2].Value.ToString();
            txtModelo.Text = Row.Cells[3].Value.ToString();
            txtPrecio.Text = Row.Cells[4].Value.ToString();
            //txtDescuento.Text = row.Cells[1].Value.ToString();
           

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
