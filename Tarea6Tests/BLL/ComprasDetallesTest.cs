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
    public class ComprasDetallesTest
    {
        [TestClass()]
        public class UsuariosTest
        {
            [TestMethod()]
            public void GuardarTest()
            {
                RepositorioBase<DetalleCompras> db = new RepositorioBase<DetalleCompras>();

                DetalleCompras entity = new DetalleCompras()
                {
                    IdDetalleCompra = 0,
                    IdCompra = 1,
                    IdProducto = 1,
                    CostoUnidad = 50,
                    Total = 10,
                    Unidades = 20
                };

                Assert.IsTrue(db.Guardar(entity));
            }

            [TestMethod()]
            public void ModificarTest()
            {
                RepositorioBase<DetalleCompras> db = new RepositorioBase<DetalleCompras>();

                DetalleCompras entity = new DetalleCompras()
                {
                    IdDetalleCompra = 1,
                    IdCompra = 1,
                    IdProducto = 1,
                    CostoUnidad = 50,
                    Total = 10,
                    Unidades = 20
                };

                Assert.IsTrue(db.Modificar(entity));

            }

            [TestMethod()]
            public void BuscarTest()
            {
                RepositorioBase<DetalleCompras> db = new RepositorioBase<DetalleCompras>();

                Assert.IsNotNull(db.Buscar(1));

            }

            [TestMethod()]
            public void GetListTest()
            {
                RepositorioBase<DetalleCompras> db = new RepositorioBase<DetalleCompras>();

                Assert.IsNotNull(db.GetList(t => true));

            }

            [TestMethod()]
            public void EliminarTest()
            {
                RepositorioBase<DetalleCompras> db = new RepositorioBase<DetalleCompras>();

                Assert.IsTrue(db.Eliminar(1));
            }
        }
    }
}
