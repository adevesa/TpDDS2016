﻿using System;
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
            Proceso procesoAEjecutar=this.procesos.Find(proceso=>coincidenStrings(proceso.getNombreDelProceso(),nombreDelProceso));
            procesoAEjecutar.ejecutar();
        }
        private bool coincidenStrings(string palabra1, string palabra2)
        {
            return palabra1 == palabra2;
        }
    }
}
