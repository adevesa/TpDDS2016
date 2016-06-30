using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public class PoiCollection:PoiBDO
    {
        public List<Poi> Pois = new List<Poi>();


       

        //Constructor -> agrega pois iniciales//
        public PoiCollection()
        {
            //~Creamos pois//

            Dictionary<string, rango> horariosDeAbasto = new Dictionary<string, rango>;

            Poi abastoShopping = new LocalComercial("abasto shopping", new Direccion(3247, "Avenida Corrientes"), CrearListString("cine", "shopping", "diversion"), CrearListString("paseo","compras","shopping"), );


            //Agregamos pois//
            guardarPoi(abastoShopping);
        }

        public override void guardarPoi(Poi unPoi)
        {
            Pois.Add(unPoi);
        }

        //Método para crear lista de strings//
        public List<string> CrearListString(params string[] palabras)
        {
            List<string> lista = new List<string>();
            foreach (string palabra in palabras)
            { lista.Add(palabra); }
            return lista;
        }

        //Método para crear un Diccionario de rangos horarios//
        public Dictionary<string, rango> CrearHorariosDeAtencion(Tuple<string , string, int, int, int, int, int, int>)
        {
            
        }
    }
}
