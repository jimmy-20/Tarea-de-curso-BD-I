using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using ServiPlusApp.Controller;
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

        bool btnCtsEstado = false;
        bool btnSeEstado = false;
        bool btnReEstado = false;
        bool btnMeEstado = false;

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
            this.WindowState = FormWindowState.Minimized;
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
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

            

            

            cmbEstado.Items.AddRange(Estados.Mantenimiento);
        }

        private void btnCtsBuscar_MouseMove(object sender, EventArgs e)
        {
            BunifuThinButton2 btn = (BunifuThinButton2)sender;

            btn.Size = new Size(155, 50);
        }

        private void btnCtsBuscar_MouseLeave(object sender, EventArgs e)
        {
            BunifuThinButton2 btn = (BunifuThinButton2)sender;
            btn.Size = new Size(150, 45);
        }


        private void bunifuTextBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void bunifuTextBox3_Leave(object sender, EventArgs e)
        {

        }

        private void cmbEstado_MouseMove(object sender, MouseEventArgs e)
        {
            BunifuDropdown cmb = (BunifuDropdown)sender;

            cmb.Font = new Font(cmb.Font.FontFamily,14);

            txtEstado.Size = new Size(169,43);

        }

        private void cmbEstado_MouseLeave(object sender, EventArgs e)
        {
            BunifuDropdown cmb = (BunifuDropdown)sender;

            cmb.Font = new Font(cmb.Font.FontFamily, 12);
            txtEstado.Size = new Size(166, 40);
        }

       

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEstado.ForeColor = Color.Black;
        }

        private void btnCtsBuscar_Click(object sender, EventArgs e)
        {
            pnlSeleccionarDatos2.Visible = true;
            pnlDatosMan2.Visible = false;
            
            dgvDatos2.DataSource = CClientes.Table_Clientes();

            btnCtsEstado = true;
             btnSeEstado = false;
             btnReEstado = false;
             btnMeEstado = false;

        }

        private void btnSeBuscar_Click(object sender, EventArgs e)
        {
            pnlSeleccionarDatos2.Visible = true;
            pnlDatosMan2.Visible = false;

            dgvDatos2.DataSource = CServicios.Mostrar_Servicios();

            btnCtsEstado = false;
            btnSeEstado = true;
            btnReEstado = false;
            btnMeEstado = false;
        }

        private void btnReBucar_Click(object sender, EventArgs e)
        {
            pnlSeleccionarDatos1.Visible = true;
            pnlDatosMan1.Visible = false;

            dgvDatos1.DataSource = CRepuestos.Table_Repuestos();

            btnCtsEstado = false;
            btnSeEstado = false;
            btnReEstado = true;
            btnMeEstado = false;
        }

        private void btnMeBuscar_Click(object sender, EventArgs e)
        {
            pnlSeleccionarDatos1.Visible = true;
            pnlDatosMan1.Visible = false;

            dgvDatos1.DataSource = CMecanicos.Mostrar_Mecanicos();

            btnCtsEstado = false;
            btnSeEstado = false;
            btnReEstado = false;
            btnMeEstado = true;
        }

        private void btnVolver1_Click(object sender, EventArgs e)
        {
            pnlSeleccionarDatos1.Visible = false;
            pnlDatosMan1.Visible = true;
        }

        private void btnVolver2_Click(object sender, EventArgs e)
        {
            pnlSeleccionarDatos2.Visible = false;
            pnlDatosMan2.Visible = true;
        }

        DataTable dtServicios = null;
        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BunifuDataGridView dgv = (BunifuDataGridView)sender;

            DataGridViewRow dr = null;


            if (dgv.SelectedRows.Count > 0)
            {
                dr = dgv.CurrentRow;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }



            if (btnCtsEstado)
            {
                


            }
            else if (btnSeEstado)
            {

                if (dtServicios == null)
                {
                    dtServicios = new DataTable();
                    
                    dtServicios.Columns.Add("Descripcion");
                    dtServicios.Columns.Add("Precio");
                    dtServicios.Columns.Add("Tipo de mantenimiento");
                }


                DataRow row = dtServicios.NewRow();
                row["Descripcion"] = dr.Cells[1].Value.ToString();
                row["Precio"] = dr.Cells[2].Value.ToString();
                row["Tipo de mantenimiento"] = dr.Cells[3].Value.ToString();

                dtServicios.Rows.Add(row);
                
                dgvServiciosAsignados.DataSource = dtServicios;

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.Name = "Quitar";
                    button.HeaderText = "Quitar";
                    //button.Text = "X";
                    button.UseColumnTextForButtonValue = true; //dont forget this line
                    this.dgvServiciosAsignados.Columns.Add(button);
                }

                btnVolver2_Click(btnVolver2, null);

            }
            else if (btnMeEstado)
            {



            }else if (btnReEstado)
            {


            }

            //if (txtSearch.Text == "")
            //{
            //    txtNombres.Texts = dr.Cells[1].Value.ToString();
            //    txtApellidos.Texts = dr.Cells[2].Value.ToString();
            //    txtTelefono.Texts = dr.Cells[3].Value.ToString();
            //    txtCorreo.Texts = dr.Cells[5].Value.ToString();
            //    txtDireccion.Texts = dr.Cells[4].Value.ToString();
            //    txtEstado.Texts = dr.Cells[6].Value.ToString();
            //}
            //else
            //{
            //    txtNombres.Texts = dr.Cells[0].Value.ToString();
            //    txtApellidos.Texts = dr.Cells[1].Value.ToString();
            //    txtTelefono.Texts = dr.Cells[2].Value.ToString();
            //    txtCorreo.Texts = dr.Cells[4].Value.ToString();
            //    txtDireccion.Texts = dr.Cells[3].Value.ToString();
            //    txtEstado.Texts = dr.Cells[5].Value.ToString();
            //}

            //btnVolver1_Click(btnVolver1, null);

            //txtMarca.Focus();


        }
        void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            DataGridView dgv = (DataGridView)sender; 
            if (e.RowIndex == dgv.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgv.Columns["Quitar"].Index)
            {
                var image = Properties.Resources.cerrar; //An image
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var x = e.CellBounds.Left + (e.CellBounds.Width - image.Width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - image.Height) / 2;
                e.Graphics.DrawImage(image, new Point(x, y));

                e.Handled = true;
            }
        }

    }
}
