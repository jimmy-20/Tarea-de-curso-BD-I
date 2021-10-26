using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiPlusApp.Controller;

namespace ServiPlusApp.View
{
    public partial class FrmLogin : Form
    {
        DataTable dt;
        private string username;
        private string password;
        FrmOperations frmOperations;
        public FrmDesk FrmDesk { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
            frmOperations = new FrmOperations();
        }

        private void btnSingIn_Click_1(object sender, EventArgs e)
        {
            try
            {
                username = txtUserName.Text;
                password = txtPassWord.Text;

                TextBoxs_Validations(username, password);

                dt = CUser.Validar_Acceso(username, password);

                if (dt != null)
                {
                    if (dt.Rows[0][0].ToString().Equals("Acceso Exitoso"))
                    {
                        this.Dispose();
                        frmOperations.fullname = dt.Rows[0][1].ToString();
                        frmOperations.rol = dt.Rows[0][2].ToString();
                        frmOperations.username = dt.Rows[0][3].ToString();
                        frmOperations.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Acceso Denegado al Sistema de Servicios de Mantenimiento de Vehículos", "Control de Servicios de Mantenimiento de Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserName.Text = "";
                        txtPassWord.Text = "";
                        txtUserName.Focus();
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
                txtUserName.Focus();
                throw new ArgumentException($"El username es requerido");
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                txtPassWord.Focus();
                throw new ArgumentException($"La contraseña es requerida");
            }
        }

       
    }
}
