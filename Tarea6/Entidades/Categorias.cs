﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    class Categorias
    {

        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }

        public Categorias()
        {
            IdCategoria = 0;
            NombreCategoria = string.Empty;
            Descripcion = string.Empty;
        }

    }

}