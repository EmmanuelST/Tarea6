using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    class Compras
    {
        public int IdCompra { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaCompra { get; set; }
        public int IdProveedor { get; set; }
        public int IdComprobante { get; set; }
        public double CostoCompra { get; set; }

        public Compras()
        {
            IdCompra = 0;
            IdUsuario = 0;
            FechaCompra = DateTime.Now;
            IdProveedor = 0;
            IdComprobante = 0;
            CostoCompra = 0;
        }
    }
}
