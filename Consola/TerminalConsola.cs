using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using Repositorio;
using Usuarios;
using AlmacenadorBusquedas;

namespace Consola
{
    public class TerminalConsola
    {

        //ATRIBUTOS//
        private string nombre;
        private Coordenada coordenada;
        private int comuna;
        private Buscador buscador;
        private Administrador administrador;
        private Usuario usuarioActivo;

        //Setters y getters//
        public void setCoordenada(Coordenada coordenadaDeTerminal) { this.coordenada = coordenadaDeTerminal; }
        public Coordenada getCoordenada() { return this.coordenada; }

        public void setAdministrador(Administrador administradorDeTerminal) { this.administrador = administradorDeTerminal; }
        public Administrador getAdministrador() { return this.administrador; }

        public void setUsuarioActivo(Usuario usuario) { this.usuarioActivo = usuario; }
        public Usuario getUsuarioActivo() { return this.usuarioActivo; }

        //CONSTRUCTOR//
        public TerminalConsola(string nombreTerminal, int comuna, Buscador buscador)
        {
            this.nombre = nombreTerminal;
            this.comuna = comuna;
            this.buscador = buscador;

        }


                            //METODOS PRINCIPALES//

        public bool estaDisponible(Poi puntoDeInteres)
        {
            DateTime fechaYhoraActual = DateTime.Now;
            return puntoDeInteres.EstaDisponible(fechaYhoraActual);
        }

        public List<Poi> buscar(string criterio)
        {
            List<Poi> resultadoObtenido = buscador.find(criterio);
            AlmacenadorDeBusquedas.almacenarBusqueda(getUsuarioActivo().getNombreCompleto(), criterio, resultadoObtenido, DateTime.Now);
            return resultadoObtenido;
        }

        public void loggearUsuario(Usuario usuario)
        {
            setUsuarioActivo(usuario);
        }

                            //METODOS SECUNDARIOS//
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
