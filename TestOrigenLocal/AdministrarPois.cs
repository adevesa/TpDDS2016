using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaClasesPoi;
using FuenteDeDatos;
using OrigenesDeDatos;
using System.Collections.Generic;

namespace TestOrigenLocal
{
    [TestClass]
    public class AdministrarPois
    {
        OrigenLocal origenLocal = new OrigenLocal();

        [TestMethod]
        public void AgregarPoiABaseLocal()
        {
            ParadaDeColectivo parada7Virreyes = new ParadaDeColectivo(10, "parada 7 virreyes");

            origenLocal.agregar(parada7Virreyes);

            Assert.IsTrue(origenLocal.dao.pois.Contains(parada7Virreyes));
        }

        [TestMethod]
        public void EditarPoiEnBaseLocal()
        {
            //Objeto inicial//
            LocalComercial abastoShopping = new LocalComercial(1, "abasto shopping", "avenida corrientes 3247");
            abastoShopping.agregarPalabraClave("compras", "distraccion", "cine", "comida", "ropa", "abasto shopping");

            origenLocal.agregar(abastoShopping);
            Assert.IsTrue(origenLocal.dao.pois.Contains(abastoShopping));

            //Objeto modificado//
            abastoShopping.agregarRubro("moda", "vestimenta", "paseo");
            origenLocal.editar(abastoShopping);

            //Busco el objeto modificado//
            List<POI> listaPoisBuscados = origenLocal.find("moda");
            List<string> listaNombresPoisBuscados = origenLocal.dao.mappearNombresPois(listaPoisBuscados);
            Assert.IsTrue(listaNombresPoisBuscados.Contains("abasto shopping"));

           

        }

        [TestMethod]
        public void BorrarPoiEnBaseLocal()
        {
            //Objeto inicial//
            LocalComercial brooklynBar  = new LocalComercial(13, "brooklyn bar", "costa Rica 4588");
            brooklynBar.agregarPalabraClave("noche", "distraccion", "musica", "baile", "diversion");

            origenLocal.agregar(brooklynBar);
            Assert.IsTrue(origenLocal.dao.pois.Contains(brooklynBar));

            //Borramos objeto y comprobamos//
            origenLocal.borrar(brooklynBar);
            Assert.IsFalse(origenLocal.dao.pois.Contains(brooklynBar));

        }
    }
}
