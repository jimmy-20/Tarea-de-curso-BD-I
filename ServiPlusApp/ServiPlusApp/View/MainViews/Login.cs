using ServiPlusApp.Controller;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Thread th;
        Point frmPosition;
        Boolean mouseAction;

        DataTable dt;
        private string username;
        private string password;

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - frmPosition.X, Cursor.Position.Y - frmPosition.Y);
            }
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            frmPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }


        public void OpenNewFrm()
        {
            Application.Run(new Welcome(dt.Rows[0][1].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][2].ToString()));
        }


        private void btnAllowSee_CheckedChanged(object sender, EventArgs e)
        {
            if (btnAllowSee.Checked == false)
            {
                txtPassword.PasswordChar = true;
            }
            else
            {
                txtPassword.PasswordChar = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Texts == "Username")
            {
                txtUsername.Texts = "";
                txtUsername.ForeColor = Color.White;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Texts == "")
            {
                txtUsername.Texts = "Username";
                txtUsername.ForeColor = Color.DimGray;
            }
        }



        private void txtPassword_Enter(object sender, EventArgs e)
        {
           
            if (txtPassword.Texts == "Password")
            {
                txtPassword.PasswordChar = true;
                txtPassword.Texts = "";
                txtPassword.ForeColor = Color.White;
            }
            
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Texts == "")
            {
                txtPassword.PasswordChar = false;
                txtPassword.Texts = "Password";
                txtPassword.ForeColor = Color.DimGray;
                btnLogin.Focus();
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                username = txtUsername.Texts;
                password = txtPassword.Texts;

                TextBoxs_Validations(username, password);
 
                dt = CUser.Validar_Acceso(username, password);

                if (dt != null)
                {
                    if (dt.Rows[0][0].ToString().Equals("Acceso Exitoso"))
                    {
                        th = new Thread(OpenNewFrm);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();

                        this.Close();

                        //this.Dispose();
                        //frmOperations.fullname = dt.Rows[0][1].ToString();
                        //frmOperations.rol = dt.Rows[0][2].ToString();
                        //frmOperations.username = dt.Rows[0][3].ToString();
                        //frmOperations.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Acceso Denegado al Sistema de Servicios de Mantenimiento de Vehículos", "Control de Servicios de Mantenimiento de Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Texts = "Username";
                        txtPassword.Texts = "Password";
                        txtPassword.PasswordChar = false;
                        txtPassword.ForeColor = Color.DimGray;
                        txtUsername.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("No hay conexión al servidor", "Control de Servicios de Mantenimiento de Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxs_Validations(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                txtUsername.Focus();
                throw new ArgumentException($"El username es requerido");
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                txtPassword.Focus();
                throw new ArgumentException($"La contraseña es requerida");
            }
        }

       
    }
}
