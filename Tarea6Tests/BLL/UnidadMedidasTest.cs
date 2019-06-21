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
    public class UnidadMedidasTest
    {

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<UnidadMedidas> db = new RepositorioBase<UnidadMedidas>();

            UnidadMedidas entity = new UnidadMedidas()
            {
                IdUnidadMedida = 0,
                NombreUnidad = "Prueba1"
            };

            Assert.IsTrue(db.Guardar(entity));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<UnidadMedidas> db = new RepositorioBase<UnidadMedidas>();

            UnidadMedidas entity = new UnidadMedidas()
            {
                IdUnidadMedida = 1,
                NombreUnidad = "Prueba2"
            };


            Assert.IsTrue(db.Modificar(entity));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<UnidadMedidas> db = new RepositorioBase<UnidadMedidas>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<UnidadMedidas> db = new RepositorioBase<UnidadMedidas>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<UnidadMedidas> db = new RepositorioBase<UnidadMedidas>();

            Assert.IsTrue(db.Eliminar(1));
        }

    }       
}
