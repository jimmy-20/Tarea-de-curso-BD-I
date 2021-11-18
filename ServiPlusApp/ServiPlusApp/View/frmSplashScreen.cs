using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiPlusApp.View
{
    public partial class frmSplashScreen : Form
    {
        Point frmPisition;
        Boolean mouseAction;
        Thread th;
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_MouseDown(object sender, MouseEventArgs e)
        {
            frmPisition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }

        private void frmSplashScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - frmPisition.X, Cursor.Position.Y - frmPisition.Y);
            }
        }

        private void frmSplashScreen_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value<100)
            {
                progressBar1.Value = progressBar1.Value + 10;
                label2.Text ="CARGANDO EL SISTEMA AL "+progressBar1.Value+" %";
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("Carga Completa");
                this.Close();
               
            }
        }

        private void frmSplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            th = new Thread(OpenForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void OpenForm()
        {
            Application.Run(new FrmDesk());
        }
    }
}
