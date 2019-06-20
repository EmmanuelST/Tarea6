using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    class UnidadMedidas
    {
        public int IdUnidadMedida { get; set; }
        public string NombreUnidad { get; set; }

        public UnidadMedidas()
        {
            IdUnidadMedida = 0;
            NombreUnidad = string.Empty;
        }

    }
}
