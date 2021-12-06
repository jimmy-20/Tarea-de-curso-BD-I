using ServiPlusApp.Controller.Factory;
using ServiPlusApp.View.SetTables.Asignar;
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

namespace ServiPlusApp.View.SetTables.Mantenimientos.AsignarRepuestos.Buscador
{
    public partial class Buscador : Form
    {
        public Buscador()
        {
            InitializeComponent();
        }

        public Repuesto repuesto { get; set; }

        private IAcciones formulario;

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

        private void Buscador_Load(object sender, EventArgs e)
        {
            formulario = Fabrica.FormController(dgvBuscador,"Repuestos");
            formulario.Ver();
        }

        private void btnClosePanelBuscador_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            formulario.Buscar(txtSearch.Text);
        }

        private void dgvBuscador_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            repuesto.Row = dgvBuscador.CurrentRow;
            this.Close();
        }
    }
}
