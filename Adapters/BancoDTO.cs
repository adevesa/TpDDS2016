using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters
{
    public class BancoDTO
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int coordenadaX { get; set; }
        public int coordenadaY { get; set; }
        public string sucursal { get; set; }
        public string gerente { get; set; }
        public List<string> servicios { get; set; } 
    }
}
