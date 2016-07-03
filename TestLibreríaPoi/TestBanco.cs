using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaClasesPoi;

namespace TestLibreríaPoi
{
    [TestClass]
    public class TestBanco
    {
        Banco bancoNacion = new Banco(4, "banco nacion", new Coordenada(-34.7437649, -58.393226));

        public void init()
        {
            
            bancoNacion.agregarPalabraClave("banco nacion", "banco", "efectivo", "cambio", "dolar", "peso");
            bancoNacion.agregarServicios(new servicio("cobro cheques", new rango(10, 12, 12, 15, 0, 0)));
            bancoNacion.agregarServicios(new servicio("depositos", new rango(10, 12, 12, 15, 0, 0)));
            bancoNacion.agregarServicios(new servicio("extracciones", new rango(10, 12, 12, 15, 0, 0)));
            
        }

        [TestMethod]
        public void BancoCumpleCriterioDeBusqueda()
        {
            init();
            Assert.IsTrue(bancoNacion.BuscarCoincidencia("depositos"));
        }
    }
}
