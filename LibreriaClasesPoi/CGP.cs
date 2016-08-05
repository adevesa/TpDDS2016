using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordenadaGeografica;

namespace LibreriaClasesPoi
{
    public class CGP: PoiConServicios
    {
        //Atributos
        public string ZonasAledañas { get; set; }
        public string NombreDirector { get; set; }
        public string Telefono { get; set; }

        //Constructores
        public CGP(string nombre,string direccion, int comuna)
        {
            base.setDireccion(direccion);
            this.setComuna(comuna);
            base.initService(nombre);
            
        }

        public CGP(int numeroComuna, string domicilio)
        {
            
            setDireccion(domicilio);
            base.initService("sin nombre");
            this.setComuna(numeroComuna);

        }

        //Métodos
        //Cercanía
        public override bool cercanoDe(POI poi)
        { return (this.getComuna() == poi.getComuna()); }

        
        

    }
}
