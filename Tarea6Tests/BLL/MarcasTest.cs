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
    public class MarcasTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Marcas> db = new RepositorioBase<Marcas>();

            Marcas entity = new Marcas()
            {
                IdMarca = 0,
                NombreMarca = "Prueba1"
            };

            Assert.IsTrue(db.Guardar(entity));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Marcas> db = new RepositorioBase<Marcas>();

            Marcas entity = new Marcas()
            {
                IdMarca = 1,
                NombreMarca = "Prueba2"
            };


            Assert.IsTrue(db.Modificar(entity));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Marcas> db = new RepositorioBase<Marcas>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Marcas> db = new RepositorioBase<Marcas>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Marcas> db = new RepositorioBase<Marcas>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
