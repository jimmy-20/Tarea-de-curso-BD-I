using Bunifu.UI.WinForms;
using ServiPlusApp.Controller.Factory;
using ServiPlusApp.Model;
using ServiPlusApp.View.Set_Tables.Repuestos;
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
    public class CRepuestos : IAcciones 
    {
        private BunifuDataGridView TablaRepuestos;
        private Repuesto repuesto;

        public CRepuestos(BunifuDataGridView TablaRepuestos)
        {
            this.TablaRepuestos = TablaRepuestos;
        }

        public void Ver()
        {
            TablaRepuestos.DataSource = DRepuestos.Mostrar_Repuestos();
            TablaRepuestos.Columns[0].Visible = false;
        }

        public void Agregar()
        {
            repuesto = new Repuesto("Nuevo");
            repuesto.btnGuardar.Click += new EventHandler(Insertar_Repuesto);
            Ver();
            repuesto.ShowDialog();
        }

        private void Insertar_Repuesto(object sender, EventArgs e)
        {
            if (SiCamposVacios() is false)
                return;

            string Descripcion = repuesto.txtDescripcion.Text;
            string Marca = repuesto.txtMarca.Text;
            string Modelo = repuesto.txtModelo.Text;
            decimal Precio = Convert.ToDecimal(repuesto.txtPrecio.Text);
            int Cantidad = Convert.ToInt32(repuesto.txtCantidad.Text);

            DRepuestos.Insertar_Repuesto(Descripcion, Marca, Modelo, Precio, Cantidad);

        }

        public void Editar()
        {
            if (Fabrica.SiFilaSeleccionada(TablaRepuestos) is false)
            {
                return;
            }

            repuesto = new Repuesto("Modificar");

            DataGridViewRow row = TablaRepuestos.SelectedRows[0];


            repuesto.txtDescripcion.Text = row.Cells[1].Value.ToString();
            repuesto.txtMarca.Text = row.Cells[2].Value.ToString();
            repuesto.txtModelo.Text = row.Cells[3].Value.ToString();
            repuesto.txtPrecio.Text = row.Cells[4].Value.ToString();
            repuesto.txtCantidad.Text = row.Cells[5].Value.ToString();


            repuesto.btnModificar.Click += new EventHandler(Editar_Mecanico);
            repuesto.ShowDialog();
        }

        private void Editar_Mecanico(object sender, EventArgs e)
        {
            if (SiCamposVacios() is false)
            {
                return;
            }

            int IdRepuesto = Convert.ToInt32(TablaRepuestos.SelectedRows[0].Cells[0].Value);
            if (SiCamposVacios() is false)
                return;


            string Descripcion = repuesto.txtDescripcion.Text;
            string Marca = repuesto.txtMarca.Text;
            string Modelo = repuesto.txtModelo.Text;
            decimal Precio = Convert.ToDecimal(repuesto.txtPrecio.Text);
            int Cantidad = Convert.ToInt32(repuesto.txtCantidad.Text);

            DRepuestos.Editar_Repuesto(IdRepuesto, Descripcion, Marca, Modelo, Precio, Cantidad);
            Ver();
        }

        public void Estado()
        {
            if (Fabrica.SiFilaSeleccionada(TablaRepuestos) == false)
            {
                return;
            }

            DataGridViewRow row = TablaRepuestos.SelectedRows[0];

            int id = Convert.ToInt32(row.Cells[0].Value);
            DRepuestos.Cambiar_Estado_Repuesto(id);
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
            TablaRepuestos.DataSource = DRepuestos.Buscar_Repuesto(text);
        }

        public static DataTable Table_Repuestos()
        {
            return DRepuestos.Mostrar_Repuestos();
        }

        private bool SiCamposVacios()
        {
            if (repuesto.txtDescripcion.Text == "" || repuesto.txtMarca.Text == "" || repuesto.txtModelo.Text == "" || repuesto.txtPrecio.Text == "" || repuesto.txtCantidad.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Campos Obligatorios",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
    }
}
