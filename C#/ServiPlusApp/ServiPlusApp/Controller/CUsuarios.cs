using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Model;
using ServiPlusApp.View.Set_Tables.Usuarios;
using ServiPlusApp.View.Tablas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiPlusApp.Controller
{
    public class CUsuarios : IAcciones 
    {
        private ShowTable FrmUsuario;
        private Usuario usuario;
        private int IdUsuario;
        private int IdColaborador;
        public CUsuarios(ShowTable FrmUsuario)
        {
            this.FrmUsuario = FrmUsuario;
            this.FrmUsuario.btnEditar.Visible = false;
        }

        public void Agregar()
        {
            usuario = new Usuario("Nuevo");
            usuario.btnGuardar.Click += new EventHandler(Insertar_Usuario);
            usuario.ShowDialog();
        }

        private void Insertar_Usuario(object sender, EventArgs e)
        {

            if (SiCamposVacios() is false)
            {
                return;
            }


            string PrimerNombre = usuario.txtNombres.Texts;
            string PrimerApellido = usuario.txtApellidos.Texts;
            string Telefono = usuario.txtTelefono.Texts;
            string Especialidad = usuario.cmbEspecialidad.Text;
            string UserName = usuario.txtUsername.Texts;
            string Contraseña = usuario.txtContraseña.Texts;
            string Rol = usuario.cmbEspecialidad.Text;


            DUser.Crear_Usuario(PrimerNombre,PrimerApellido,Telefono,Especialidad,UserName,Contraseña,Rol);
        }

        public void Buscar(string text)
        {
            FrmUsuario.DgvTablas.DataSource = DUser.Buscar_Usuario(text);
        }

        public void Cancelar()
        {
            usuario.btnClose.Click += new EventHandler(FrmClose);
            usuario = null;
        }

        private void FrmClose(object sender, EventArgs e)
        {
            usuario.Close();
        }

        public void Editar()
        {
            //NO
        }

        public void Estado()
        {
            if (Fabrica.SiFilaSeleccionada(FrmUsuario.DgvTablas) == false)
            {
                return;
            }

            int id = Convert.ToInt32(FrmUsuario.DgvTablas.SelectedRows[0].Cells[0].Value);
            DUser.Cambiar_Estado_Usuario(id);

            Ver();
        }

        public void Guardar()
        {
            throw new NotImplementedException();
        }

        public void Ver()
        {
            FrmUsuario.DgvTablas.DataSource = DUser.Tabla_Usuarios();
            FrmUsuario.DgvTablas.Columns[0].Visible = false;
            FrmUsuario.DgvTablas.Columns[1].Visible = false;
        }

        public static DataTable Validar_Acceso(string username, string password)
        {
            return DUser.Validar_Acceso(username, password);
        }

        public static DataTable Validar_Creacion_Usuario(string username, string password)
        {
            return DUser.Validar_Creacion_Usuario(username, password);
        }

        public static DataTable Crear_Usuario(string nombre, string apellido, string telefono, string especialidad, string username, string passWord, string rol)
        {
            return DUser.Crear_Usuario(nombre, apellido, telefono, especialidad, rol, username, passWord);
        }

        public static DataTable Table_Usuarios()
        {
            return DUser.Tabla_Usuarios();
        }

        public static DataTable Buscar_Usuario(string dato)
        {
            return DUser.Buscar_Usuario(dato);
        }

        public bool SiCamposVacios()
        {

            if (usuario.txtNombres.Texts == "" || usuario.txtApellidos.Texts == "")
            {
                MessageBox.Show("EL nombre no puede quedar en blanco", "Campos obligatorios",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (usuario.txtUsername.Texts == "")
            {
                MessageBox.Show("Nombre de usuario en blanco", "Campos obligatorios",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (usuario.txtContraseña.Texts == "")
            {
                MessageBox.Show("Ingrese su contraseña", "Campos obligatorios",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (usuario.cmbEspecialidad.Text == "" || usuario.cmbRol.Text == "") {
                MessageBox.Show("Complete los campos vacios", "Campos obligatorios",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }

            return true;
        }
    }
}
