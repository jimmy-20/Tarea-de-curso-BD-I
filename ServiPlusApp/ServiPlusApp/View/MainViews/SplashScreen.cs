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

    public partial class SplashScreen : Form
    {
        Thread th;
        System.Drawing.Point frmPosition;
        Boolean mouseAction;
        float count = 0;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            this.Opacity = 0;
        }

        private void SplashScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - frmPosition.X, Cursor.Position.Y - frmPosition.Y);
            }
        }
        private void SplashScreen_MouseDown(object sender, MouseEventArgs e)
        {
            frmPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }

        private void SplashScreen_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                timer2.Stop();
                timer1.Enabled = true;

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == 5)
            {
                timer1.Stop(); 
            }

            if (count == 4)
            {
                timer3.Enabled = true;
            }

            count += 0.5F; 
        }



        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.05;
            }
            else
            {
                timer3.Stop();
                this.Close();

            }
        }


        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            th = new Thread(OpenNewFrm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }


        public void OpenNewFrm()
        {
            Application.Run(new Login());
        }


    }
}
