using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    class Estados
    {
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
