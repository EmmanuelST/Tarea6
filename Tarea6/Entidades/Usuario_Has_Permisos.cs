using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    public class Usuario_Has_Permisos
    {
        [Key]
        public int IdUsuario_Has_Permiso { get; set; }
        public int IdUsuario { get; set; }
        public int IdPermiso { get; set; }

        public Usuario_Has_Permisos()
        {
            IdUsuario_Has_Permiso = 0;
            IdUsuario = 0;
            IdPermiso = 0;
        }
    }
}
