using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    public class Imagenes
    {
        [Key]
        public int IdImagen { get; set; }
        public string RutaImagen { get; set; }

        public Imagenes()
        {
            IdImagen = 0;
            RutaImagen = string.Empty;
        }
    }
}
