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
    public class ModelosTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Modelos> db = new RepositorioBase<Modelos>();

            Modelos entity = new Modelos()
            {
                IdModelo = 0,
                NombreModelo = "Prueba1"
            };

            Assert.IsTrue(db.Guardar(entity));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Modelos> db = new RepositorioBase<Modelos>();

            Modelos entity = new Modelos()
            {
                IdModelo = 1,
                NombreModelo = "Prueba2"
            };


            Assert.IsTrue(db.Modificar(entity));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Modelos> db = new RepositorioBase<Modelos>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Modelos> db = new RepositorioBase<Modelos>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Modelos> db = new RepositorioBase<Modelos>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
