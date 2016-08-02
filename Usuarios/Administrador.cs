using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using Procesos;



namespace Usuarios
{
    public class Administrador:Usuario
    {
        //Atributos
        private int numeroDeComuna;
        private List<Proceso> procesos;

        //Setters y getters

        public void setNumeroComuna(int numeroComuna) { this.numeroDeComuna = numeroComuna; }
        public int getNumeroComuna() { return this.numeroDeComuna; }


        //Constructores
        public Administrador() { this.procesos = new List<Proceso>(); }
        public Administrador(string nombreCompleto, int numeroDeContacto, string direccion)
        {
            this.procesos = new List<Proceso>();
            setNombreCompleto(nombreCompleto);
            setNumeroDeContacto(numeroDeContacto);
            setDireccion(direccion);
            
        }

        //Metodos
        public override bool esAdministrador() { return true; }

    }
}
