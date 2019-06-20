using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
     public class Personas
    {
        [Key]
        public int IdPersona { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Matemo { get; set; }
        public string Paterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefonon { get; set; }
        public string Correo { get; set; }
        public char Sexo { get; set; }
        public string Direccion { get; set; } 
        public virtual List<TipoPersonas>Tipo { get; set; }

    }
}
