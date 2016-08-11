using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaClasesPoi;
using Procesos;
using FuenteDeDatos;
using OrigenesDeDatos;
using Repositorio;

namespace TestProceso
{
    [TestClass]
    public class TestDeProcesos
    {
        //Arrange
        PoiDAO ListaDePois = new PoiDAO();
        LocalComercial coto = new LocalComercial("coto", "Rivadavia 4000");

        BajaDePois bajaDePois = new BajaDePois();
        DateTime fechaDeBaja1 = new DateTime(1995, 6, 15);
        DateTime fechaDeBaja2 = new DateTime(2030, 12, 20);      
        
      
        ActualizacionDeLocalesComerciales actualizacionDeLocalesComerciales = new ActualizacionDeLocalesComerciales();
        LocalComercial jumbo = new LocalComercial("jumbo", "Rivadavia 4100");

        [TestMethod]
        public void TestPOIActivo()
        {
            coto.setFechaDeBaja(fechaDeBaja2);

            Assert.IsTrue(coto.estaActivo());
        }

        [TestMethod]
        public void TestPOIInactivo()
        {
            coto.setFechaDeBaja(fechaDeBaja1);

            Assert.IsFalse(coto.estaActivo());
        }

        [TestMethod]
        public void BajaDePoisDejaUnPOI()
        {
            coto.setFechaDeBaja(fechaDeBaja2);
            coto.Nombre = "coto";
            ListaDePois.crear(coto);
            //bajaDePois.ejecutar("pikachu@gmail.com"); 
            bajaDePois.darDeBajaSiEsNecesario(coto);

            Assert.IsTrue(ListaDePois.verificarExistencia("coto"));
        }

        [TestMethod]
        public void BajaDePoisQuitaUnPOI()
        {
            coto.setFechaDeBaja(fechaDeBaja1);
            coto.Nombre = "coto";
            ListaDePois.crear(coto);
            //bajaDePois.ejecutar("pikachu@gmail.com");
            bajaDePois.darDeBajaSiEsNecesario(coto); //no se que mierda esta mal
            //ListaDePois.borrar2(coto); //tanto borrar2 como estaActivo funcionan perfectamente

            Assert.IsFalse(ListaDePois.verificarExistencia("coto")); //Con isTrue marca que esta bien, como si no lo borrara de la lista.
        }

       // [TestMethod]
       // public void ActualizarLocalComercialInexistente()
       // { 
        //    jumbo.Nombre = "jumbo";
       //     actualizacionDeLocalesComerciales.actualizarLocalComercial("jumbo", );
       //
       //     Assert.IsTrue(ListaDePois.verificarExistencia("jumbo"));

        //}

    }
}
