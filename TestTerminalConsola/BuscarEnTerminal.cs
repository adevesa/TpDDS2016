using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Consola;
using LibreriaClasesPoi;
using FuenteDeDatos;
using OrigenesDeDatos;
using Repositorio;


namespace TestTerminalConsola
{
    [TestClass]
    public class BuscarEnTerminal
    {
        TerminalConsola terminal = new TerminalConsola("terminal la esquina de medrano", 5, new Buscador());

        [TestMethod]
        public void BuscarColectivosEnTerminal()
        {
            List<Poi> listaPoisBuscados = terminal.buscar("colectivo");
            List<string> listaNombresPoisBuscados = terminal.mappearNombresPois(listaPoisBuscados);

            Assert.IsTrue(listaNombresPoisBuscados.Contains("parada 115 once"));
            Assert.IsTrue(listaNombresPoisBuscados.Contains("parada 100 obelisco"));

            Assert.IsFalse(listaNombresPoisBuscados.Contains("abasto shopping"));
        }

        [TestMethod]
        public void BuscarLocalesEnTerminal()
        {
            List<Poi> listaPoisBuscados = terminal.buscar("tablets");
            List<string> listaNombresPoisBuscados = terminal.mappearNombresPois(listaPoisBuscados);

            Assert.IsTrue(listaNombresPoisBuscados.Contains("galeria jardin"));

            Assert.IsFalse(listaNombresPoisBuscados.Contains("abasto shopping"));
        }
    }
}
