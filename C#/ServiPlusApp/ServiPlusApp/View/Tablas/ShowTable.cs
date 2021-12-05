using ServiPlusApp.Controller;
using ServiPlusApp.Controller.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiPlusApp.View.Tablas
{
    public partial class ShowTable : Form
    {
        String tableName;
        public DataGridView DgvTablas { get; set; }
        private IAcciones formulario;

        public ShowTable(string TableName)
        {
            InitializeComponent();
            this.tableName = TableName;
            DgvTablas = dgvTablas;
        }

        #region Mostrar Tablas
        private void TablaUsuarios_Load(object sender, EventArgs e)
        {
            lblTableName.Text = tableName;

            formulario = Fabrica.FormController(this, tableName);
            formulario.Ver();
        }

        #endregion

        #region Buscar en Tablas
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length != 0)
            {
                btnLimpiarSearch.Visible = true;
            }
            else
            {
                btnLimpiarSearch.Visible = false;
            }

            if (dgvTablas == null)
            {
                return;
            }
            formulario.Buscar(txtSearch.Text);
        }

        #endregion


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            btnLimpiarSearch.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            formulario.Agregar();
        }

        private void btnSetState_Click(object sender, EventArgs e)
        {
            formulario.Estado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formulario.Editar();
        }

      
    }
}
