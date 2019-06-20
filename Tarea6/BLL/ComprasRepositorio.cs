using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6.DAL;
using Tarea6.Entidades;

namespace Tarea6.BLL
{
    public class ComprasRepositorio : RepositorioBase<Compras>
    {
        public override bool Modificar(Compras entity)
        {
            bool paso = false;
            Contexto db = new Contexto();
            
            try
            {

                Compras anterior = db.Compra.Find(entity.IdCompra);
                foreach(var item in anterior.Detalles)
                {
                    if (!entity.Detalles.Any(C => C.IdCompra == item.IdCompra))
                        db.Entry(item).State = EntityState.Deleted;

                }

                EntityState estado;
                foreach (var item in entity.Detalles)
                {

                    if (item.IdCompra == 0)
                        estado = EntityState.Added;
                    else
                        estado = EntityState.Modified;


                    db.Entry(item).State = estado;
                }

                db.Entry(entity).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;


            }catch(Exception)
            {
                throw;
            }


            return paso;
        }
    }
}
