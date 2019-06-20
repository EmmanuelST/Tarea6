using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    class TipoComprobantes
    {
        public int IdComprobante { get; set; }
        public string NombreComprobante { get; set; }

        public TipoComprobantes()
        {
            IdComprobante = 0;
            NombreComprobante = string.Empty;
        }
    }
}
