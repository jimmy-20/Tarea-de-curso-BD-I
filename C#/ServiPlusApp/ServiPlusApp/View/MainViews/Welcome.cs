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
    public partial class Welcome : Form
    {
        public Welcome(string fullname,string username, string rol,string especialidad)
        {
            InitializeComponent();
            this.fullname = fullname;
            this.username = username;
            this.rol = rol;
            this.especialidad = especialidad;
        }

        Thread th;
        Point frmPosition;
        Boolean mouseAction;
        string fullname;
        string username;
        string rol;
        string especialidad;

        float count = 0;


        private void Welcome_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - frmPosition.X, Cursor.Position.Y - frmPosition.Y);
            }
        }
        private void Welcome_MouseDown(object sender, MouseEventArgs e)
        {
            frmPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }

        private void Welcome_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            lblFullname.Text = fullname;
            this.Opacity = 0;
            timer1.Enabled = true;
        }

        public void OpenNewFrm()
        {
            Application.Run(new Operaciones(fullname,username,rol,especialidad));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                timer1.Stop();
                timer2.Enabled = true;
                zeroitProgressBarCircular1.Value =0;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (count <10)
            {
                zeroitProgressBarCircular1.Value += 4;
            }
            else
            {
                timer2.Stop();
                th = new Thread(OpenNewFrm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();


            }

            count +=0.5F;

        }

    }
}
