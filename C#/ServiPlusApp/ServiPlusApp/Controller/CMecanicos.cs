using Bunifu.UI.WinForms;
using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Model;
using ServiPlusApp.View.Set_Tables.Mecanicos;
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
    public class CMecanicos : IAcciones
    {
        private BunifuDataGridView TablaMecanicos;
        private Mecanico mecanico;
        public CMecanicos(BunifuDataGridView TablaMecanicos)
        {
            this.TablaMecanicos = TablaMecanicos;
        }
        public void Ver()
        {
            TablaMecanicos.DataSource = DMecanicos.Mostrar_Mecanicos();
           TablaMecanicos.Columns[0].Visible = false;
        }

        public void Agregar()
        {
            mecanico = new Mecanico("Nuevo");
            mecanico.btnGuardar.Click += new EventHandler(Insertar_Mecanico);

            mecanico.ShowDialog();
        }

        private void Insertar_Mecanico(object sender, EventArgs e)
        {
            if (SiCamposVacios() is false)
                return;

            char delimitador = ' ';

            string[] Nombres = mecanico.txtNombres.Text.Split(delimitador);
            string[] Apellidos = mecanico.txtApellidos.Text.Split(delimitador);
            string Especialidad = mecanico.txtSalario.Text;
            decimal Salario = Convert.ToDecimal(mecanico.txtSalario.Text);
            string Direccion = mecanico.txtDireccion.Text;
            string Telefono = mecanico.txtTelefono.Text;
            string Correo = mecanico.txtCorreo.Text;

            string PrimerNombre = Nombres[0];
            string SegundoNombre = Nombres[1];
            string PrimerApellido = Apellidos[0];
            string SegundoApellido = Apellidos[1];

            DMecanicos.Insertar_Mecanico(PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Especialidad, Salario, Direccion, Telefono, Correo);

        }

        public void Editar()
        {
            if (Fabrica.SiFilaSeleccionada(TablaMecanicos) is false)
            {
                return;
            }

            mecanico = new Mecanico("Modificar");

            DataGridViewRow row = TablaMecanicos.SelectedRows[0];
            mecanico.txtNombres.Text = row.Cells[1].Value.ToString();
            mecanico.txtApellidos.Text = row.Cells[2].Value.ToString();
            mecanico.cmbEspecialidad.Text = row.Cells[3].Value.ToString();
            mecanico.txtTelefono.Text = row.Cells[4].Value.ToString();
            mecanico.txtSalario.Text = row.Cells[5].Value.ToString();
            mecanico.txtDireccion.Text = row.Cells[6].Value.ToString();
            mecanico.txtCorreo.Text = row.Cells[7].Value.ToString();

            mecanico.btnModificar.Click += new EventHandler(Editar_Mecanico);
            mecanico.ShowDialog();
        }

        private void Editar_Mecanico(object sender, EventArgs e)
        {
            if (SiCamposVacios() is false)
            {
                return;
            }

            char delimitador = ' ';

            int IdMecanico = Convert.ToInt32(TablaMecanicos.SelectedRows[0].Cells[0].Value);
            string[] Nombres = mecanico.txtNombres.Text.Split(delimitador);
            string[] Apellidos = mecanico.txtApellidos.Text.Split(delimitador);
            string Especialidad = mecanico.cmbEspecialidad.Text;
            decimal Salario = Convert.ToDecimal(mecanico.txtSalario.Text);
            string Direccion = mecanico.txtDireccion.Text;
            string Telefono = mecanico.txtTelefono.Text;
            string Correo = mecanico.txtCorreo.Text;

            string PrimerNombre = Nombres[0];
            string SegundoNombre = Nombres[1];
            string PrimerApellido = Apellidos[0];
            string SegundoApellido = Apellidos[1];

            DMecanicos.Editar_Mecanico(IdMecanico, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Especialidad, Salario, Direccion, Telefono, Correo);
            Ver();
        }

        public void Estado()
        {
            if (Fabrica.SiFilaSeleccionada(TablaMecanicos) == false)
            {
                return;
            }

            DataGridViewRow row = TablaMecanicos.SelectedRows[0];

            int id = Convert.ToInt32(row.Cells[0].Value);
            DMecanicos.Cambiar_Estado_Mecanico(id);
            Ver();
        }

        public void Guardar()
        {
            throw new NotImplementedException();
        }

        public void Cancelar()
        {
            throw new NotImplementedException();
        }

        public void Buscar(string text)
        {
            TablaMecanicos.DataSource = DMecanicos.Buscar_Mecanico(text);
        }

        public static DataTable Table_Mecanicos()
        {
            return DMecanicos.Mostrar_Mecanicos();
        }

        private bool SiCamposVacios()
        {
            if (mecanico.txtNombres.Text == "" || mecanico.txtApellidos.Text == "")
            {
                MessageBox.Show("El nombre y apellido del mecanico no puede estar en blanco", "Campos Obligatorios",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (mecanico.txtTelefono.Text == "" || mecanico.txtCorreo.Text == "" || mecanico.txtSalario.Text == "")
            {
                MessageBox.Show("Rellene la información faltante", "Campos Obligatorios",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }


            return true;
        }
    }
}
