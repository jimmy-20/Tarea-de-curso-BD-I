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
        public static IAcciones FormController(MostrarTabla Formulario ,string formulario)
        {
            switch (formulario)
            {
                case "Clientes":
                    return new CClientes(Formulario);
                case "Mecanicos":
                    return new CMecanicos(Formulario);
                case "Servicios":
                    return new CServicios(Formulario);
                case "OpRepuestos":
                    return new CRepuestos(Formulario);
                case "Vehiculos":
                    return new CVehiculos(Formulario);
                case "Usuarios":
                    return new CUsuarios(Formulario);
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
