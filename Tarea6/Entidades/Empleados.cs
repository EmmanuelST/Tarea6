﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    class Empleados
    {
        public int IdEmpleado { get; set; }
        public int IdEstado { get; set; }
        public int IdCargo { get; set; }
        public int IdPersona { get; set; }

        public Empleados()
        {
            IdEmpleado = 0;
            IdEstado = 0;
            IdCargo = 0;
            IdPersona = 0;
        }
    }
}