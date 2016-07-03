using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrigenesDeDatos;
using System.Collections.Generic;
using LibreriaClasesPoi;

namespace TestPoiDao
{
    [TestClass]
    public class CreacionDePoiDAO
    {
        PoiDAO poiDao = new PoiDAO();

        [TestMethod]
        public void ContieneLocalesComerciales()
        {
            List<string> listaNombresPois = poiDao.mappearNombresPois(poiDao.pois);
            Assert.IsTrue(listaNombresPois.Contains("abasto shopping"));
            Assert.IsTrue(listaNombresPois.Contains("mc donald cordoba"));
            Assert.IsTrue(listaNombresPois.Contains("galeria jardin"));
        }
    }
}
