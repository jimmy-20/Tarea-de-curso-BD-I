using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiPlusApp.View.SubViews
{
    public partial class MainDesk : UserControl
    {
        public MainDesk()
        {
            InitializeComponent();
        }

        public Panel GetPnlContenedor() => pnlContenedor;
        public Panel GetPnlDateTime() => pnlDateTime;
        public Label GetLblHora()=> lblHora;
        public Label GetLblFecha()=> lblFecha;
        public PictureBox GetPbServiPlus()=> pbServiplus;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void MainDesk_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
