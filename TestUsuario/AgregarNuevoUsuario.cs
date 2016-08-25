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
            gestor.loggearUsuarioEn("ezequiel_escobar","sueñoconoperativos", terminalCentral);
            gestor.crearUsuario("administrador","juan_pedro","juance", "juan pedro valenzuela","juanpe@gmail.com");

            Assert.IsTrue(gestor.mapearNombresDeUsuarios().Contains("juan pedro valenzuela"));
        }

        [TestMethod]
        public void LoggearUsuarioEnTerminalPorNombre()
        {
            string usuarioDePrueba = "ezequiel_escobar";
            string contraseñaUsser = "sueñoconoperativos";
            gestor.loggearUsuarioEn(usuarioDePrueba,contraseñaUsser, terminalCentral);
            Assert.IsTrue(terminalCentral.getUsuarioActivo() == usuarioDePrueba);
        }

        [TestMethod]
        public void CambiarUsserActivo()
        {
            string usuarioDePrueba1 = "ezequiel_escobar";
            string contraseñaUsser = "sueñoconoperativos";
            gestor.loggearUsuarioEn(usuarioDePrueba1, contraseñaUsser, terminalCentral);
            Assert.IsTrue(terminalCentral.getUsuarioActivo() == usuarioDePrueba1);

            string usuarioDePrueba2 = "agus_grec";
            string contraseñaUsser2 = "sueñoconjugar";
            gestor.loggearUsuarioEn(usuarioDePrueba2,contraseñaUsser2, terminalCentral);
            Assert.IsTrue(terminalCentral.getUsuarioActivo() == usuarioDePrueba2);



        }
    }
}
