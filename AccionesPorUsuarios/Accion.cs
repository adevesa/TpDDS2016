using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccionesPorUsuarios
{
    public class Accion
    {
        private string Nombre { get; set; }

        public void setNombre(string nombre) { this.Nombre = nombre; }
        public string getNombre() { return this.Nombre; }
        

        //Metodos

        public void ejecutar() { }
    }
}
