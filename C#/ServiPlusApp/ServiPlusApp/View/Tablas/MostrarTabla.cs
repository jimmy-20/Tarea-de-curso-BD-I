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
    public partial class MostrarTabla : Form
    {
        String tableName;
        public DataGridView DgvTablas { get; set; }
        private IAcciones formulario;

        public MostrarTabla(string TableName)
        {
            InitializeComponent();
            this.tableName = TableName;
            DgvTablas = dgvTablas;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Mostrar Tablas
        private void TablaUsuarios_Load(object sender, EventArgs e)
        {
            formulario = Fabrica.FormController(this,tableName);
            formulario.Ver();
        }

        #endregion

        #region Buscar en Tablas
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (dgvTablas == null)
            {
                return;
            }
            formulario.Buscar(txtSearch.Text);
        }

        #endregion

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            formulario.Agregar();
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            formulario.Estado();
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
