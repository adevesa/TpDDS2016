using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaClasesPoi;

namespace TestLibreríaPoi
{
    [TestClass]
    public class TestParadaDeColectivo
    {
        ParadaDeColectivo parada115Once = new ParadaDeColectivo(5, "parada 115 once", new Coordenada(-34.6083803, -58.4071322));
        ParadaDeColectivo parada100Obelisco = new ParadaDeColectivo(6, "parada 100 obelisco", new Coordenada(-34.6037389, -58.3815704));


        public void init()
        {
            
            parada115Once.agregarPalabraClave("parada 115 once", "115", "bondi", "colectivo");
            
           
            parada100Obelisco.agregarPalabraClave("parada 100 once", "100", "bondi", "colectivo");
            
        }

        [TestMethod]
        public void ParadaDeColectivoCumpleCriteroDeBusqueda()
        {
            init();
            Assert.IsTrue(parada115Once.BuscarCoincidencia("115"));
            Assert.IsFalse(parada115Once.BuscarCoincidencia("100"));

            Assert.IsTrue(parada100Obelisco.BuscarCoincidencia("100"));
            Assert.IsFalse(parada100Obelisco.BuscarCoincidencia("115"));
        }
    }
}
