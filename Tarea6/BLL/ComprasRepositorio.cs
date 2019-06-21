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

                    if (item.IdDetalleCompra.Equals(0))
                        db.Entry(item).State = EntityState.Added;
                    else
                        db.Entry(item).State = EntityState.Modified;



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
