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
    public class PersonasTest
    {
        [TestMethod()]
        
        public void GuardarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();
           

            Personas persona = new Personas()
            { IdPersona = 0,Dni = 1,Nombre = "nombre",Matemo = "prueba",Paterno = "prueba",FechaNacimiento = DateTime.Now
            ,Telefonon = "222222",Correo = "Prueba@",Sexo = 'M',Direccion = "prueba",IdTipoPersona = 1};
            
            Assert.IsTrue(db.Guardar(persona));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();
            Personas persona = new Personas()
            {
                IdPersona = 1,
                Dni = 1,
                Nombre = "nombre2",
                Matemo = "prueba2",
                Paterno = "prueba",
                FechaNacimiento = DateTime.Now,
                Telefonon = "222222",
                Correo = "Prueba@",
                Sexo = 'M',
                Direccion = "prueba",
                IdTipoPersona = 1
            };

            Assert.IsTrue(db.Modificar(persona));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsNotNull(db.Buscar(3));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsNotNull(db.GetList( p=>true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsTrue(db.Eliminar(3));
        }

       


    }
}
