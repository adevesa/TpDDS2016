using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaClasesPoi;
using FuenteDeDatos;
using OrigenesDeDatos;
using System.Collections.Generic;

namespace TestOrigenLocal
{
    [TestClass]
    public class BuscarPoiEnOrigenLocal
    {
        OrigenLocal origenLocal = new OrigenLocal();

        [TestMethod]
        public void BuscarPoisEnOrigenLocal()
        {
            List<string> nombresDeLosPoisEncontrados = origenLocal.dao.mappearNombresPois(origenLocal.find("comida"));
            Assert.IsTrue(nombresDeLosPoisEncontrados.Contains("abasto shopping"));
            Assert.IsTrue(nombresDeLosPoisEncontrados.Contains("mc donald cordoba"));
        }
    }
}
