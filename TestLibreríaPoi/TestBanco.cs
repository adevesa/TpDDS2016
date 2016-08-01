using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaClasesPoi;

namespace TestLibreríaPoi
{
    [TestClass]
    public class TestBanco
    {
        Banco bancoNacion = new Banco(4, "banco nacion");

        public void init()
        {
            
            bancoNacion.agregarPalabraClave("banco nacion", "banco", "efectivo", "cambio", "dolar", "peso");
            bancoNacion.agregarServicios("cobro cheques");
            bancoNacion.agregarServicios("depositos");
            bancoNacion.agregarServicios("extracciones");
            
        }

        [TestMethod]
        public void BancoCumpleCriterioDeBusqueda()
        {
            init();
            Assert.IsTrue(bancoNacion.buscarCoincidencia("depositos"));
        }
    }
}
