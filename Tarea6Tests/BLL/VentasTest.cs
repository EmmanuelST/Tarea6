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
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();

            Ventas entity = new Ventas()
            {
                IdVenta = 0,
                IdCliente = 1,
                IdComprobante = 1,
                IdUsuario = 1,
                Igv = 1,
                CostoVenta = 500,
                FechaVenta = DateTime.Now,
                SubTotal = 50
            };

            Assert.IsTrue(db.Guardar(entity));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();

            Ventas entity = new Ventas()
            {
                IdVenta = 1,
                IdCliente = 1,
                IdComprobante = 1,
                IdUsuario = 1,
                Igv = 1,
                CostoVenta = 50,
                FechaVenta = DateTime.Now,
                SubTotal = 500
            };



            Assert.IsTrue(db.Modificar(entity));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
