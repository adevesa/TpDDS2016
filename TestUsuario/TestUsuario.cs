using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UssersGestion;
using Usuarios;
using Consola;
using Repositorio;

namespace TestUsuario
{
    [TestClass]
    public class TestUsuario
    {
        private GestorDeUsuarios gestor;
        private TerminalConsola terminalCentral;

        private void init()
        {
            this.gestor = new GestorDeUsuarios();
            this.terminalCentral = new TerminalConsola("terminal central", 1);
        }

        [TestMethod]
        public void CrearAdministrador()
        {
            this.init();
            //*Primero se loggea a un administrador quien tiene permiso de crear admins
            gestor.loggearUsuarioEn("ezequiel_escobar","sueñoconoperativos", terminalCentral);
            gestor.crearUsuario("administrador","juan_pedro","juance", "juan pedro valenzuela","juanpe@gmail.com");

            Assert.IsTrue(gestor.mapearNombresDeUsuarios().Contains("juan pedro valenzuela"));
        }

        [TestMethod]
        public void LoggearUsuarioEnTerminalPorNombre()
        {
            this.init();
            string usuarioDePrueba = "ezequiel_escobar";
            string contraseñaUsser = "sueñoconoperativos";
            gestor.loggearUsuarioEn(usuarioDePrueba,contraseñaUsser, terminalCentral);
            Assert.IsTrue(terminalCentral.getUsuarioActivo() == usuarioDePrueba);
        }

        [TestMethod]
        public void CambiarUsserActivo()
        {
            this.init();
            string usuarioDePrueba1 = "ezequiel_escobar";
            string contraseñaUsser = "sueñoconoperativos";
            gestor.loggearUsuarioEn(usuarioDePrueba1, contraseñaUsser, terminalCentral);
            Assert.IsTrue(terminalCentral.getUsuarioActivo() == usuarioDePrueba1);

            string usuarioDePrueba2 = "agus_grec";
            string contraseñaUsser2 = "sueñoconjugar";
            gestor.loggearUsuarioEn(usuarioDePrueba2,contraseñaUsser2, terminalCentral);
            Assert.IsTrue(terminalCentral.getUsuarioActivo() == usuarioDePrueba2);
        }

        [TestMethod]
        public void EsAdministrador()
        {
            this.init();
            string usuarioDePrueba1 = "ezequiel_escobar";
            Assert.IsTrue(gestor.esAdmin(usuarioDePrueba1));

            string usuarioDePrueba2 = "agus_grec";
            Assert.IsFalse(gestor.esAdmin(usuarioDePrueba2));
        }
    }
}
