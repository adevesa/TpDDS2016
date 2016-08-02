using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaClasesPoi;

namespace TestLibreríaPoi
{
    [TestClass]
    public class TestLocalComercial
    {
        LocalComercial abastoShopping = new LocalComercial("abasto shopping", "avenida corrientes 3247");
        LocalComercial galeriaJardin = new LocalComercial("galeria jardin", "florida 537");
        LocalComercial mcDonaldCordoba = new LocalComercial( "mc donald cordoba", "avenida córdoba 1188");

        public void init()
        {
            

            abastoShopping.agregarPalabraClave("compras", "distraccion", "cine", "comida", "ropa", "abasto shopping");
            abastoShopping.agregarRubro("comercio", "ventas");
            galeriaJardin.agregarPalabraClave("tecnologia", "computadoras", "computadora", "tablets", "notebooks", "bajos precios", "placa madre", "galeria jardin");
            galeriaJardin.agregarRubro("comercio", "ventas", "tecnologia");
            mcDonaldCordoba.agregarPalabraClave("comida", "comida rapida", "hamburguesas", "papas fritas", "doble cuarto de libra", "mc flurry", "mc donald");
            mcDonaldCordoba.agregarRubro("comida", "fast food");

        }


        [TestMethod]
        public void LocalComercialCumpleCriterioDeBusqueda()
        {
            this.init();

            Assert.IsTrue(abastoShopping.buscarCoincidencia("compras"));
            Assert.IsTrue(abastoShopping.buscarCoincidencia("abasto shopping"));
            Assert.IsTrue(galeriaJardin.buscarCoincidencia("ventas"));
        }
    }
}
