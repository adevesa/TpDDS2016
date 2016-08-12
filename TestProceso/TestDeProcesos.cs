using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaClasesPoi;
using Procesos;
using Procesos.ManejoDeErrores;
using FuenteDeDatos;
using OrigenesDeDatos;
using Repositorio;

namespace TestProceso
{
    [TestClass]
    public class TestDeProcesos
    {
            //Instancias necesarias para los test
        private Origenes origenLocal;

        //Algunos Locales instanciados
        LocalComercial coto = new LocalComercial("coto", "agüero 616");
        LocalComercial jumbo = new LocalComercial("jumbo", "avenida fernandez de la Cruz 4602");

        //Algunas fechas de baja de POI
        DateTime fechaDeBaja1 = new DateTime(1995, 6, 15, 12, 0, 0);
        DateTime fechaDeBaja2 = new DateTime(2030, 12, 20, 12, 0, 0);

        //Procesos y errores instanciados
        BajaDePois bajaDePois = new BajaDePois();
        ErrorGestion comunicarFalloPorMail = new ComunicarFalloPorMail("grecolate@gmail.com");
        
        ActualizacionDeLocalesComerciales actualizacionDeLocalesComerciales = new ActualizacionDeLocalesComerciales();
        ErrorGestion reintentar = new Reintentar(2);

        //Initialize
        private void init()
        {
            this.origenLocal = new OrigenLocal();
            bajaDePois.setTipoDeManejoDeError(comunicarFalloPorMail);
            actualizacionDeLocalesComerciales.setTipoDeManejoDeError(reintentar);
        }

        [TestMethod]
        public void TestPOIActivo()
        {
            coto.setFechaDeBaja(fechaDeBaja2);

            Assert.IsTrue(coto.estaActivo());
        }

        [TestMethod]
        public void TestPOIInactivo()
        {
            coto.setFechaDeBaja(fechaDeBaja1);

            Assert.IsFalse(coto.estaActivo());
        }

        [TestMethod]
        public void BajaDePoisDejaUnPOI()
        {
            init();
            coto.setFechaDeBaja(fechaDeBaja2);
            origenLocal.agregar(coto);
            bajaDePois.darDeBajaSiEsNecesario(coto);
            Assert.IsTrue(origenLocal.verificarExistencia("coto"));
        }

        [TestMethod]
        public void BajaDePoisQuitaUnPOI()
        {
            init();
            jumbo.setFechaDeBaja(fechaDeBaja1);
            origenLocal.agregar(jumbo);
            bajaDePois.darDeBajaSiEsNecesario(jumbo); 
            //origenLocal.borrar(jumbo);
            Assert.IsFalse(origenLocal.verificarExistencia("jumbo")); 
            //Assert.IsFalse(jumbo.estaActivo());
        }

       // [TestMethod]
       // public void ActualizarLocalComercialInexistente()
       // { 
        //    jumbo.Nombre = "jumbo";
       //     actualizacionDeLocalesComerciales.actualizarLocalComercial("jumbo", );
       //
       //     Assert.IsTrue(ListaDePois.verificarExistencia("jumbo"));

        //}

    }
}
