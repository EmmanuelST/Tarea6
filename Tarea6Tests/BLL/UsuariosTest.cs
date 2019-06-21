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
    public class UsuariosTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            Usuarios entity = new Usuarios()
            {
                IdUsuario = 0,
                IdEmpleado = 1,
                Clave = "Prueba1",
                Usuario = "Prueba1"
            };

            Assert.IsTrue(db.Guardar(entity));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            Usuarios entity = new Usuarios()
            {
                IdUsuario = 1,
                IdEmpleado = 1,
                Clave = "Prueba2",
                Usuario = "Prueba2"
            };



            Assert.IsTrue(db.Modificar(entity));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
