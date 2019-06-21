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
    public class UsuarioHasPermisosTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Usuario_Has_Permisos> db = new RepositorioBase<Usuario_Has_Permisos>();

            Usuario_Has_Permisos entity = new Usuario_Has_Permisos()
            {
                IdUsuario_Has_Permiso = 0,
                IdPermiso = 1,
                IdUsuario = 1
            };

            Assert.IsTrue(db.Guardar(entity));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Usuario_Has_Permisos> db = new RepositorioBase<Usuario_Has_Permisos>();

            Usuario_Has_Permisos entity = new Usuario_Has_Permisos()
            {
                IdUsuario_Has_Permiso = 1,
                IdPermiso = 2,
                IdUsuario = 2
            };



            Assert.IsTrue(db.Modificar(entity));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Usuario_Has_Permisos> db = new RepositorioBase<Usuario_Has_Permisos>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Usuario_Has_Permisos> db = new RepositorioBase<Usuario_Has_Permisos>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Usuario_Has_Permisos> db = new RepositorioBase<Usuario_Has_Permisos>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
