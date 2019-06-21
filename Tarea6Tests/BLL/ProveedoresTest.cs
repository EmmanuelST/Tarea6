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
    public class ProveedoresTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();

            Proveedores entity = new Proveedores()
            {
                IdProveerdor = 0,
                IdPersona = 1
            };

            Assert.IsTrue(db.Guardar(entity));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();

            Proveedores entity = new Proveedores()
            {
                IdProveerdor = 1,
                IdPersona = 2
            };


            Assert.IsTrue(db.Modificar(entity));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
