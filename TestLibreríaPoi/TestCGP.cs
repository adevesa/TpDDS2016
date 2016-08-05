using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaClasesPoi;

namespace TestLibreríaPoi
{
    [TestClass]
    public class TestCGP
    {
        CGP cgpComunal5 = new CGP("cgp comunal 5", "sarandí 1273 almagro", 5);
        CGP cgpComunal1 = new CGP("cgp comunal 1","uruguay 740 monserrat", 1);

        public void init()
        {
            cgpComunal5.agregarPalabraClave("cgp comunal 5", "cgp", "centro de gestion y participacion", "comuna 5");
            cgpComunal5.agregarPalabraClave("cgp comunal 5", "cgp", "centro de gestion y participacion", "comuna 5");
            cgpComunal5.crearServicio("consultas afip");
            cgpComunal5.agregarHorarioDeAtencionAServicio("consultas afip", "lunes", "mañana", 8, 14);


            cgpComunal1.agregarPalabraClave("cgp comunal 1", "cgp", "centro de gestion y participacion", "comuna 1");
            cgpComunal1.agregarPalabraClave("cgp comunal 1", "cgp", "centro de gestion y participacion", "comuna 1");
            cgpComunal1.crearServicio("consultas afip");
            cgpComunal1.agregarHorarioDeAtencionAServicio("consultas afip", "lunes", "mañana", 8, 14);
        }

        [TestMethod]
        public void CgpCumpleCriterioDeBusqueda()
        {
            init();

            Assert.IsTrue(cgpComunal1.buscarCoincidencia("consultas afip"));
            
        }
    }
}
