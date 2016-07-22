using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using Consola;


namespace Usuarios
{
    public class Administrador:Usuario
    {
        //Atributos
        private SearchStorer almacenadorDeBusquedas;
        private TerminalConsola terminal;
        private String nombreCompleto;
        private String direccion;
        private int numeroDecontacto;
        private int idUsuario;
        private int numeroDeComuna;

        //Setters y getters
        public SearchStorer getAlmacenador() { return almacenadorDeBusquedas; }
        private void setAlmacenador(SearchStorer almacenador)
        {
            this.almacenadorDeBusquedas = almacenador;
        }

        public void setTerminal(TerminalConsola terminal)
        {
            this.terminal = terminal;
        }
        public TerminalConsola getTerminal() { return this.terminal; }

        public void setNombreCompleto(string nombreCompleto) { this.nombreCompleto = nombreCompleto; }
        public string getNombreCompleto() { return this.nombreCompleto; }

        public void setDireccion(string direccion) { this.direccion = direccion; }
        public string getDireccion() { return this.direccion; }

        public void setNumeroDeContacto(double numero) { this.numeroDecontacto = numero; }
        public int getNumeroDeContacto() { return this.numeroDecontacto; }

        public void setIdUsuario(int numero) { this.idUsuario = numero; }
        public int getIdUsuario() { return this.idUsuario; }


        //Constructor
        public Administrador(string nombreCompleto, double numeroDeContacto, string direccion, int numeroDeComuna)
        {
            setNombreCompleto(nombreCompleto);
            setNumeroDeContacto(numeroDeContacto);
            setDireccion(direccion);
            this.numeroDeComuna = numeroDeComuna;
        }


        //Metodos
        public void loggearEn(TerminalConsola terminal)
        {
            setTerminal(terminal);
        }

        private void almacenarBusqueda(string palabraClave, List<Poi> resultado)
        {

        }


        public  List<Poi> buscar(string palabraClave)
        {
            List<Poi> resultado;
            resultado = getTerminal().buscar(palabraClave);
            almacenarBusqueda(palabraClave, resultado);
            return resultado;
        }

        
    }
}
