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
        public  void actualizarLocalesComerciales(string rutaDeAccesoATxt)
        {
            StreamReader archivoDeTexto = new StreamReader(rutaDeAccesoATxt);
            string linea;
            while(((linea = archivoDeTexto.ReadLine()) != null))
            {
                actualizarOCrearLocalComercial(linea); 
            }
            
        }

        private void actualizarOCrearLocalComercial(string lineaLeia)
        {
            string nombreDelPoi = this.modeladorDePalabra.primerElemento(lineaLeia);
            string[] palabrasClaves = this.modeladorDePalabra.segundoElemento(lineaLeia);
            if (repositorio.verificarExistencia(nombreDelPoi))
            {
                actualizarLocalComercial(nombreDelPoi, palabrasClaves);
            }
            else crearLocalComercial(nombreDelPoi, palabrasClaves);
        }

        public void actualizarLocalComercial(string nombreDelPoi,string[] palabrasClaves)
        {
            POI poiBuscado = repositorio.localOrigin.buscarPoiLlamado(nombreDelPoi);
            poiBuscado.agregarPalabraClave(palabrasClaves);
            repositorio.localOrigin.editar(poiBuscado);
            cambiarEstadoSiEsNecesario(poiBuscado, palabrasClaves);

        }
        private void crearLocalComercial(string nombreDelPoi,string[] palabrasClaves)
        {
            LocalComercial nuevoLocal = new LocalComercial(nombreDelPoi);
            nuevoLocal.agregarPalabraClave(palabrasClaves);
            cambiarEstadoSiEsNecesario(nuevoLocal, palabrasClaves);
        }

        private void cambiarEstadoSiEsNecesario(POI local, string[] palabras)
        {
           
        }
        public override void ejecutar(string mailDelUsuario)
        {
            setMailDelUsserQueEjecuta(mailDelUsuario);
            actualizarLocalesComerciales(this.rutaDeAccesoAtxt);
        }
    }
    
}
