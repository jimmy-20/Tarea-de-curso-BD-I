﻿using ServiPlusApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlusApp.Controller
{
    public class CBuscarUsuario
    {
        public static DataTable Buscar_Usuario(string dato)
        {
           return DBuscarUsuario.Buscar_Usuario(dato);
        }

    }
}
