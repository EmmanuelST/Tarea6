using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }
        public int IdPersona { get; set; }
        public int IdEstado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Clientes()
        {
            IdCliente = 0;
            IdPersona = 0;
            IdEstado = 0;
            FechaCreacion = DateTime.Now;
        }
    }
}
