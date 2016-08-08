using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios;
using AccionesPorUsuarios;
using Procesos;

namespace UssersGestion
{
    public class GestorDeAcciones
    {
        private GestorDeUsuarios gestor;
        private List<Tuple<String,Accion>> historialDeUssers;

        public List<Tuple<String, Accion>> getHistorial() { return this.historialDeUssers; }

        //Constructor
        public GestorDeAcciones()
        {
            this.gestor = new GestorDeUsuarios();
            this.historialDeUssers = new List<Tuple<String, Accion>>();
        }

        public Usuario buscarUsuario(string nombreDeUsuario)
        {
            return this.gestor.buscarUsuario(nombreDeUsuario);
        }
        //* @name: buscarAccion(nombre)
        //* @decryp: recibe un string con el nombre de la acción buscada y otro con el nombre de usuario.
        //* Enlaza el nombre de usuario y de la accion buscada con la acción propia (objeto).
        public Accion buscarAccion(string nombreDeUsuario, string nombreDeAccion)
        {
            Usuario usser = gestor.buscarUsuario(nombreDeUsuario);
            return usser.buscarAccion(nombreDeAccion);
        }


        //* @name:agregarAccion(accion)
        //* @decryp: recibe una acción tipo accion y la agrega a la lista de acciones disponibles para ejecutar
        public void agregarAccionA(string nombreDeUsuario, Accion accion)
        {
            Usuario usser = gestor.buscarUsuario(nombreDeUsuario);
            usser.agregarAccion(accion);
        }


        //* @name: borrarAccion()
        //* @decryp: recibe el nombre de una accion y la elimina de la lista de acciones.
        public void borrarAccion(string nombreDeUsuario, string nombreDeAccion)
        {
            Usuario usser = gestor.buscarUsuario(nombreDeUsuario);
            Accion accionABorrar = usser.buscarAccion(nombreDeAccion);
            usser.borrarAccion(accionABorrar);
        }

        //* @name: actualizarAccionA(usuario, accion)
        //* @decryp: actualiza la acción recibida por parámetro que posee el usuario
        public void actualizarAccionA(string nombreDeUsuario, Accion accion)
        {
            borrarAccion(nombreDeUsuario, accion.getNombre());
            agregarAccionA(nombreDeUsuario, accion);
        }

        //* @name: guardarEstados
        //* @decryp: recibe la lista de acciones por usuario, y copia a la lista
        //* de historialDeUssers los estados de los usuarios antes de comenzar a cambiarlos.
        public void guardarEstados(List<Tuple<String, Accion>> acciones)
        {
            foreach (Tuple<String, Accion> accionPorUsuario in acciones)
            {
                Usuario usser = buscarUsuario(accionPorUsuario.Item1);
                Tuple<String, Accion> usserinfo= Tuple.Create<String, Accion>(usser.getNombreDeUsuario(), accionPorUsuario.Item2);
                historialDeUssers.Add(usserinfo);
            }  
        }
        
    
    }
}
