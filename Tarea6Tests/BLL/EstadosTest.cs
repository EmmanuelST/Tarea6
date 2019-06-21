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
    public class EstadosTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Estados> db = new RepositorioBase<Estados>();

            Estados estado = new Estados()
            {
                IdEstado = 0,
                Estado = "Prueba1",
                FechaFin = DateTime.Now,
                FechaInicio = DateTime.Now,
            };

            Assert.IsTrue(db.Guardar(estado));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Estados> db = new RepositorioBase<Estados>();

            Estados estado = new Estados()
            {
                IdEstado = 1,
                Estado = "Prueba1",
                FechaFin = DateTime.Now,
                FechaInicio = DateTime.Now,
            };

            Assert.IsTrue(db.Modificar(estado));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Estados> db = new RepositorioBase<Estados>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Estados> db = new RepositorioBase<Estados>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Estados> db = new RepositorioBase<Estados>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
