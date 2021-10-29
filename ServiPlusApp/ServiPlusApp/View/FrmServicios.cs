using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiPlusApp.View
{
    public partial class FrmServicios : Form
    {
        private bool Flag;
        public FrmServicios(bool flag)
        {
            InitializeComponent();

            this.Flag = flag;
        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;

            lblDescripcion.BackColor = Color.Transparent;
            lblMantenimiento.BackColor = Color.Transparent;
            lblTipo.BackColor = Color.Transparent;

            flpButtons.BackColor = Color.Transparent;
            panel1.BackColor = Color.Transparent;
        }
    }
}
