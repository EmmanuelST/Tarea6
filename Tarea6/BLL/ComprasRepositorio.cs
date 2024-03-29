﻿using System;
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
            RepositorioBase<DetalleCompras> dbDetalle = new RepositorioBase<DetalleCompras>();
            
            try
            {

                List<DetalleCompras> anterior = new List<DetalleCompras>();
                anterior = dbDetalle.GetList(C=> C.IdCompra == entity.IdCompra);
                anterior.Count();

                foreach(var item in anterior)
                {
                    if(!entity.Detalles.Any(C =>C.IdDetalleCompra == item.IdDetalleCompra))
                    {
                        dbDetalle.Eliminar(item.IdDetalleCompra);
                    }
                }

                foreach (var item in entity.Detalles)
                {

                    if (item.IdDetalleCompra == 0)
                        db.Entry(item).State = EntityState.Added;
                    else
                        db.Entry(item).State = EntityState.Modified;


                }

                db.Entry(entity).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;

            }
            catch(Exception)
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
