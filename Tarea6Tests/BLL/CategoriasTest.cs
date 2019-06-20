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
    public class CategoriasTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Categorias> db = new RepositorioBase<Categorias>();

            Categorias categoria = new Categorias()
            {
                IdCategoria = 0,
                NombreCategoria = "Prueba1",
                Descripcion = "Prueba1"
            };

            Assert.IsTrue(db.Guardar(categoria));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Categorias> db = new RepositorioBase<Categorias>();

            Categorias categoria = new Categorias()
            {
                IdCategoria = 1,
                NombreCategoria = "Prueba2",
                Descripcion = "Prueba2"
            };

            Assert.IsTrue(db.Modificar(categoria));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Categorias> db = new RepositorioBase<Categorias>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Categorias> db = new RepositorioBase<Categorias>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Categorias> db = new RepositorioBase<Categorias>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
