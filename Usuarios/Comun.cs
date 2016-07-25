using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;


namespace Usuarios
{
    public class Comun:Usuario
    {
        //Atributos
        private String nombreCompleto;
        private String direccion;
        private int numeroDecontacto;
        private int idUsuario;

        //Setters y getters
        public void setNombreCompleto(string nombreCompleto) { this.nombreCompleto = nombreCompleto; }
        public string getNombreCompleto() { return this.nombreCompleto; }

        public void setDireccion(string direccion) { this.direccion = direccion; }
        public string getDireccion() { return this.direccion; }

        public void setNumeroDeContacto(int numero) { this.numeroDecontacto = numero; }
        public int getNumeroDeContacto() { return this.numeroDecontacto; }

        public void setIdUsuario(int numero) { this.idUsuario = numero; }
        public int getIdUsuario() { return this.idUsuario; }

        //Constructor
        public Comun(string nombreCompleto, int numeroDeContacto, string direccion)
        {
            setNombreCompleto(nombreCompleto);
            setNumeroDeContacto(numeroDeContacto);
            setDireccion(direccion);
        }

   
    }
}
