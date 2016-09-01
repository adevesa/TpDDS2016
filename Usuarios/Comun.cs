﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;


namespace Usuarios
{
    public class Comun:Usuario
    {
        
        //Constructores
        public Comun() { init(); }
        public Comun(string nombreCompleto, int numeroDeContacto, string direccion)
        {
            setNombreCompleto(nombreCompleto);
            setNumeroDeContacto(numeroDeContacto);
            setDireccion(direccion);
            init();
        }

        //Metodos
        public override bool esAdministrador() { return false; }
    }
}
