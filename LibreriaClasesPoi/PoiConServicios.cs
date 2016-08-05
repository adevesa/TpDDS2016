﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poi.Servicios;

namespace LibreriaClasesPoi
{
    public abstract class PoiConServicios:POI
    {
        //Atributos
        private List<Servicio> servicios;

        //Getters
        public List<Servicio> getServicios() { return this.servicios; }

                //Metodos abstractos

        //* @name: initService()
        //* @decryp: genera una nueva lista de servicios y la settea.
        public void initService(string nombre)
        {
            base.init(nombre);
            servicios = new List<Servicio>();
        }

        //* @name: buscarCoincidencia(string criterio)
        //* @decryp: recibe un string y comprueba si se cumple el método "buscarCoincidencia" de clase que hereda
        //* o bien si algún servicio verifica con la palabra buscada.
        public override bool buscarCoincidencia(string palabraBuscada)
        {
            return (this.getServicios().Any(servicio => servicio.servicioCoincide(palabraBuscada)) || base.buscarCoincidencia(palabraBuscada));
        }

        //Metodos de manipulación de servicios 
        public bool estaServicioDisponible(string servicio, DateTime momento)
        {
            Servicio service = buscarServicio(servicio);
            return service.estaDisponible(momento);
        }

        public void crearServicio(string nombreDelServicio)
        {
            Servicio service = new Servicio();
            service.setNombreDelServicio(nombreDelServicio);
            service.setNoTieneLimiteHorario(true);
            agregarServicio(service);
        }

        private void agregarServicio(Servicio servicio)
        {
            servicio.setPoiId(this.getId());
            this.servicios.Add(servicio);
        }

        public void agregarHorarioDeAtencionAServicio(string nombreDelServicio, string dia, string turno, int horarioDeApertura, int horarioDeCierre)
        {
            Servicio serviceBuscado = buscarServicio(nombreDelServicio);
            serviceBuscado.agregarDiaYHorario(dia, turno, horarioDeApertura, horarioDeCierre);
        }

        public void agregarServicioSinLimiteHorario(string servicio)
        {
            Servicio nuevoServicio = new Servicio();
            nuevoServicio.setNombreDelServicio(servicio);
            nuevoServicio.setNoTieneLimiteHorario(false);
            agregarServicio(nuevoServicio);
        }

        private Servicio buscarServicio(string servicioBuscado)
        {
            Servicio service = new Servicio();
            service = this.getServicios().Find(unServico => unServico.servicioCoincide(servicioBuscado));
            return service;
        }

        private List<string> filtrarNombresServicios(List<Servicio> listaDeServicios)
        {
            List<string> lista = new List<string>();
            foreach (Servicio unServicio in listaDeServicios)
            {
                lista.Add(unServicio.getNombreDelServicio());
            }
            return lista;
        }


    }
}
