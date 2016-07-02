using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public class CGP: PoiConServicios
    {
        //CONSTRUCTOR//
        public CGP(int id,string nombre,Coordenada coordenadaa, Direccion suDireccion)
        {
            base.init(id, nombre, coordenadaa);
            base.agregarDireccion(suDireccion);
            base.initService();
        }
        
        //METODOS PRINCIPALES//
        //CERCANIA con otra Coordenada (Sea coordenada de otro POI o de Consola)//
        public override bool CercanoDe(Coordenada coordenadaDelOtroPunto, int comunaDelOtroPunto)
        { return (ZonaDeComuna == comunaDelOtroPunto); }

        
        

    }
}
