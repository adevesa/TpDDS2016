using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrigenesDeDatos;
using Repositorio;
using LibreriaClasesPoi;
using System.IO;

namespace Procesos
{
    public class ActualizacionDeLocalesComerciales:Proceso
    {
        private string rutaDeAccesoAtxt;
        private string nombreDelProceso = "actualizacion de locales comerciales";
        RepositorioDePois repositorio = RepositorioDePois.getInstance();

        public void setRutaDeAccesoAtxt(string ruta) { this.rutaDeAccesoAtxt = ruta; }
        public string getNombreDelProceso() { return this.nombreDelProceso; }

        //* @name: actualizarLocalesComerciales(string rutaDeAccesoATxt)
        //* @decryp: recibe por parámetro un string con la ruta a un .txt, que contiene información de la siguiente forma:
        //* nombre de fantasía;palabras clave (separadas por espacios) 
        //* por cada línea leida, se actualiza (o se crea si no existiese) el local en cuestión,
        //* y se verifica que no haya errores. En caso de que EXISTAN ERRORES, el método devuelve 1(int UNO).
        public int actualizarLocalesComerciales(string rutaDeAccesoATxt)
        {
            StreamReader archivoDeTexto = new StreamReader(rutaDeAccesoATxt);
            string linea = archivoDeTexto.ReadLine();
            bool hayError = false;
            while((linea != null) && !hayError)
            {
                int resultadoDelProceso=actualizarOCrearLocalComercial(linea);
                if (resultadoDelProceso != 0)
                {
                    hayError = true;
                    return 1;
                }
            }
            return 0;
        }

        private int actualizarOCrearLocalComercial(string lineaLeia)
        {
            //* split separa palabras con un delimitador, en este caso ";"
            string[] split = lineaLeia.Split(new Char[] { ';' });
            string nombreDelPoi = split.First();
            string [] palabrasClaves = desglosarPalabrasClavesLeidas(split);
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

        private string[] desglosarPalabrasClavesLeidas(string[] palabras)
        {
            int cantidadDePalabras = palabras.Count();
            string[] palabrasClaves = new string[cantidadDePalabras - 1];
            for(int i=1; i<=cantidadDePalabras; i++)
            {
                palabrasClaves[i] = palabras[i];
            }
            return palabrasClaves;
        }

        public int ejercutarProceso()
        {
            return actualizarLocalesComerciales(this.rutaDeAccesoAtxt);
        }
    }
    
}
