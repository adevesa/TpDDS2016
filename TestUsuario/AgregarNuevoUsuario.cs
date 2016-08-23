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
        TerminalConsola terminalCentral = new TerminalConsola("terminal central", 1);


        [TestMethod]
        public void CrearAdministrador()
        {
            //*Primero se loggea a un administrador quien tiene permiso de crear admins
            gestor.loggearUsuarioEn("ezequiel_escobar", terminalCentral);
            gestor.crearUsuario("administrador","juan_pedro", "juan pedro valenzuela","juanpe@gmail.com");

            Assert.IsTrue(gestor.mapearNombresDeUsuarios().Contains("juan pedro valenzuela"));
        }

        [TestMethod]
        public void LoggearUsuarioEnTerminalPorNombre()
        {
            string usuarioDePrueba = "ezequiel_escobar";
            gestor.loggearUsuarioEn(usuarioDePrueba, terminalCentral);
            Assert.IsTrue(terminalCentral.getUsuarioActivo() == usuarioDePrueba);
        }

        [TestMethod]
        public void CambiarUsserActivo()
        {
            string usuarioDePrueba1 = "ezequiel_escobar";
            gestor.loggearUsuarioEn(usuarioDePrueba1, terminalCentral);
            Assert.IsTrue(terminalCentral.getUsuarioActivo() == usuarioDePrueba1);

            string usuarioDePrueba2 = "agus_grec";
            gestor.loggearUsuarioEn(usuarioDePrueba2, terminalCentral);
            Assert.IsTrue(terminalCentral.getUsuarioActivo() == usuarioDePrueba2);



        }
    }
}
