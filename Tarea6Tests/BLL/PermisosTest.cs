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
    public class PermisosTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Permisos> db = new RepositorioBase<Permisos>();

            Permisos entity = new Permisos()
            {
                IdPermiso = 0,
                Descripcion = "Prueba1",
                Funcionalidad = "Prueba1"
            };

            Assert.IsTrue(db.Guardar(entity));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Permisos> db = new RepositorioBase<Permisos>();

            Permisos entity = new Permisos()
            {
                IdPermiso = 1,
                Descripcion = "Prueba2",
                Funcionalidad = "Prueba2"
            };


            Assert.IsTrue(db.Modificar(entity));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Permisos> db = new RepositorioBase<Permisos>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Permisos> db = new RepositorioBase<Permisos>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Permisos> db = new RepositorioBase<Permisos>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
