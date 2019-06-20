using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    class Marcas
    {
        public int IdMarca { get; set; }
        public string NombreMarca { get; set; }

        public Marcas()
        {
            IdMarca = 0;
            NombreMarca = string.Empty;
        }
    }
}
