using Bunifu.UI.WinForms;
using ServiPlusApp.View.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiPlusApp.Controller.Factory
{
    class Fabrica
    {
        public static IAcciones FormController(BunifuDataGridView DgvTabla ,string formulario)
        {
            switch (formulario)
            {
                case "Clientes":
                    return new CClientes(DgvTabla);
                case "Mecanicos":
                    return new CMecanicos(DgvTabla);
                case "Servicios":
                    return new CServicios(DgvTabla);
                case "Repuestos":
                    return new CRepuestos(DgvTabla);
                case "Vehiculos":
                    return new CVehiculos(DgvTabla);
                case "Usuarios":
                    return new CUsuarios(DgvTabla);
                case "OpMantenimientos":
                    return new CMantenimientos(DgvTabla);
                default:
                    break;
            }

            return null;
        }

        public static bool SiFilaSeleccionada(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count != 1)
            {
                if (dgv.SelectedRows.Count > 1)
                {
                    System.Windows.Forms.MessageBox.Show("Seleccione una sola fila", "Servicios de Mantenimiento",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No se ha seleccionado ninguna fila", "Servicios de Mantenimiento",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return false;
            }

            return true;
        }
    }
}
