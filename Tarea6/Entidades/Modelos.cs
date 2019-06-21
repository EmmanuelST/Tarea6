using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    public class Modelos
    {
        [Key]
        public int IdModelo { get; set; }
        public string NombreModelo { get; set; }

        public Modelos()
        {
            IdModelo = 0;
            NombreModelo = string.Empty;
        }
    }
}
