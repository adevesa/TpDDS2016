using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaClasesPoi;
using OrigenesDeDatos;
using FuenteDeDatos;
using Repositorio;

namespace TestRepositorio
{
    [TestClass]
    public class CreacionRepositorio
    {
        RepositorioDePois repositorio = RepositorioDePois.getInstance();

        [TestMethod]
        public void RepositorioCreadoExitosamente()
        {
            Assert.IsInstanceOfType(repositorio, repositorio.GetType());
            Assert.IsInstanceOfType(repositorio.localOrigin, repositorio.localOrigin.GetType());
        }
    }
}
