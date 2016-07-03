using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;


namespace OrigenesDeDatos
{
    public class PoiDAO
    {
        public List<Poi> pois;


        public PoiDAO()
        {
            this.pois = new List<Poi>();
            cargarPoisBasicos();
        }

        //Crear Poi//
        public void crear(Poi unPoi)
        {
            pois.Add(unPoi);
        }

        //Actualizar Poi//
        public void actualizar(Poi unPoi)
        {
            borrar(unPoi.Id);
            crear(unPoi);
        }

        //Borrar un Poi//
        public void borrar(int index)
        {
            int indexBuscado = pois.FindIndex(poiLocal => poiLocal.Id.Equals(index));
            pois.RemoveAt(indexBuscado);
        }

        //Cargar POIS base//
        private void cargarPoisBasicos()
        {
            LocalComercial abastoShopping = new LocalComercial(1, "abasto shopping", "avenida corrientes 3247", new Coordenada(-34.6034261, -58.4109124));
            abastoShopping.PalabrasClaves = crearListString("compras", "distraccion", "cine", "comida", "ropa", "abasto shopping");
            LocalComercial galeriaJardin = new LocalComercial(2, "galeri jardin", "florida 537", new Coordenada(-34.6016993, -58.3751937));
            galeriaJardin.PalabrasClaves = crearListString("tecnologia", "computadoras", "computadora", "tablets", "notebooks", "bajos precios", "placa madre", "galeria jardin");
            LocalComercial mcDonaldCordoba = new LocalComercial(3, "mc donald cordoba", "avenida córdoba 1188", new Coordenada(-34.59458879999999, -58.4124393));
            mcDonaldCordoba.PalabrasClaves = crearListString("comida", "comida rapida", "hamburguesas", "papas fritas", "doble cuarto de libra", "mc flurry", "mc donald");


            Banco bancoNacion = new Banco(4, "banco nacion", new Coordenada(-34.7437649, -58.393226));
            bancoNacion.PalabrasClaves = crearListString("banco nacion", "banco", "efectivo", "cambio", "dolar", "peso");
            bancoNacion.agregarServicios(new servicio("cobro cheques", new rango(10, 12, 12, 15, 0, 0)));
            bancoNacion.agregarServicios(new servicio("depositos", new rango(10, 12, 12, 15, 0, 0)));
            bancoNacion.agregarServicios(new servicio("extracciones", new rango(10, 12, 12, 15, 0, 0)));

            ParadaDeColectivo parada115 = new ParadaDeColectivo(5, "parada 115 once", new Coordenada(-34.6083803, -58.4071322)); 

        }

        //Crear list string//
        private List<string> crearListString(params string[] palabras)
        {
            List<string> lista = new List<string>();
            foreach(string palabra in palabras)
            {
                lista.Add(palabra);
            }
            return lista;
        }

    }
}
