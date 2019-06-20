using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.DAL
{
    class Contexto : DbContext
    {

        public Contexto() : base("Constr")
        {

        }
    }
}
