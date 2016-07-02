﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using FuenteDeDatos;
using Adapters;

namespace OrigenesDeDatos
{
    public class OrigenBancos : Origenes
    {
        public FuenteDeDatosBanco fuente;

        OrigenBancos(FuenteDeDatosBanco fuentee)
        {
            this.fuente = fuentee;
        }

        public List<Poi> find(string criterio)
        {
            List<String> result = fuente.buscar(criterio);
            return BancoAdapter.adapt(result);

        }
    }
}
