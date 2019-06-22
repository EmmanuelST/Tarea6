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
    public class VentasDetallesTest
    {
        [TestClass()]
        public class UsuariosTest
        {
            [TestMethod()]
            public void GuardarTest()
            {
                RepositorioBase<DetalleVentas> db = new RepositorioBase<DetalleVentas>();

                DetalleVentas entity = new DetalleVentas()
                {
                    IdDetalleVenta = 0,
                    IdProducto = 1,
                    IdVenta = 1,
                    CostoUnidad = 500,
                    DescuentoUnidad = 4,
                    Total = 50,
                    Unidades = 4
                };

                Assert.IsTrue(db.Guardar(entity));
            }

            [TestMethod()]
            public void ModificarTest()
            {
                RepositorioBase<DetalleVentas> db = new RepositorioBase<DetalleVentas>();

                DetalleVentas entity = new DetalleVentas()
                {
                    IdDetalleVenta = 4,
                    IdProducto = 2,
                    IdVenta = 1,
                    CostoUnidad = 504,
                    DescuentoUnidad = 4,
                    Total = 55,
                    Unidades = 5
                };

                Assert.IsTrue(db.Modificar(entity));

            }

            [TestMethod()]
            public void BuscarTest()
            {
                RepositorioBase<DetalleVentas> db = new RepositorioBase<DetalleVentas>();

                Assert.IsNotNull(db.Buscar(4));

            }

            [TestMethod()]
            public void GetListTest()
            {
                RepositorioBase<DetalleVentas> db = new RepositorioBase<DetalleVentas>();

                Assert.IsNotNull(db.GetList(t => true));

            }

            [TestMethod()]
            public void EliminarTest()
            {
                RepositorioBase<DetalleVentas> db = new RepositorioBase<DetalleVentas>();

                Assert.IsTrue(db.Eliminar(4));
            }
        }
    }
}
