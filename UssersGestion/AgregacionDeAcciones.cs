using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccionesPorUsuarios;
using Usuarios;
using Procesos;

namespace UssersGestion
{
    public class AgregacionDeAcciones : Proceso
    {
        private List<Tuple<String, Accion>> acciones;
        private GestorDeAcciones gestor;

        public void setListaDeAccionesPorUsuario(List<Tuple<String, Accion>> listaAccionesPorUsuario) { this.acciones = listaAccionesPorUsuario; }
        
        //Constructor
        public AgregacionDeAcciones()
        {
            setNombreDelProceso("agregar acciones para todos los usuarios");
            acciones = new List<Tuple<string, Accion>>();
            gestor = new GestorDeAcciones();
        }

        //Metodos
        public override int ejecutar()
        {
            gestor.guardarEstados(this.acciones);
            realizarAcciones(this.acciones);

            return 0;
        }

        private void realizarAcciones(List<Tuple<String, Accion>> acciones)
        {
            foreach (Tuple<String, Accion> accionPorUsuario in acciones)
            {
                agregarOActualizarAccion(accionPorUsuario.Item1, accionPorUsuario.Item2);
            }
        }

        private void agregarOActualizarAccion(string nombreDeUsuario, Accion accion)
        {
            Accion supuestaAccion = gestor.buscarAccion(nombreDeUsuario,accion.getNombre());
            if ( supuestaAccion != null)
            {
                gestor.actualizarAccionA(nombreDeUsuario, accion);
            }
                gestor.agregarAccionA(nombreDeUsuario, accion);
        }

        public void deshacer()
        {
            realizarAcciones(gestor.getHistorial());
        }

       


    }
}
