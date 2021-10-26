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
using ServiPlusApp.Enums;

namespace ServiPlusApp.View
{
    public partial class FrmSingUp : Form
    {
        public FrmSingUp()
        {
            InitializeComponent();

        }
        DataTable dt;

        private void FrmSingUp_Load(object sender, EventArgs e)
        {
            cmbEspecialidad.Items.AddRange(Especialidades.especialidades);
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.SelectedIndex = 0;

            cmbRol.Items.AddRange(Enum.GetValues(typeof(Roles)).Cast<Object>().ToArray());
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.SelectedIndex = 0;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {

                TextBoxs_Validations(txtNombre.Text, txtApellido.Text, mtbTelefono.Text, txtUsername.Text, txtPassword.Text);

                dt = CUser.Validar_Creacion_Usuario(txtUsername.Text, txtPassword.Text);
               
                if (dt != null)
                {
                    if (dt.Rows[0][0].ToString().Equals("Acceso Denegado"))
                    {
                        txtPassword.Text = "";
                        txtUsername.Text = "";
                        txtUsername.Focus();
                        throw new ArgumentException($"El username insertado ya existe");
                    }
                }
                else
                {
                    MessageBox.Show("No hay conexión al servidor", "Control de Servicios de Mantenimiento de Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dt = CUser.Crear_Usuario(txtNombre.Text, txtApellido.Text, mtbTelefono.Text, cmbEspecialidad.SelectedItem.ToString(), txtUsername.Text, txtPassword.Text, cmbRol.SelectedItem.ToString());

                if (dt != null)
                {
                    MessageBox.Show(dt.Rows[0][0].ToString());
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error en la creacion del nuevo usuario nuevo usuario");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TextBoxs_Validations(string nombres, string apellido, string telefono, string username, string password)
        {
            if (string.IsNullOrWhiteSpace(nombres))
            {
                txtNombre.Focus();
                throw new ArgumentException($"El nombre es requerido");
            }
            if (string.IsNullOrWhiteSpace(apellido))
            {
                txtApellido.Focus();
                throw new ArgumentException($"El apellido es requerido");
            }

            if (string.IsNullOrWhiteSpace(telefono))
            {
                mtbTelefono.Focus();
                throw new ArgumentException($"El numero de telefono es requerido");
            }
            if (string.IsNullOrWhiteSpace(username))
            {
                txtUsername.Focus();
                throw new ArgumentException($"El username es requerido");
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                txtPassword.Focus();
                throw new ArgumentException($"La contraseña es requerido");
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 1)
            {
                txtNombre.Text = txtNombre.Text.ToUpper();
                txtNombre.SelectionStart = txtNombre.Text.Length;
            }
        }
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text.Length == 1)
            {
                txtApellido.Text = txtApellido.Text.ToUpper();
                txtApellido.SelectionStart = txtApellido.Text.Length;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.Focus();
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                txtApellido.Focus();
            }
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Focus();
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
