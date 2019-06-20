﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    class Usuarios
    {
        public int IdUsuario { get; set; }
        public int IdEmpleado { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }

        public Usuarios()
        {
            IdUsuario = 0;
            IdEmpleado = 0;
            Usuario = string.Empty;
            Clave = string.Empty;
        }
    }
}