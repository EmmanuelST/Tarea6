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
            List<TipoPersonas> lista = new List<TipoPersonas>();

            lista.Add(new TipoPersonas() { IdPersona = 1, Nombre = "Prueba"});
            lista.Add(new TipoPersonas() { IdPersona = 1, Nombre = "Prueba2" });
            lista.Add(new TipoPersonas() { IdPersona = 1, Nombre = "Prueba3" });

            Personas persona = new Personas()
            { IdPersona = 0,Dni = 1,Nombre = "nombre",Matemo = "prueba",Paterno = "prueba",FechaNacimiento = DateTime.Now
            ,Telefonon = "222222",Correo = "Prueba@",Sexo = 'M',Direccion = "prueba",Tipo =  lista};
            
            Assert.IsTrue(db.Guardar(persona));
        }

        public void EliminarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsTrue(db.Eliminar(1));
        }


    }
}
