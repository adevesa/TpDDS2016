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
    public class CreacionDeTerminal
    {
        TerminalConsola terminal = new TerminalConsola("terminal la esquina de medrano", 5, new Buscador());

        [TestMethod]
        public void TerminalCreadaExitosamente()
        {
            Assert.IsInstanceOfType(terminal, terminal.GetType());
            Assert.IsInstanceOfType(terminal.buscador, terminal.buscador.GetType());
        }
    }
}
