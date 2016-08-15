using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using Repositorio;
using OrigenesDeDatos;

namespace Procesos
{
    public class BajaDePois: Proceso
    {
        //Atributos
        private RepositorioDePois repositorio;

        //Constructor
        public BajaDePois()
        {
            init();
            this.repositorio = RepositorioDePois.getInstance();
            this.setNombreDelProceso("baja de pois");
        }

        //Metodos
        public void darDeBajaSiEsNecesario(POI poi)
        {
            if (poi.estaActivo())
            {
                noHacerNada();
            }
            else
            {
                borrar(poi);
                cambiarEstadoSiEsNecesario(poi);
            }
        }

        private void noHacerNada() { }
        private void borrar(POI poi)
        {
            this.repositorio.localOrigin.borrar(poi);
        }

        private void cambiarEstadoSiEsNecesario(POI poi)
        {
            if (repositorio.localOrigin.verificarExistencia(poi.getNombre()))
            {
                this.getEstado().cambiarEstado();
                this.getEstado().manipularResultado();
            }
        }

        //Método polimórfico
        public override void ejecutar(string mailDelUsuario)
        {
            setMailDelUsserQueEjecuta(mailDelUsuario);
            List<POI> listPoi = repositorio.localOrigin.getPois();
            foreach(POI poi in listPoi)
            {
                darDeBajaSiEsNecesario(poi);
            }
            
        }


    }
}
