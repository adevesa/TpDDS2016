using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaClasesPoi;
using GoogleApi;
using CoordenadaGeografica;

namespace TestLibreríaPoi
{
    [TestClass]
    public class TestCoordenadasPoi
    {
        Poi abastoShopping = new LocalComercial(8, "abasto shopping", "avenida corrientes 3274");

        [TestMethod]
        public void UbicacionPorCoordenadasGoogle()
        {
            bool esUbi =abastoShopping.esUbicable();
            Assert.IsTrue(esUbi);


            double latitudGoogleana = abastoShopping.getCoordenada().getLatitud();
            double longitudGoogleana = abastoShopping.getCoordenada().getLongitud();

            Assert.IsFalse(-30 == latitudGoogleana );
            Assert.IsFalse(-58 == longitudGoogleana);

            //Por buscar en Google maps (A mano desde el navegador) obtenemos:
            double latitudAproximadaEsperada = -34.603329;
            double longitudAproximadaEsperada = -58.410789;

            //Se espera que falle para mostrar que recibimos un valor efectivamente//
            Assert.AreNotEqual(latitudAproximadaEsperada, latitudGoogleana, "No es correcta");
            Assert.AreNotEqual(longitudAproximadaEsperada, longitudGoogleana, "No es correcta");
        }
    }
}
