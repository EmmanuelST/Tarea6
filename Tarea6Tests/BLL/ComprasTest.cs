using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6.BLL;
using Tarea6.Entidades;

namespace Tarea6Tests.BLL
{
    [TestClass()]
    public class ComprasTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            ComprasRepositorio db = new ComprasRepositorio();
            List<DetalleCompras> lista = new List<DetalleCompras>();
            lista.Add(new DetalleCompras()
            { IdCompra = 0,
                IdDetalleCompra = 0,
                Unidades = 100,
                Total = 100,
                CostoUnidad = 50,
                IdProducto = 1 });
            lista.Add(new DetalleCompras()
            {
                IdCompra = 0,
                IdDetalleCompra = 0,
                Unidades = 120,
                Total = 130,
                CostoUnidad = 60,
                IdProducto = 2
            });

            Compras compra = new Compras()
            {
                IdCompra = 0,
                IdComprobante = 1,
                IdProveedor = 1,
                IdUsuario = 1,
                FechaCompra = DateTime.Now,
                CostoCompra = 100,
                Detalles = lista
            };

            Assert.IsTrue(db.Guardar(compra));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            ComprasRepositorio db = new ComprasRepositorio();

            List<DetalleCompras> lista = new List<DetalleCompras>();
            lista.Add(new DetalleCompras()
            {
                IdCompra = 1,
                IdDetalleCompra = 1,
                Unidades = 100,
                Total = 100,
                CostoUnidad = 50,
                IdProducto = 1
            });
            

            Compras compra = new Compras()
            {
                IdCompra = 1,
                IdComprobante = 1,
                IdProveedor = 1,
                IdUsuario = 1,
                FechaCompra = DateTime.Now,
                CostoCompra = 103,
                Detalles = lista
            };

            Assert.IsTrue(db.Modificar(compra));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            ComprasRepositorio db = new ComprasRepositorio();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            ComprasRepositorio db = new ComprasRepositorio();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            ComprasRepositorio db = new ComprasRepositorio();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
