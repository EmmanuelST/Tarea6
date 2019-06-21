using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    public class Ventas
    {
        [Key]
        public int IdVenta { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
        public int IdComprobante { get; set; }
        public DateTime FechaVenta { get; set; }
        public double Igv { get;set; }
        public double SubTotal { get;set; }
        public double CostoVenta { get; set; }

    }
}
