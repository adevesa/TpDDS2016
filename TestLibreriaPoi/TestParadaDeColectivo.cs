using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LibreriaClasesPoi;

namespace TestLibreriaPoi
{
    [TestClass]
    public class ParadaDeColectivoTest
    {
        //Crear Lista de strings//
        public List<string> CrearListString(params string[] palabras)
        {
            List<string> lista = new List<string>();
            foreach (string palabra in palabras)
            { lista.Add(palabra); }
            return lista;
        }

        public void estaDisponible()
        {   //CREAMOS UNA PARADA 114//
            ParadaDeColectivo parada114 = new ParadaDeColectivo("114", new Coordenada(100, 600), new Direccion(200, "Av. Cordoba"), CrearListString("114", "parada", "colectivo"), new Dictionary<string, rango>());
            Assert.AreEqual(true, parada114.EstaDisponible(DateTime.Now));
        }
    }
}
