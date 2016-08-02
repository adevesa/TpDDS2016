using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UssersGestion;
using Usuarios;
using Consola;
using Repositorio;

namespace TestUsuario
{
    [TestClass]
    public class AgregarNuevoUsuario
    {
        GestorDeUsuarios gestor = new GestorDeUsuarios();


        [TestMethod]
        public void CrearAdministrador()
        {
            gestor.crearUsuario(new Administrador(), "juan pedro valenzuela", 1133505660, "pueyrredon 4800");

            Assert.IsTrue(gestor.mapearNombresDeUsuarios().Contains("juan pedro valenzuela"));
        }

        TerminalConsola terminalCentral = new TerminalConsola("terminal central", 1);


        [TestMethod]
        public void LoggearUsuarioEnTerminalPorNombre()
        {
            string usuarioDePrueba = "ezequiel oscar escobar";
            gestor.loggearUsuarioEn(usuarioDePrueba, terminalCentral);
            Assert.IsTrue(terminalCentral.getUsuarioActivo() == usuarioDePrueba);
        }


        

        [TestMethod]
        public void CambiarUsserActivo()
        {
            string usuarioDePrueba1 = "ezequiel oscar escobar";
            gestor.loggearUsuarioEn(usuarioDePrueba1, terminalCentral);
            Assert.IsTrue(terminalCentral.getUsuarioActivo() == usuarioDePrueba1);

            string usuarioDePrueba2 = "agustin greco";
            gestor.loggearUsuarioEn(usuarioDePrueba2, terminalCentral);
            Assert.IsTrue(terminalCentral.getUsuarioActivo() == usuarioDePrueba2);



        }
    }
}
