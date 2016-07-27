using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;



namespace Usuarios
{
    public class Administrador:Usuario
    {
        //Atributos
        private int numeroDeComuna;

        //Setters y getters

        public void setNumeroComuna(int numeroComuna) { this.numeroDeComuna = numeroComuna; }
        public int getNumeroComuna() { return this.numeroDeComuna; }


        //Constructores
        public Administrador() { }
        public Administrador(string nombreCompleto, int numeroDeContacto, string direccion)
        {
            setNombreCompleto(nombreCompleto);
            setNumeroDeContacto(numeroDeContacto);
            setDireccion(direccion);
            
        }


    }
}
