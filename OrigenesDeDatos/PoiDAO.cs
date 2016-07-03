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

        //Algunos pois locales//
        private List<Poi> basedPois()
        {
            List<Poi> listBased = new List<Poi>();

            //Locales comerciales//

            LocalComercial abastoShopping = new LocalComercial(1, "abasto shopping", "avenida corrientes 3247", new Coordenada(-34.6034261, -58.4109124));
            abastoShopping.agregarPalabraClave("compras", "distraccion", "cine", "comida", "ropa", "abasto shopping");
            listBased.Add(abastoShopping);
            LocalComercial galeriaJardin = new LocalComercial(2, "galeria jardin", "florida 537", new Coordenada(-34.6016993, -58.3751937));
            galeriaJardin.agregarPalabraClave("tecnologia", "computadoras", "computadora", "tablets", "notebooks", "bajos precios", "placa madre", "galeria jardin");
            listBased.Add(galeriaJardin);
            LocalComercial mcDonaldCordoba = new LocalComercial(3, "mc donald cordoba", "avenida córdoba 1188", new Coordenada(-34.59458879999999, -58.4124393));
            mcDonaldCordoba.agregarPalabraClave("comida", "comida rapida", "hamburguesas", "papas fritas", "doble cuarto de libra", "mc flurry", "mc donald");
            listBased.Add(mcDonaldCordoba);

            //Bancos//

            Banco bancoNacion = new Banco(4, "banco nacion", new Coordenada(-34.7437649, -58.393226));
            bancoNacion.agregarPalabraClave("banco nacion", "banco", "efectivo", "cambio", "dolar", "peso");
            bancoNacion.agregarServicios(new servicio("cobro cheques", new rango(10, 12, 12, 15, 0, 0)));
            bancoNacion.agregarServicios(new servicio("depositos", new rango(10, 12, 12, 15, 0, 0)));
            bancoNacion.agregarServicios(new servicio("extracciones", new rango(10, 12, 12, 15, 0, 0)));
            listBased.Add(bancoNacion);

            //Parada de colectivos//

            ParadaDeColectivo parada115Once = new ParadaDeColectivo(5, "parada 115 once", new Coordenada(-34.6083803, -58.4071322));
            parada115Once.agregarPalabraClave("parada 115 once", "115", "bondi", "colectivo");
            listBased.Add(parada115Once);
            ParadaDeColectivo parada100Obelisco = new ParadaDeColectivo(6, "parada 100 obelisco", new Coordenada(-34.6037389, -58.3815704));
            parada100Obelisco.agregarPalabraClave("parada 100 once", "100", "bondi", "colectivo");
            listBased.Add(parada100Obelisco);

            //CGPS//

            CGP cgpComunal5 = new CGP(6, "cgp comunal 5", new Coordenada(-34.6237384, -58.3958982), "sarandí 1273 almagro", 5);
            cgpComunal5.agregarPalabraClave("cgp comunal 5", "cgp", "centro de gestion y participacion", "comuna 5");
            listBased.Add(cgpComunal5);

            CGP cgpComunal1 = new CGP(7, "cgp comunal 1", new Coordenada(-34.6003536, -58.3868185), "uruguay 740 monserrat", 1);
            cgpComunal1.agregarPalabraClave("cgp comunal 1", "cgp", "centro de gestion y participacion", "comuna 1");
            listBased.Add(cgpComunal1);


            return listBased;
        }

        //Cargar pois bases//
        private void cargarPoisBasicos()
        {
            foreach (Poi unPoi in (this.basedPois()))
            {
                this.crear(unPoi);
            }
        }

        public List<string> mappearNombresPois(List<Poi> pois)
        {

            List<string> nombres = new List<string>();
            foreach (Poi poi in pois)
            {
                nombres.Add(poi.Nombre);
            }
            return nombres;






        }
    }
}
