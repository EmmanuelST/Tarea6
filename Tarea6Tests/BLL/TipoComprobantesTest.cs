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
    public class TipoComprobantesTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<TipoComprobantes> db = new RepositorioBase<TipoComprobantes>();

            TipoComprobantes entity = new TipoComprobantes()
            {
                IdComprobante = 0,
                NombreComprobante = "Prueba1"
            };

            Assert.IsTrue(db.Guardar(entity));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<TipoComprobantes> db = new RepositorioBase<TipoComprobantes>();

            TipoComprobantes entity = new TipoComprobantes()
            {
                IdComprobante = 1,
                NombreComprobante = "Prueba1"
            };


            Assert.IsTrue(db.Modificar(entity));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<TipoComprobantes> db = new RepositorioBase<TipoComprobantes>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<TipoComprobantes> db = new RepositorioBase<TipoComprobantes>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<TipoComprobantes> db = new RepositorioBase<TipoComprobantes>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
