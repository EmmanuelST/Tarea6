using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6.Entidades;

namespace Tarea6.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Personas>Persona { get; set; }
        public Contexto() : base("Constr")
        {

        }
    }
}
