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

namespace ServiPlusApp.View.SubViews
{
    public partial class UserMenuStrip : System.Windows.Forms.UserControl
    {
        string fullname;
        string username;
        string rol;
        string especialidad;
        
        Thread th;

        public UserMenuStrip(string fullname, string especialidad)
        {
            InitializeComponent();
            this.fullname = fullname;
           // this.username = username;
           // this.rol = rol;
            this.especialidad = especialidad;
        }

        private void UserMenuStrip_Load(object sender, EventArgs e)
        {
            btnUsuario.Text = fullname;
            btnEspecialidad.Text = especialidad;

            bunifuToolTip1.SetToolTip(btnUsuario, fullname);
            bunifuToolTip1.SetToolTip(btnEspecialidad, especialidad);
            bunifuToolTip1.SetToolTip(btnSet, fullname + Environment.NewLine + "Ha iniciado sesión");
            bunifuToolTip1.SetToolTip(pbUsuario, fullname + Environment.NewLine + "Ha iniciado sesión");
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            th = new Thread(OpenNewFrm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Application.Exit();

        }

        public void OpenNewFrm()
        {
            Application.Run(new Login());
        }
    }
}
