using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;

namespace Usuarios
{
    public interface Usuario
    {
        
        void setNombreCompleto(string nombreCompleto);
        string getNombreCompleto();
        void setDireccion(string direccion);
        string getDireccion();
        void setNumeroDeContacto(int numero);
        int getNumeroDeContacto();
        void setIdUsuario(int numero);
        int getIdUsuario();
        string getMail();
        void setMail(string mail);


    }
}
