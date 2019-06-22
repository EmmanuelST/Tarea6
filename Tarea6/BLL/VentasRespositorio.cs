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
    public class VentasRespositorio : RepositorioBase<Ventas>
    {
        public override bool Modificar(Ventas entity)
        {
            bool paso = false;
            Contexto db = new Contexto();
            RepositorioBase<DetalleVentas> dbDetalle = new RepositorioBase<DetalleVentas>();

            try
            {

                List<DetalleVentas> anterior = new List<DetalleVentas>();
                anterior = dbDetalle.GetList(C => C.IdVenta == entity.IdVenta);
                anterior.Count();

                foreach (var item in anterior)
                {
                    if (!entity.Detalles.Any(C => C.IdDetalleVenta == item.IdDetalleVenta))
                    {
                        dbDetalle.Eliminar(item.IdDetalleVenta);
                    }
                }

                foreach (var item in entity.Detalles)
                {

                    if (item.IdDetalleVenta == 0)
                        db.Entry(item).State = EntityState.Added;
                    else
                        db.Entry(item).State = EntityState.Modified;


                }

                db.Entry(entity).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
                dbDetalle.Dispose();
            }


            return paso;
        }

    }
}
