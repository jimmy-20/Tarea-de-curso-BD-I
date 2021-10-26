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
    public partial class FrmDesk : Form
    {
        public FrmDesk()
        {
            InitializeComponent();
        }
        FrmLogin frmLogin;
        FrmSingUp frmSingUp;

        private void tsbtnSignIn_Click(object sender, EventArgs e)
        {
            frmLogin = new FrmLogin();
            frmLogin.FrmDesk = this;
            frmLogin.ShowDialog();
        }

        private void tsbtnSignUp_Click(object sender, EventArgs e)
        {
            frmSingUp = new FrmSingUp();
            frmSingUp.ShowDialog();
        }
    }
}
