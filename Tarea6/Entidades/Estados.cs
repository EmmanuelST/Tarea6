using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    public class Estados
    {
        [Key]
        public int IdEstado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }

        public Estados()
        {
            IdEstado = 0;
            FechaInicio = DateTime.Now;
            FechaFin = DateTime.Now;
            Estado = string.Empty;
        }
    }
}
