using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;

namespace FuenteDeDatos
{
    public struct DatosExternosBanco
    {
        public string nombre;
        public double x;
        public double y;
        public string sucursal;
        public List<string> servicios;
        public int id;
    }

    public struct DatosExternosCGP
    {
        public int numeroComuna;
        public string zonasQueIncluye;
        public string nombreDelDirector;
        public string domicilio;
        public string telefono;
        public List<servicio> servicios;
        public int id;

    }
}
