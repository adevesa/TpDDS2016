using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Consola;
using LibreriaClasesPoi;
using FuenteDeDatos;
using OrigenesDeDatos;
using Repositorio;
using UssersGestion;
using Usuarios;


namespace TestTerminalConsola
{
    [TestClass]
    public class BuscarEnTerminal
    {
        TerminalConsola terminal = new TerminalConsola("terminal la esquina de medrano", 5);
        GestorDeUsuarios gestor = new GestorDeUsuarios();

        private void iniciar()
        {
            Usuario admin = gestor.buscarUsuario("ezequiel_escobar");
            terminal.setMailAdministrador(admin.getMail());
            terminal.setDuracionMaximaDeBusqueda(4);
            string usuarioDePrueba = "agus_grec";
            string contraseñaDelUsuarioDePrueba = "sueñoconjugar";
            gestor.loggearUsuarioEn(usuarioDePrueba,contraseñaDelUsuarioDePrueba, terminal);
        }

        [TestMethod]
        public void BuscarColectivosEnTerminal()
        {
            iniciar();

            List<POI> listaPoisBuscados = terminal.buscar("colectivo");
            List<string> listaNombresPoisBuscados = terminal.mappearNombresPois(listaPoisBuscados);

            Assert.IsTrue(listaNombresPoisBuscados.Contains("parada 115 once"));
            Assert.IsTrue(listaNombresPoisBuscados.Contains("parada 100 obelisco"));

            Assert.IsFalse(listaNombresPoisBuscados.Contains("abasto shopping"));
        }

        [TestMethod]
        public void BuscarLocalesEnTerminal()
        {
            iniciar();
            List<POI> listaPoisBuscados = terminal.buscar("tablets");
            List<string> listaNombresPoisBuscados = terminal.mappearNombresPois(listaPoisBuscados);

            Assert.IsTrue(listaNombresPoisBuscados.Contains("galeria jardin"));

            Assert.IsFalse(listaNombresPoisBuscados.Contains("abasto shopping"));
        }
    }
}
