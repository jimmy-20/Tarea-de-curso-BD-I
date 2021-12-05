using Bunifu.UI.WinForms;
using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Model;
using ServiPlusApp.View.Set_Tables.Servicios;
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
    public class CServicios : IAcciones 
    {
        private BunifuDataGridView TablaServicios;
        private Servicio servicio;
        public CServicios(BunifuDataGridView TablaServicios)
        {
            this.TablaServicios = TablaServicios;
        }

        public static DataTable Mostrar_Servicios()
        {
            return DServicios.Mostrar_Servicios();
        }

        public static DataTable Buscar_Servicio(string dato)
        {
            return DServicios.Buscar_Servicio(dato);
        }

        public void Ver()
        {
            TablaServicios.DataSource = DServicios.Mostrar_Servicios();
            TablaServicios.Columns[0].Visible = false;
        }

        public void Agregar()
        {
            this.servicio = new Servicio("Nuevo");
            servicio.btnGuardar.Click += new EventHandler(Insertar_Servicio);
            servicio.ShowDialog();
        }

        private void Insertar_Servicio(object sender, EventArgs e)
        {
            if (SiCamposVacios() is false)
            {
                return;
            }
            string Descripcion = servicio.txtDescripcion.Texts;
            decimal Precio = Convert.ToDecimal(servicio.txtPrecio.Texts);
            string Tipo = servicio.cmbTipoDeMatenimiento.Text;

            DServicios.Insertar_Servicio(Descripcion, Precio, Tipo);
        }

        public void Editar()
        {
            if (Fabrica.SiFilaSeleccionada(TablaServicios) is false)
            {
                return;
            }
            this.servicio = new Servicio("Modificar");

            DataGridViewRow row = TablaServicios.SelectedRows[0];

            this.servicio.txtDescripcion.Texts = row.Cells[1].Value.ToString();
            this.servicio.txtPrecio.Texts = row.Cells[2].Value.ToString();
            this.servicio.cmbTipoDeMatenimiento.Text = row.Cells[3].Value.ToString();
            servicio.btnModificar.Click += new EventHandler(Editar_Servicio);

            servicio.ShowDialog();
        }

        private void Editar_Servicio(object sender, EventArgs e)
        {
            if (SiCamposVacios() is false)
            {
                return;
            }

            int IdServicio = Convert.ToInt32(TablaServicios.SelectedRows[0].Cells[0].Value);
            string Descripcion = servicio.txtDescripcion.Texts;
            decimal Precio = Convert.ToDecimal(servicio.txtPrecio.Texts);
            string Tipo = servicio.cmbTipoDeMatenimiento.Text;

            MessageBox.Show(IdServicio.ToString(), " Dato");
            MessageBox.Show(Descripcion, "Dato");
            MessageBox.Show(Precio.ToString(), "Dato");
            MessageBox.Show(Tipo, "Dato");

            DServicios.Editar_Servicio(IdServicio, Descripcion, Precio, Tipo);
        }

        public void Estado()
        {
            if (Fabrica.SiFilaSeleccionada(TablaServicios) == false)
            {
                return;
            }

            int id = Convert.ToInt32(TablaServicios.SelectedRows[0].Cells[0].Value);
            DServicios.Cambiar_Estado_Servicio(id);
            Ver();
        }

        public void Guardar()
        {
        }

        public void Cancelar()
        {
            
        }

        public void Buscar(string text)
        {
            TablaServicios.DataSource = DServicios.Buscar_Servicio(text);
        }

        private bool SiCamposVacios()
        {
            if (servicio.txtDescripcion.Texts == "" || servicio.txtPrecio.Texts == "")
            {
                MessageBox.Show("Hay campos vacios", "Campos Obligatorios",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
