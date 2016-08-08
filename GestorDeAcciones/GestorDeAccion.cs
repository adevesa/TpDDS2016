using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccionesPorUsuarios;
using UssersGestion;

namespace GestorDeAcciones
{
    public class GestorDeAccion
    {
        //Atributos
        private GestorDeUsuarios gestorDeUssers;
   
        //Aplicacion del SINGLETON
        private static GestorDeAccion instance = null;

        public static GestorDeAccion getInstance()
        {
            if (instance == null)
            {
                instance = new GestorDeAccion();
                instance.gestorDeUssers = new GestorDeUsuarios();
            }
            return instance;
        }

        //Metodos
        public void actualizar(string nombreDeUsuario,Accion accion)
        {
            
        }
    }
}
