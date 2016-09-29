using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using LibreriaClasesPoi;
using Repositorio;
using AlmacenadorBusquedas;
using Procesos;
using CoordenadaGeografica;

namespace Consola
{
    public class TerminalConsola
    {

        //Atributos
        private string nombre;
        private Coordenada coordenada;
        private int comuna;
        public Buscador buscador;
        private string  mailAdministrador;
        private string usuarioActivo;
        private int duracionMaximaDeBusqueda;
        private bool usuarioCuentaConPrivilegiosEspeciales;

        //Setters y getters
        public void setCoordenada(Coordenada coordenadaDeTerminal) { this.coordenada = coordenadaDeTerminal; }
        public Coordenada getCoordenada() { return this.coordenada; }

        public void setMailAdministrador(string administradorDeTerminal) { this.mailAdministrador = administradorDeTerminal; }
        public string getMailAdministrador() { return this.mailAdministrador; }

        public void setUsuarioActivo(string usuario) { this.usuarioActivo = usuario; }
        public string getUsuarioActivo() { return this.usuarioActivo; }

        public void setDuracionMaximaDeBusqueda(int duracionMaxima) { this.duracionMaximaDeBusqueda = duracionMaxima; }
        public int getDuracionMaxcimaDeBusqueda() { return this.duracionMaximaDeBusqueda; }

        public void setUsuarioCuentaConPrivilegiosEspeciales(bool valor) { this.usuarioCuentaConPrivilegiosEspeciales = valor; }
        public bool getUsuarioCuentaConPrivilegiosEspeciales() { return this.usuarioCuentaConPrivilegiosEspeciales; }

        //Constructor
        public TerminalConsola(string nombreTerminal, int comuna)
        {
            this.nombre = nombreTerminal;
            this.comuna = comuna;
            this.duracionMaximaDeBusqueda = 50;
            this.buscador = new Buscador();
        }


        //METODOS PRINCIPALES//

        //* @name: estaDisponible(POI poi)
        //* @decryp: recibe por parámetro un POI y retorna un bool: 
        //* verdadero si está disponible en el momento de la consulta, falso caso contrario.
        public bool estaDisponible(POI puntoDeInteres)
        {
            DateTime fechaYhoraActual = DateTime.Now;
            return puntoDeInteres.estaDisponible(fechaYhoraActual);
        }

        //* @name: buscar(string criterio)
        //* @decryp: recibe un string criterio, y retorna una lista de POIS que cumplan con la concidencia.
        //* ademas, si la búsqueda demora más de lo permitido, se da aviso por mail al administrador. Luego 
        //* se almacena los datos del usuario, los datos obtenidos y el horario en que se realizó la acción.
        public List<POI> buscar(string criterio)
        {
            //Se declara e inicializa el temporizador
            Stopwatch temporizador;
            temporizador = Stopwatch.StartNew();

            //Se realiza la búsqueda
            List<POI> resultadoObtenido = buscador.find(criterio);

            //Se detiene el temporizador y se verifica si necesita notificar al administrador
            int segundosDemorados = temporizador.Elapsed.Seconds;
            AdministradorDeProcesos.notificarSiEsNecesario(segundosDemorados, this.getDuracionMaxcimaDeBusqueda(), this.getMailAdministrador());

            //Continúa el flujo normal
            AlmacenadorDeBusquedas.almacenarBusqueda(getUsuarioActivo(), criterio, resultadoObtenido, DateTime.Now);
            return resultadoObtenido;
        }

        //* @name: loggearUsuario(Usuario usser)
        //* @decryp: recibe un usuario y lo settea como usuario activo.
        //* Ademas verifica si el usser activo es administrador, y en caso de serlo settea
        //* la propiedad de usuarioCuentaConPrivilegiosEspeciales a verdadero.
        public void loggearUsuario(string usuario)
        {
            setUsuarioActivo(usuario);
            
        }

        //* @name: cerrarSesion()
        //* @decryp: settea el usuario activo a "null"
        public void cerrarSesion()
        {
            this.setUsuarioActivo(null);
        }

        public void cerrar()
        {
            buscador.cerrar();
        }
                            //METODOS SECUNDARIOS//
        public List<string> mappearNombresPois(List<POI> pois)
        {

            List<string> nombres = new List<string>();
            foreach (POI poi in pois)
            {
                nombres.Add(poi.getNombre());
            }
            return nombres;
        }
    }
}
