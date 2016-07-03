using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrigenesDeDatos;
using LibreriaClasesPoi;
using FuenteDeDatos;

namespace TestOrigenLocal
{
    [TestClass]
    public class CreacionOrigenLocal
    {
        OrigenLocal origenLocal = new OrigenLocal();

        [TestMethod]
        public void OrigenLocalCreadoExitosamente()
        {
            Assert.IsInstanceOfType(origenLocal, origenLocal.GetType());
            Assert.IsInstanceOfType(origenLocal.dao, origenLocal.dao.GetType());
        }
    }
}
