using ServiPlusApp.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiPlusApp.View
{
    public partial class FrmOperations : Form
    {
        public string username;
        public string fullname;
        public string rol;
        private TabControl tbcTablas;


        public FrmOperations()
        {
            InitializeComponent();
        }

        private void FrmOperations_Load(object sender, EventArgs e)
        {
            tbcTablas = new TabControl
            {
                Dock = DockStyle.Fill,
                Appearance = TabAppearance.FlatButtons,

            };

            lblUsername.Text = fullname;
            lblRol.Text = rol;
            signInAsToolStripMenuItem.Text += " " + username;
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataTable dt = CUser.Table_Usuarios();

            DataGridView dgvUsuarios = setDataGridView(dt);

            Create_TabControl_Table("Usuarios", dgvUsuarios);
        }

        private void VehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DataTable dt = CVehiculos.Table_Vehiculos();

            DataGridView dgvVehiculos = setDataGridView(dt);
        
            Create_TabControl_Table("Vehiculos", dgvVehiculos);
        }

        private void ClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            DataTable dt = CClientes.Table_Clientes();

            DataGridView dgvClientes = setDataGridView(dt);
       
            Create_TabControl_Table("Clientes", dgvClientes);
        }

        private void mecanicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = CMecanicos.Mostrar_Mecanicos();

            DataGridView dgvMecanicos = setDataGridView(dt);

            Create_TabControl_Table("Mecanicos", dgvMecanicos);
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable  dt = CServicios.Mostrar_Servicios();

            DataGridView dgvServicios = setDataGridView(dt);

            Create_TabControl_Table("Servicios", dgvServicios);
        }

        private void repuestosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataTable dt = CRepuestos.Mostrar_Repuestos();

            DataGridView dgvRepuestos = setDataGridView(dt);

            Create_TabControl_Table("Repuestos", dgvRepuestos);
        }

        private void mantenimientosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataTable dt = CMantenimientos.Mostrar_Mantenimientos();

            DataGridView dgvMantenimientos = setDataGridView(dt);

            Create_TabControl_Table("Mantenimientos", dgvMantenimientos);
        }

        private DataGridView setDataGridView(DataTable dt)
        {
            DataGridView dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                DataSource = dt
            };

            return dgv;
        }

        private void Create_TabControl_Table(string tableName, DataGridView dgv)
        {
            TabPage tbpTablas;

            if (tbcTablas.TabCount != 0)
            { 
                foreach (TabPage t in tbcTablas.TabPages)
                {
                    if (t.Text.Equals(tableName))
                    {
                        tbcTablas.SelectedTab = t;
                        return;
                    }
                }
            }

            tbpTablas = new TabPage(tableName)
            {
                AutoScroll = true
            };

            ToolStrip tlsClose = new ToolStrip
            {
                Dock = DockStyle.Top
            };
            ToolStripButton tlsbtnClose = new ToolStripButton
            {
                Text = "X",
                ForeColor = Color.Red,
            };

            tlsbtnClose.Click += TlsbtnClose_Click;

            tlsClose.Items.Add(tlsbtnClose);

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill
            };

            tableLayoutPanel.Controls.Add(tlsClose, 0, 0);
            tableLayoutPanel.Controls.Add(dgv, 0, 1);

            tbpTablas.Controls.Add(tableLayoutPanel);


            tbcTablas.TabPages.Add(tbpTablas);

            pnlTablas.Controls.Add(tbcTablas);

            tbcTablas.SelectedTab = tbpTablas;

        }

        private void TlsbtnClose_Click(object sender, EventArgs e)
        {
            tbcTablas.Controls.Remove(tbcTablas.SelectedTab);

            if (tbcTablas.TabCount == 0)
            {
                pnlTablas.BorderStyle = BorderStyle.None;
                pnlTablas.Controls.Remove(tbcTablas);
            }
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pnlTablas_ControlAdded(object sender, ControlEventArgs e)
        {
            pnlTablas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void tstxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbcTablas.TabCount==0)
            {
                return;
            }
            TabPage tp = tbcTablas.SelectedTab;

            Point p = new Point(0, 0);

            TableLayoutPanel table = (TableLayoutPanel)tp.GetChildAtPoint(p);

            DataGridView dgv = (DataGridView)table.GetControlFromPosition(0, 1);

            BindingSource bs = new BindingSource();
            bs.DataSource = dgv.DataSource;
            bs.Filter = dgv.Columns[0].HeaderText + " like '%" + tstxtSearch.Text + "%'";
            dgv.DataSource = bs;
        }

       
    }
}
