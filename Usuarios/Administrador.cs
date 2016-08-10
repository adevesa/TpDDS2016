using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using Procesos;
using Procesos.ManejoDeErrores;



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
        public Administrador() { this.procesos = new List<Proceso>(); init(); }
        public Administrador(string nombreCompleto, int numeroDeContacto, string direccion)
        {
            this.procesos = new List<Proceso>();
            setNombreCompleto(nombreCompleto);
            setNumeroDeContacto(numeroDeContacto);
            setDireccion(direccion);
            init();
            
        }

        //Metodos
        //* @name: bool esAdmin()
        //* @decryp: solo devuelve el booleano confirmando que la clase es de tipo admin.
        public override bool esAdministrador() { return true; }

        //* @name: agregarProceso(Proceso proceso)
        //* @decryp: recibe un proceso y lo agrega a la lista de procesos disponibles para ejectuar
        public void agregarProceso(Proceso proceso)
        {
            this.procesos.Add(proceso);
        }

        //* @name: ejecutarProceso(string nombreDelProceso) 
        //* @decryp: recibe por parámetro el nombre de un proceso y lo ejecuta. 
        //* PD: coincidenStrings es una simple delegación sin mas importancia.
        public void ejecutarProceso(string nombreDelProceso)
        {
            Proceso procesoAEjecutar = buscarProceso(nombreDelProceso);
            procesoAEjecutar.ejecutar(getMail());
        }

        private Proceso buscarProceso(string nombre)
        {
            return this.procesos.Find(proceso => coincidenStrings(proceso.getNombreDelProceso(), nombre));
        }
        private bool coincidenStrings(string palabra1, string palabra2)
        {
            return palabra1 == palabra2;
        }

        public void configurarTipoDeManejoDeErrores(ErrorGestion tipoDeManejoDeError)
        {
            foreach(Proceso proceso in procesos)
            {
                proceso.setTipoDeManejoDeError(tipoDeManejoDeError);
            }
        }
    }
}
