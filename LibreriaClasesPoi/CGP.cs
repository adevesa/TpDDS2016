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
        public string zonasAledañas { get; set; }
        public string nombreDirector { get; set; }
        public string telefono { get; set; }

        //Constructores
        public CGP(string nombre,string direccion, int comuna)
        {
            base.init(nombre);
            base.setDireccion(direccion);
            base.initService();
            this.setComuna(comuna);
        }

        public CGP(int numeroComuna, string domicilio)
        {
            
            setDireccion(domicilio);
            base.initService();
            this.setComuna(numeroComuna);

        }

        //Métodos
        //Cercanía
        public override bool cercanoDe(POI poi)
        { return (this.getComuna() == poi.getComuna()); }

        
        

    }
}
