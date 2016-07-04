using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaClasesPoi;
using GoogleApi;

namespace TestLibreríaPoi
{
    [TestClass]
    public class TestCoordenadasPoi
    {
        Poi abastoShopping = new LocalComercial(8, "abasto shopping", "avenida corrientes 3274", new Coordenada(-30, -58));

        [TestMethod]
        public void UbicacionPorCoordenadasGoogle()
        {
            bool esUbi =abastoShopping.EsUbicable();
            Assert.IsTrue(esUbi);


            double latitudGoogleana = abastoShopping.getCoordenada().latitud;
            Assert.IsFalse(-30 == latitudGoogleana );

            //Por buscar en Google maps (A mano desde el navegador) obtenemos:
            double esperado = -34.603329;


            Assert.AreEqual(esperado, latitudGoogleana, "no es correcta");
        }
    }
}
