﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuenteDeDatos
{
    public interface FuenteDeDatosCGPS
    {
        List<DatosExternosCGP> buscar(string criterio);
    }
}
