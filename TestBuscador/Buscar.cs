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
        TerminalConsola terminal = new TerminalConsola("la esquina de la facu", 5, new Buscador());

        [TestMethod]
        public void BuscarLocalComercial1()
        {
            List<Poi> listaPois =terminal.buscar("abasto shoppig");
            List<string> listaNombrePois = terminal.mappearNombresPois(listaPois);
            Assert.IsTrue(listaNombrePois.Contains("abasto shopping"));
        
        }
    }
}
