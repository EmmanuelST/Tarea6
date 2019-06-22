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
    public class VentasTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            VentasRespositorio db = new VentasRespositorio();
            List<DetalleVentas> lista = new List<DetalleVentas>();

            lista.Add(new DetalleVentas()
            {
                IdDetalleVenta = 0,
                IdProducto = 1,
                IdVenta = 0,
                CostoUnidad = 50,
                DescuentoUnidad = 10,
                Total = 100,
                Unidades = 5
            });

            lista.Add(new DetalleVentas()
            {
                IdDetalleVenta = 0,
                IdProducto = 2,
                IdVenta = 0,
                CostoUnidad = 52,
                DescuentoUnidad = 12,
                Total = 102,
                Unidades = 2
            });


            Ventas entity = new Ventas()
            {
                IdVenta = 0,
                IdCliente = 1,
                IdComprobante = 1,
                IdUsuario = 1,
                Igv = 1,
                CostoVenta = 500,
                FechaVenta = DateTime.Now,
                SubTotal = 50,
                Detalles = lista
            };

            Assert.IsTrue(db.Guardar(entity));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            VentasRespositorio db = new VentasRespositorio();

            List<DetalleVentas> lista = new List<DetalleVentas>();

            lista.Add(new DetalleVentas()
            {
                IdDetalleVenta = 0,
                IdProducto = 1,
                IdVenta = 1,
                CostoUnidad = 50,
                DescuentoUnidad = 10,
                Total = 100,
                Unidades = 5
            });

            Ventas entity = new Ventas()
            {
                IdVenta = 1,
                IdCliente = 1,
                IdComprobante = 1,
                IdUsuario = 1,
                Igv = 1,
                CostoVenta = 500,
                FechaVenta = DateTime.Now,
                SubTotal = 50,
                Detalles = lista
            };



            Assert.IsTrue(db.Modificar(entity));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            VentasRespositorio db = new VentasRespositorio();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            VentasRespositorio db = new VentasRespositorio();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            VentasRespositorio db = new VentasRespositorio();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
