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
        public string tableName { get; set; }
   
        private IAcciones formulario;

        public ShowTable()
        {
            InitializeComponent();
        }

        #region Mostrar Tablas
        private void TablaUsuarios_Load(object sender, EventArgs e)
        {
            lblTableName.Text = tableName;

            formulario = Fabrica.FormController(this.dgvTablas, tableName);

            
            formulario.Ver();
        }

        public void LoadForm(string tableName)
        {
            lblTableName.Text = tableName;

            switch (tableName)
            {
                case "Mecanicos":
                    btnSetState.Visible = false;
                    break;
                case "OpMantenimientos":
                    btnSetState.Visible = false;
                    break;
                default:
                    btnSetState.Visible = true;
                    break;
            }

            formulario = Fabrica.FormController(this.dgvTablas, tableName);
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
