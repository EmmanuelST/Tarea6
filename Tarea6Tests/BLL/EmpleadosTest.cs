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
    public class EmpleadosTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Empleados> db = new RepositorioBase<Empleados>();

            Empleados empleado = new Empleados()
            {
                IdEmpleado = 0,
                IdCargo = 1,
                IdEstado = 1,
                IdPersona = 1,
               
            };

            Assert.IsTrue(db.Guardar(empleado));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Empleados> db = new RepositorioBase<Empleados>();

            Empleados empleado = new Empleados()
            {
                IdEmpleado = 1,
                IdCargo = 1,
                IdEstado = 1,
                IdPersona = 1,

            };

            Assert.IsTrue(db.Modificar(empleado));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Empleados> db = new RepositorioBase<Empleados>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Empleados> db = new RepositorioBase<Empleados>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Empleados> db = new RepositorioBase<Empleados>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
