using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaClasesPoi;

namespace TestLibreríaPoi
{
    [TestClass]
    public class TestLocalComercial
    {
        LocalComercial abastoShopping = new LocalComercial(1, "abasto shopping", "avenida corrientes 3247", new Coordenada(-34.6034261, -58.4109124));
        LocalComercial galeriaJardin = new LocalComercial(2, "galeria jardin", "florida 537", new Coordenada(-34.6016993, -58.3751937));
        LocalComercial mcDonaldCordoba = new LocalComercial(3, "mc donald cordoba", "avenida córdoba 1188", new Coordenada(-34.59458879999999, -58.4124393));

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

            Assert.IsTrue(abastoShopping.BuscarCoincidencia("compras"));
            Assert.IsTrue(abastoShopping.BuscarCoincidencia("abasto shopping"));
            Assert.IsTrue(galeriaJardin.BuscarCoincidencia("ventas"));
        }
    }
}
