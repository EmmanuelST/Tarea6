using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    public class Permisos
    {
        [Key]
        public int IdPermiso { get; set; }
        public string Descripcion { get; set; }
        public string Funcionalidad { get; set; }

        public Permisos()
        {
            IdPermiso = 0;
            Descripcion = string.Empty;
            Funcionalidad = string.Empty;
        }
    }
}
