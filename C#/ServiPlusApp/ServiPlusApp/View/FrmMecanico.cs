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
    public partial class FrmMecanico : Form
    {
        private bool Flag;
        public FrmMecanico(bool flag)
        {
            InitializeComponent();
            pcbLogo.BackColor = Color.Transparent;

            this.Flag = flag;
            lblTransparent();
        }

        private void lblTransparent()
        {
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent;
            this.label4.BackColor = Color.Transparent;
            this.label5.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            this.flpButtons.BackColor = Color.Transparent;
        }
    }
}
