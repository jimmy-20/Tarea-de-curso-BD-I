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
    public partial class FrmCliente : Form
    {
        private bool Flag;
        public FrmCliente(bool flag)
        {
            InitializeComponent();

            this.Flag = flag;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
