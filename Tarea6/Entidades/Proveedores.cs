using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    public class Proveedores
    {
        [Key]
        public int IdProveerdor { get; set; }
        public int IdPersona { get; set; }

        public Proveedores()
        {
            IdProveerdor = 0;
            IdPersona = 0;
        }
    }
}
