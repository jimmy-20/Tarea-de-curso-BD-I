using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller.Factory
{
    interface IAcciones
    {
        void Ver();
        void Agregar();
        void Editar();
        void Estado();
        void Guardar();
        void Cancelar();
        void Buscar(string text);
    }
}
