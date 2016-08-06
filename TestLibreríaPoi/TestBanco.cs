using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaClasesPoi;

namespace TestLibreríaPoi
{
    [TestClass]
    public class TestBanco
    {
        Banco bancoNacion = new Banco("banco nacion");

        public void init()
        {
            
            bancoNacion.agregarPalabraClave("banco nacion", "banco", "efectivo", "cambio", "dolar", "peso");
            bancoNacion.agregarServicioSinLimiteHorario("cobro cheques");
            bancoNacion.agregarServicioSinLimiteHorario("depositos");
            bancoNacion.agregarServicioSinLimiteHorario("extracciones");
            
        }

        [TestMethod]
        public void BancoCumpleCriterioDeBusqueda()
        {
            init();
            Assert.IsTrue(bancoNacion.buscarCoincidencia("banco"));
        }
    }
}
