using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiPlusApp.Model;
namespace ServiPlusApp.Controller
{
    class CUser
    {
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
            return DUser.Crear_Usuario(nombre,apellido,telefono,especialidad,rol,username,passWord);
        }

        public static DataTable Table_Usuarios()
        {
            return DUser.Tabla_Usuarios();
        }

        public static DataTable Buscar_Usuario(string dato)
        {
            return DUser.Buscar_Usuario(dato);
        }


    }
}
