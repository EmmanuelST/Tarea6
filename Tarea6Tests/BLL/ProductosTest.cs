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
    public class ProductosTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            Productos entity = new Productos()
            {
                IdProducto = 0,
                IdCategoria = 1,
                IdImagen = 1,
                IdMarca = 1,
                IdModelo = 1,
                IdUnidadMedida = 1,
                Descripcion = "Prueba1",
                CostoCompra = 1,
                FechaFabricacion = DateTime.Now,
                Nombre = "Prueba1",
                Stock = 1
            };

            Assert.IsTrue(db.Guardar(entity));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            Productos entity = new Productos()
            {
                IdProducto = 1,
                IdCategoria = 1,
                IdImagen = 1,
                IdMarca = 1,
                IdModelo = 1,
                IdUnidadMedida = 1,
                Descripcion = "Prueba2",
                CostoCompra = 1,
                FechaFabricacion = DateTime.Now,
                Nombre = "Prueba2",
                Stock = 1
            };


            Assert.IsTrue(db.Modificar(entity));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
