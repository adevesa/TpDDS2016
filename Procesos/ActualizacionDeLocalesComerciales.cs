using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrigenesDeDatos;
using Repositorio;
using LibreriaClasesPoi;
using System.IO;
using Procesos.MiniProcess;


namespace Procesos
{
    public class ActualizacionDeLocalesComerciales:Proceso
    {
        //Atributos
        private string rutaDeAccesoAtxt;
        RepositorioDePois repositorio = RepositorioDePois.getInstance();
        ManejadorString modeladorDePalabra;

        //Setters y getters
        public void setRutaDeAccesoAtxt(string ruta) { this.rutaDeAccesoAtxt = ruta; }
        
        //Constructor
        public ActualizacionDeLocalesComerciales()
        {
            this.setNombreDelProceso("actualizacion de locales comerciales");
            this.modeladorDePalabra = new ManejadorString();
        }

        //Metodos

        //* @name: actualizarLocalesComerciales(string rutaDeAccesoATxt)
        //* @decryp: recibe por parámetro un string con la ruta a un .txt, que contiene información de la siguiente forma:
        //* nombre de fantasía;palabras clave (separadas por espacios) 
        //* por cada línea leida, se actualiza (o se crea si no existiese) el local en cuestión,
        //* y se verifica que no haya errores. En caso de que EXISTAN ERRORES, el método devuelve 1(int UNO).
        public int actualizarLocalesComerciales(string rutaDeAccesoATxt)
        {
            StreamReader archivoDeTexto = new StreamReader(rutaDeAccesoATxt);
            string linea;
            bool hayError = false;
            while(((linea = archivoDeTexto.ReadLine()) != null) && !hayError)
            {
                if (actualizarOCrearLocalComercial(linea) != 0)
                {
                    hayError = true;
                    return 1;
                }
            }
            return 0;
        }

        private int actualizarOCrearLocalComercial(string lineaLeia)
        {
            string nombreDelPoi = this.modeladorDePalabra.primerElemento(lineaLeia);
            string[] palabrasClaves = this.modeladorDePalabra.segundoElemento(lineaLeia);
            if (repositorio.verificarExistencia(nombreDelPoi))
            {
                return actualizarLocalComercial(nombreDelPoi, palabrasClaves);
            }
            else return crearLocalComercial(nombreDelPoi, palabrasClaves);
        }

        private int actualizarLocalComercial(string nombreDelPoi,string[] palabrasClaves)
        {
            POI poiBuscado = repositorio.localOrigin.buscarPoiLlamado(nombreDelPoi);
            poiBuscado.agregarPalabraClave(palabrasClaves);
            repositorio.localOrigin.editar(poiBuscado);
            return 0;
        }
        private int crearLocalComercial(string nombreDelPoi,string[] palabrasClaves)
        {
            LocalComercial nuevoLocal = new LocalComercial(nombreDelPoi);
            nuevoLocal.agregarPalabraClave(palabrasClaves);
            return 0;
        }


        public override int ejecutar()
        {
            return actualizarLocalesComerciales(this.rutaDeAccesoAtxt);
        }
    }
    
}
