using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios;

namespace UssersGestion
{
    public class UsuarioDao
    {
        //Aplicación del SINGLETON
        private static UsuarioDao instance = null;

        public static UsuarioDao getInstance()
        {
            if (instance == null)
            {
                instance = new UsuarioDao();
                instance.ussers = new List<Usuario>();
                instance.factory = new GeneradorDeUsuario();
                instance.init();
            }
            return instance;
        }

        //Atributos
        private List<Usuario> ussers;
        private GeneradorDeUsuario factory;

        //Setters y getters
        public List<Usuario> getUssers(){ return this.ussers; }

        //Métodos
        public void crearUsuario(string tipoUsuario, string nombreDeUsuario, string nombreCompleto, string mail, bool usuarioGeneradorEsAdmin)
        {
            Usuario nuevoUsser = this.factory.crearUsuario(tipoUsuario, nombreDeUsuario, nombreCompleto, mail, usuarioGeneradorEsAdmin);
            agregarUsuario(nuevoUsser);
        }

        private void agregarUsuario(Usuario usuario)
        {
            this.ussers.Add(usuario);

        }

        public Usuario buscarUsser(string nombreDeUsuario)
        {
            Usuario usserPedido = getUssers().Find(usuario => usuario.getNombreDeUsuario() == nombreDeUsuario);
            return usserPedido;
        }

        public List<String> filtrarNombresDeUsuarios()
        {
            List<String> lista = new List<String>();
            foreach (Usuario usser in getUssers())
            {
                lista.Add(usser.getNombreCompleto());
            }
            return lista;
        }

        private void init()
        {
            //Administradores default
            crearUsuario("administrador","ezequiel_escobar", "ezequiel oscar escobar", "ezequieloscarescobar2@gmail.com", true);
            crearUsuario("administrador", "santi_candi","santiago candia","santiago.gcandia@gmail.com", true);
            
            //Usuarios default
            crearUsuario("comun","agus_grec", "agustin greco","grec.grec@gmail.com",false);
            crearUsuario("comun","agus_dev", "agustin devesa","agus.devesa@gmail.com",false );
        }
    }
}
