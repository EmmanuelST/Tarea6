using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    public class UnidadMedidas
    {
        [Key]
        public int IdUnidadMedida { get; set; }
        public string NombreUnidad { get; set; }

        public UnidadMedidas()
        {
            IdUnidadMedida = 0;
            NombreUnidad = string.Empty;
        }

    }
}
