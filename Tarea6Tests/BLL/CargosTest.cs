using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6.Entidades;
using Tarea6.BLL;

namespace Tarea6Tests.BLL
{
    [TestClass()]
    public class CargosTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Cargos> db = new RepositorioBase<Cargos>();

            Cargos cargo = new Cargos()
            {
                IdCargo = 0,
                IdEstado = 1,
                Nombre = "Prueba 1"
            };

            Assert.IsTrue(db.Guardar(cargo));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Cargos> db = new RepositorioBase<Cargos>();

            Cargos cargo = new Cargos()
            {
                IdCargo = 1,
                IdEstado = 1,
                Nombre = "Prueba 2"
            };

            Assert.IsTrue(db.Modificar(cargo));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Cargos> db = new RepositorioBase<Cargos>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Cargos> db = new RepositorioBase<Cargos>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Cargos> db = new RepositorioBase<Cargos>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
