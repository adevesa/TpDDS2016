using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using LibreriaClasesPoi;
using Repositorio;
using Usuarios;
using AlmacenadorBusquedas;
using Procesos;

namespace Consola
{
    public class TerminalConsola
    {

        //Atributos
        private string nombre;
        private Coordenada coordenada;
        private int comuna;
        private Buscador buscador;
        private Usuario administrador;
        private Usuario usuarioActivo;
        private int duracionMaximaDeBusqueda;

        //Setters y getters
        public void setCoordenada(Coordenada coordenadaDeTerminal) { this.coordenada = coordenadaDeTerminal; }
        public Coordenada getCoordenada() { return this.coordenada; }

        public void setAdministrador(Usuario administradorDeTerminal) { this.administrador = administradorDeTerminal; }
        public Usuario getAdministrador() { return this.administrador; }

        public void setUsuarioActivo(Usuario usuario) { this.usuarioActivo = usuario; }
        public Usuario getUsuarioActivo() { return this.usuarioActivo; }

        public void setDuracionMaximaDeBusqueda(int duracionMaxima) { this.duracionMaximaDeBusqueda = duracionMaxima; }
        public int getDuracionMaxcimaDeBusqueda() { return this.duracionMaximaDeBusqueda; }

        //Constructor
        public TerminalConsola(string nombreTerminal, int comuna)
        {
            this.nombre = nombreTerminal;
            this.comuna = comuna;
            this.buscador = new Buscador();

        }


                            //METODOS PRINCIPALES//

        public bool estaDisponible(Poi puntoDeInteres)
        {
            DateTime fechaYhoraActual = DateTime.Now;
            return puntoDeInteres.EstaDisponible(fechaYhoraActual);
        }

        public List<Poi> buscar(string criterio)
        {
            //Se declara e inicializa el temporizador
            Stopwatch temporizador;
            temporizador = Stopwatch.StartNew();

            //Se realiza la búsqueda
            List<Poi> resultadoObtenido = buscador.find(criterio);

            //Se detiene el temporizador y se verifica si necesita notificar al administrador
            int segundosDemorados = temporizador.Elapsed.Seconds;
            AdministradorDeProcesos.notificarSiEsNecesario(segundosDemorados, this.getDuracionMaxcimaDeBusqueda(), this.getAdministrador().getMail());

            //Continúa el flujo normal
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
