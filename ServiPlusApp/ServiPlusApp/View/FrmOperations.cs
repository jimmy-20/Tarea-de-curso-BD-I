using ServiPlusApp.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
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

        private DataTable dtUsuarios;
        private DataTable dtVehiculos;
        private DataTable dtClientes;
        private DataTable dtMantenimientos;
        private DataTable dtMecanicos;
        private DataTable dtRepuestos;
        private DataTable dtServicios;

        private DataGridView dgvUsuarios;
        private DataGridView dgvVehiculos;
        private DataGridView dgvClientes;
        private DataGridView dgvMantenimientos;
        private DataGridView dgvMecanicos;
        private DataGridView dgvServicios;
        private DataGridView dgvRepuestos;

        private TabPage tpUsuarios;
        private TabPage tpVehiculos;
        private TabPage tpClientes;
        private TabPage tpMantenimientos;
        private TabPage tpMecanicos;
        private TabPage tpRepuestos;
        private TabPage tpServicios;

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
            if (dtUsuarios == null)
            {
                dtUsuarios = CUser.Table_Usuarios();

                dgvUsuarios = new DataGridView()
                {
                    Dock = DockStyle.Fill,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    DataSource = dtUsuarios

                };

            }

            if (tbcTablas.Controls.Contains(tpUsuarios))
            {
                tbcTablas.SelectedTab = tpUsuarios;
                return;
            }

            tpUsuarios = new TabPage("Usuarios");

            ToolStripButton btnClose = new ToolStripButton
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.cancel,
                Text = "Cerrar tabla"
            };

            btnClose.Click += BtnClose_Click;

            ToolStrip tsUsuarios = new ToolStrip
            {
                Dock = DockStyle.Top,
            };

            tsUsuarios.Items.Add(btnClose);


            tpUsuarios.Controls.Add(dgvUsuarios);
            tpUsuarios.Controls.Add(tsUsuarios);


            tbcTablas.TabPages.Add(tpUsuarios);

            if (pnlTablas.Controls.Count == 0)
            {
                pnlTablas.Controls.Add(tbcTablas);
            }

            tbcTablas.SelectedTab = tpUsuarios;
        }

        private void VehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtVehiculos == null)
            {
                dtVehiculos = CVehiculos.Mostrar_Vehiculos();

                dgvVehiculos = new DataGridView()
                {
                    Dock = DockStyle.Fill,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    DataSource = dtVehiculos

                };

            }

            if (tbcTablas.Controls.Contains(tpVehiculos))
            {
                tbcTablas.SelectedTab = tpVehiculos;
                return;
            }

            tpVehiculos = new TabPage("Vehiculos");

            ToolStripButton btnClose = new ToolStripButton
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.cancel,
                Text = "Cerrar tabla"
            };

            btnClose.Click += BtnClose_Click;

            ToolStrip tsVehiculos = new ToolStrip
            {
                Dock = DockStyle.Top,
            };

            tsVehiculos.Items.Add(btnClose);


            tpVehiculos.Controls.Add(dgvVehiculos);
            tpVehiculos.Controls.Add(tsVehiculos);


            tbcTablas.TabPages.Add(tpVehiculos);

            if (pnlTablas.Controls.Count == 0)
            {
                pnlTablas.Controls.Add(tbcTablas);
            }

            tbcTablas.SelectedTab = tpVehiculos;
        }

        private void ClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dtClientes == null)
            {
                dtClientes = CClientes.Table_Clientes();

                dgvClientes = new DataGridView()
                {
                    Dock = DockStyle.Fill,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    DataSource = dtClientes

                };
            }


            if (tbcTablas.Controls.Contains(tpClientes))
            {
                tbcTablas.SelectedTab = tpClientes;
                return;
            }

            tpClientes = new TabPage("Clientes");

            ToolStripButton btnClose = new ToolStripButton
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.cancel,
                Text = "Cerrar tabla"
            };

            btnClose.Click += BtnClose_Click;

            ToolStrip tsClientes = new ToolStrip
            {
                Dock = DockStyle.Top,
            };

            tsClientes.Items.Add(btnClose);


            tpClientes.Controls.Add(dgvClientes);
            tpClientes.Controls.Add(tsClientes);


            tbcTablas.TabPages.Add(tpClientes);

            if (pnlTablas.Controls.Count == 0)
            {
                pnlTablas.Controls.Add(tbcTablas);
            }

            tbcTablas.SelectedTab = tpClientes;
        }

        private void mecanicosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dtMecanicos == null)
            {
                dtMecanicos = CMecanicos.Mostrar_Mecanicos();

                dgvMecanicos = new DataGridView()
                {
                    Dock = DockStyle.Fill,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    DataSource = dtMecanicos

                };

            }


            if (tbcTablas.Controls.Contains(tpMecanicos))
            {
                tbcTablas.SelectedTab = tpMecanicos;
                return;
            }


            tpMecanicos = new TabPage("Mecanicos");

            ToolStripButton btnClose = new ToolStripButton
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.cancel,
                Text = "Cerrar tabla"
            };

            btnClose.Click += BtnClose_Click;

            ToolStrip tsMecanicos = new ToolStrip
            {
                Dock = DockStyle.Top,
            };

            tsMecanicos.Items.Add(btnClose);


            tpMecanicos.Controls.Add(dgvMecanicos);
            tpMecanicos.Controls.Add(tsMecanicos);


            tbcTablas.TabPages.Add(tpMecanicos);

            if (pnlTablas.Controls.Count == 0)
            {
                pnlTablas.Controls.Add(tbcTablas);
            }

            tbcTablas.SelectedTab = tpMecanicos;
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtServicios == null)
            {
                dtServicios = CServicios.Mostrar_Servicios();

                dgvServicios = new DataGridView()
                {
                    Dock = DockStyle.Fill,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    DataSource = dtServicios

                };

            }

            if (tbcTablas.Controls.Contains(tpServicios))
            {
                tbcTablas.SelectedTab = tpServicios;
                return;
            }

            tpServicios = new TabPage("Servicios");

            ToolStripButton btnClose = new ToolStripButton
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.cancel,
                Text = "Cerrar tabla"
            };

            btnClose.Click += BtnClose_Click;

            ToolStrip tsServicios = new ToolStrip
            {
                Dock = DockStyle.Top,
            };

            tsServicios.Items.Add(btnClose);


            tpServicios.Controls.Add(dgvServicios);
            tpServicios.Controls.Add(tsServicios);


            tbcTablas.TabPages.Add(tpServicios);

            if (pnlTablas.Controls.Count == 0)
            {
                pnlTablas.Controls.Add(tbcTablas);
            }

            tbcTablas.SelectedTab = tpServicios;
        }

        private void repuestosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dtRepuestos == null)
            {
                dtRepuestos = CRepuestos.Mostrar_Repuestos();

                dgvRepuestos = new DataGridView()
                {
                    Dock = DockStyle.Fill,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    DataSource = dtRepuestos

                };
            }

            if (tbcTablas.Controls.Contains(tpRepuestos))
            {
                tbcTablas.SelectedTab = tpRepuestos;
                return;
            }


            tpRepuestos = new TabPage("Repuestos");

            ToolStripButton btnClose = new ToolStripButton
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.cancel,
                Text = "Cerrar tabla"
            };

            btnClose.Click += BtnClose_Click;

            ToolStrip tsRepuestos = new ToolStrip
            {
                Dock = DockStyle.Top,
            };

            tsRepuestos.Items.Add(btnClose);


            tpRepuestos.Controls.Add(dgvRepuestos);
            tpRepuestos.Controls.Add(tsRepuestos);


            tbcTablas.TabPages.Add(tpRepuestos);

            if (pnlTablas.Controls.Count == 0)
            {
                pnlTablas.Controls.Add(tbcTablas);
            }
            tbcTablas.SelectedTab = tpRepuestos;
        }

        private void mantenimientosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dtMantenimientos == null)
            {
                dtMantenimientos = CMantenimientos.Mostrar_Mantenimientos();

                dgvMantenimientos = new DataGridView()
                {
                    Dock = DockStyle.Fill,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
                    DataSource = dtMantenimientos

                };
            }

            if (tbcTablas.Controls.Contains(tpMantenimientos))
            {
                tbcTablas.SelectedTab = tpMantenimientos;
                return;
            }

            tpMantenimientos = new TabPage("Mantenimientos");

            ToolStripButton btnClose = new ToolStripButton
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.cancel,
                Text = "Cerrar tabla"
            };

            btnClose.Click += BtnClose_Click;

            ToolStrip tsMantenimientos = new ToolStrip
            {
                Dock = DockStyle.Top,
            };

            tsMantenimientos.Items.Add(btnClose);


            tpMantenimientos.Controls.Add(dgvMantenimientos);

            tpMantenimientos.Controls.Add(tsMantenimientos);


            tbcTablas.TabPages.Add(tpMantenimientos);

            if (pnlTablas.Controls.Count == 0)
            {
                pnlTablas.Controls.Add(tbcTablas);
            }

            tbcTablas.SelectedTab = tpMantenimientos;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            tbcTablas.TabPages.Remove(tbcTablas.SelectedTab);

            if (tbcTablas.TabPages.Count == 0)
            {
                pnlTablas.Controls.Remove(tbcTablas);
                return;
            }
            tbcTablas.SelectedIndex = tbcTablas.TabPages.Count - 1;
        }

        //private DataGridView setDataGridView(DataTable dt)
        //{

        //    if (dt.TableName.Equals("Mostrar_Mantenimientos") || dt.TableName.Equals("Mostrar_Repuestos"))
        //    {
        //        DataGridView dgv = new DataGridView
        //        {
        //            Dock = DockStyle.Fill,
        //            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
        //            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells,
        //            DataSource = dt
        //        };
        //        return dgv;
        //    }
        //    else
        //    {
        //        DataGridView dgv = new DataGridView
        //        {
        //            Dock = DockStyle.Fill,
        //            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
        //            DataSource = dt
        //        };
        //        return dgv;
        //    }
        //}

        //private void Create_TabControl_Table(string tableName, DataGridView dgv)
        //{
        //    TabPage tbpTablas;

        //    if (tbcTablas.TabCount != 0)
        //    {
        //        foreach (TabPage t in tbcTablas.TabPages)
        //        {
        //            if (t.Text.Equals(tableName))
        //            {
        //                tbcTablas.SelectedTab = t;
        //                return;
        //            }
        //        }
        //    }

        //    tbpTablas = new TabPage(tableName)
        //    {
        //        AutoScroll = true
        //    };

        //    ToolStrip tlsClose = new ToolStrip
        //    {
        //        Dock = DockStyle.Top
        //    };

        //    ToolStripButton tlsbtnClose = new ToolStripButton
        //    {
        //        Text = "Cerrar tabla",
        //        ForeColor = Color.Red,
        //        Image = Properties.Resources.cancel,
        //        DisplayStyle = ToolStripItemDisplayStyle.Image
        //    };

        //    tlsbtnClose.Click += TlsbtnClose_Click;

        //    tlsClose.Items.Add(tlsbtnClose);


        //    TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
        //    {
        //        Dock = DockStyle.Fill
        //    };

        //    tableLayoutPanel.Controls.Add(tlsClose, 0, 0);
        //    tableLayoutPanel.Controls.Add(dgv, 0, 1);

        //    tbpTablas.Controls.Add(tableLayoutPanel);


        //    tbcTablas.TabPages.Add(tbpTablas);

        //    pnlTablas.Controls.Add(tbcTablas);

        //    tbcTablas.SelectedTab = tbpTablas;

        //}

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbcTablas.TabPages.Count == 0)
            {
                return;
            }


            if (tbcTablas.SelectedTab == tpUsuarios)
            {
                if (dgvUsuarios == null)
                {
                    return;
                }
                dgvUsuarios.DataSource = CBuscarUsuario.Buscar_Usuario(this.txtSearch.Text);
            }

            if (tbcTablas.SelectedTab == tpClientes)
            {
                if (dgvClientes == null)
                {
                    return;
                }
                dgvClientes.DataSource = CBuscarCliente.Buscar_Cliente(this.txtSearch.Text);
            }

            if (tbcTablas.SelectedTab == tpMecanicos)
            {
                if (dgvMecanicos == null)
                {
                    return;
                }
                dgvMecanicos.DataSource = CBuscarMecanico.Buscar_Mecanico(this.txtSearch.Text);
            }

            if (tbcTablas.SelectedTab == tpServicios)
            {
                if (dgvServicios == null)
                {
                    return;
                }
                dgvServicios.DataSource = CBuscarServicio.Buscar_Servicio(this.txtSearch.Text);
            }

            if (tbcTablas.SelectedTab == tpVehiculos)
            {
                if (dgvVehiculos == null)
                {
                    return;
                }
                dgvVehiculos.DataSource = CBuscarVehiculo.Buscar_vehiculo(this.txtSearch.Text);
            }

            if (tbcTablas.SelectedTab == tpRepuestos)
            {
                if (dgvRepuestos == null)
                {
                    return;
                }
                dgvRepuestos.DataSource = CBuscarRepuesto.Buscar_Repuesto(this.txtSearch.Text);
            }

            if (tbcTablas.SelectedTab == tpMantenimientos)
            {
                if (dgvMantenimientos == null)
                {
                    return;
                }
                dgvMantenimientos.DataSource = CBuscarMantenimiento.Buscar_Mantenimiento(this.txtSearch.Text);
            }


        }

       
    }
}
