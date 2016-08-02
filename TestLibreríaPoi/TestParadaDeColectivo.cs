using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaClasesPoi;

namespace TestLibreríaPoi
{
    [TestClass]
    public class TestParadaDeColectivo
    {
        ParadaDeColectivo parada115Once = new ParadaDeColectivo("parada 115 once");
        ParadaDeColectivo parada100Obelisco = new ParadaDeColectivo("parada 100 obelisco");


        public void init()
        {
            
            parada115Once.agregarPalabraClave("parada 115 once", "115", "bondi", "colectivo");
            
           
            parada100Obelisco.agregarPalabraClave("parada 100 once", "100", "bondi", "colectivo");
            
        }

        [TestMethod]
        public void ParadaDeColectivoCumpleCriteroDeBusqueda()
        {
            init();
            Assert.IsTrue(parada115Once.buscarCoincidencia("115"));
            Assert.IsFalse(parada115Once.buscarCoincidencia("100"));

            Assert.IsTrue(parada100Obelisco.buscarCoincidencia("100"));
            Assert.IsFalse(parada100Obelisco.buscarCoincidencia("115"));
        }
    }
}
