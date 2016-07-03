using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Consola;
using LibreriaClasesPoi;
using Repositorio;
using FuenteDeDatos;
using OrigenesDeDatos;
using System.Collections.Generic;

namespace TestBuscador
{
    [TestClass]
    public class Buscar
    {
        Buscador buscador = new Buscador();

        [TestMethod]
        public void BuscarPoisEnBuscador()
        {
            List<Poi> listaPois =buscador.find("comida");
            List<string> listaNombrePois = buscador.mappearNombresPois(listaPois);

            Assert.IsTrue(listaNombrePois.Contains("abasto shopping"));
            Assert.IsTrue(listaNombrePois.Contains("mc donald cordoba"));

        }
    }
}
