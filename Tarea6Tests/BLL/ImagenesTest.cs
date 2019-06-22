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
    public class ImagenesTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Imagenes> db = new RepositorioBase<Imagenes>();

            Imagenes entity = new Imagenes()
            {
                IdImagen = 0,
                RutaImagen = "Prueba1",
            };

            Assert.IsTrue(db.Guardar(entity));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Imagenes> db = new RepositorioBase<Imagenes>();

            Imagenes entity = new Imagenes()
            {
                IdImagen = 1,
                RutaImagen = "Prueba1",
            };
            

            Assert.IsTrue(db.Modificar(entity));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Imagenes> db = new RepositorioBase<Imagenes>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Imagenes> db = new RepositorioBase<Imagenes>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Imagenes> db = new RepositorioBase<Imagenes>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
