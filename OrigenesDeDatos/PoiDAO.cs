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
        public List<POI> pois;

        //Constructor
        public PoiDAO()
        {
            this.pois = new List<POI>();
            cargarPoisBasicos();
        }

        //Crear Poi//
        public void crear(POI unPoi)
        {
            pois.Add(unPoi);
        }

        //Actualizar Poi//
        public void actualizar(POI unPoi)
        {
            borrar(unPoi.getId());
            crear(unPoi);
        }

        //Borrar un Poi//
        public void borrar(int index)
        {
            int indexBuscado = pois.FindIndex(poiLocal => poiLocal.getId().Equals(index));
            pois.RemoveAt(indexBuscado);
        }

        public void borrar2(POI unPoi)
        {
            pois.Remove(unPoi);
        }

        //Algunos pois locales//
       private List<POI> basedPois()
        {
            List<POI> listBased = new List<POI>();

            //Locales comerciales//

            LocalComercial abastoShopping = new LocalComercial("abasto shopping", "avenida corrientes 3247");
            abastoShopping.agregarPalabraClave("compras", "distraccion", "cine", "comida", "ropa", "abasto shopping");
            listBased.Add(abastoShopping);
            LocalComercial galeriaJardin = new LocalComercial("galeria jardin", "florida 537");
            galeriaJardin.agregarPalabraClave("tecnologia", "computadoras", "computadora", "tablets", "notebooks", "bajos precios", "placa madre", "galeria jardin");
            listBased.Add(galeriaJardin);
            LocalComercial mcDonaldCordoba = new LocalComercial( "mc donald cordoba", "avenida córdoba 1188");
            mcDonaldCordoba.agregarPalabraClave("comida", "comida rapida", "hamburguesas", "papas fritas", "doble cuarto de libra", "mc flurry", "mc donald");
            listBased.Add(mcDonaldCordoba);

            //Bancos//

            Banco bancoNacion = new Banco( "banco nacion");
            bancoNacion.agregarPalabraClave("banco nacion", "banco", "efectivo", "cambio", "dolar", "peso");
            bancoNacion.agregarServicioSinLimiteHorario("cobro cheques");
            bancoNacion.agregarServicioSinLimiteHorario("depositos");
            bancoNacion.agregarServicioSinLimiteHorario("extracciones");
            listBased.Add(bancoNacion);

            //Parada de colectivos//

            ParadaDeColectivo parada115Once = new ParadaDeColectivo("parada 115 once");
            parada115Once.agregarPalabraClave("parada 115 once", "115", "bondi", "colectivo");
            listBased.Add(parada115Once);
            ParadaDeColectivo parada100Obelisco = new ParadaDeColectivo("parada 100 obelisco");
            parada100Obelisco.agregarPalabraClave("parada 100 once", "100", "bondi", "colectivo");
            listBased.Add(parada100Obelisco);

            //CGPS//

            CGP cgpComunal5 = new CGP("cgp comunal 5", "sarandí 1273 almagro", 5);
            cgpComunal5.agregarPalabraClave("cgp comunal 5", "cgp", "centro de gestion y participacion", "comuna 5");
            cgpComunal5.crearServicio("consultas afip");
            cgpComunal5.agregarHorarioDeAtencionAServicio("consultas afip", "lunes", "mañana", 8, 14);
            listBased.Add(cgpComunal5);

            CGP cgpComunal1 = new CGP("cgp comunal 1", "uruguay 740 monserrat", 1);
            cgpComunal1.agregarPalabraClave("cgp comunal 1", "cgp", "centro de gestion y participacion", "comuna 1");
            cgpComunal1.crearServicio("consultas afip");
            cgpComunal1.agregarHorarioDeAtencionAServicio("consultas afip", "lunes", "mañana", 8, 14);
            listBased.Add(cgpComunal1);


            return listBased;
        }

        //Cargar pois bases//
        private void cargarPoisBasicos()
        {
            foreach (POI unPoi in (this.basedPois()))
            {
                this.crear(unPoi);
            }
        }

        public List<string> mappearNombresPois(List<POI> pois)
        {

            List<string> nombres = new List<string>();
            foreach (POI poi in pois)
            {
                nombres.Add(poi.getNombre());
            }
            return nombres;
        }

        public bool verificarExistencia(string nombreDelPoi)
        {
            List<string> nombreDePois = mappearNombresPois(pois);
            return nombreDePois.Contains(nombreDelPoi);
        }

        public POI obtenerPoiLlamado(string nombreDelPoiBuscado)
        {
            POI poiBuscado = this.pois.Find(unPoi => unPoi.getNombre() == nombreDelPoiBuscado);
            return poiBuscado;
        }
    }
}
