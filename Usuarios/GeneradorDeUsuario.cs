using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Usuarios
{
    public  class GeneradorDeUsuario
    {
        public Usuario crearUsuario(string tipoUsuario,string nombreDeUsuario,string nombreCompleto, string mail, bool usuarioGeneradorEsAdmin)
        {
            switch(tipoUsuario)
               {
	                case "administrador": return this.soloCrearSiSePuede(tipoUsuario, nombreDeUsuario, nombreCompleto, mail, usuarioGeneradorEsAdmin);
	                case "comun": return (modelarUsuario(new Comun(), nombreDeUsuario, nombreCompleto, mail));
                    default: throw new System.InvalidOperationException("Tipo de usuario que pretende crear no es válido");
                }
        }
       
        private Usuario soloCrearSiSePuede(string tipoUsuario,string nombreDeUsuario, string nombreCompleto, string mail, bool usuarioGeneradorEsAdmin)
        {
            if (usuarioGeneradorEsAdmin)
            {
                return modelarUsuario(new Administrador(), nombreDeUsuario,nombreCompleto, mail);
            }
            throw new System.InvalidOperationException("No tiene permiso para crear un administrador");
        }
        
        private Usuario modelarUsuario(Usuario nuevoUsuario, string nombreDeUsuario, string nombreCompleto, string mail)
        {
            nuevoUsuario.setNombreDeUsuario(nombreDeUsuario);
            nuevoUsuario.setNombreCompleto(nombreCompleto);
            nuevoUsuario.setMail(mail);
            return nuevoUsuario;
        }
    }
}
