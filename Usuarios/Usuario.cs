using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consola;
using LibreriaClasesPoi;

namespace Usuarios
{
    public abstract class Usuario
    {
        private SearchStorer almacenadorDeBusquedas;
        public SearchStorer getAlmacenador() { return almacenadorDeBusquedas; }
        private void setAlmacenador(SearchStorer almacenador)
        {
            this.almacenadorDeBusquedas = almacenador;
        }

        private TerminalConsola terminal;
        public void setTerminal(TerminalConsola terminal)
        {
            this.terminal = terminal;
        }
        public TerminalConsola getTerminal() { return this.terminal; }

        public void init()
        {

        }

        public void loggearEn(TerminalConsola terminal)
        {
            setTerminal(terminal);
        }

        private void almacenarBusqueda(string palabraClave, List<Poi> resultado)
        {

        }
    }
}
