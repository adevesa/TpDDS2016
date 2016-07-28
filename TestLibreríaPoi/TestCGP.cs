using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaClasesPoi;

namespace TestLibreríaPoi
{
    [TestClass]
    public class TestCGP
    {
        CGP cgpComunal5 = new CGP(6, "cgp comunal 5", "sarandí 1273 almagro", 5);
        CGP cgpComunal1 = new CGP(7, "cgp comunal 1","uruguay 740 monserrat", 1);

        public void init()
        {
            cgpComunal5.agregarPalabraClave("cgp comunal 5", "cgp", "centro de gestion y participacion", "comuna 5");
    
            cgpComunal1.agregarPalabraClave("cgp comunal 1", "cgp", "centro de gestion y participacion", "comuna 1");
        }
        [TestMethod]
        public void CgpCumpleCriterioDeBusqueda()
        {
            init();
            Assert.IsTrue(cgpComunal1.buscarCoincidencia("centro de gestion y participacion"));
            Assert.IsTrue(cgpComunal1.buscarCoincidencia("comuna 1"));

            Assert.IsFalse(cgpComunal5.buscarCoincidencia("comuna 1"));
        }
    }
}
