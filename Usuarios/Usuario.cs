using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consola;
using LibreriaClasesPoi;

namespace Usuarios
{
    public interface Usuario
    {
        List<Poi> buscar(string palabraClave);
        void loggearEn(TerminalConsola terminal);
        void setTerminal(TerminalConsola terminal);
        TerminalConsola getTerminal();
        void setNombreCompleto(string nombreCompleto);
        string getNombreCompleto();
        void setDireccion(string direccion);
        string getDireccion();
        void setNumeroDeContacto(int numero);
        int getNumeroDeContacto();
        void setIdUsuario(int numero);
        int getIdUsuario();


    }
}
