using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consola;
using UssersGestion;
using Mapeo;

namespace InterfaceGrafica
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
    
        //ATRIBUTOS GLOBALES//
        public static string usuario;
        public static TerminalConsola terminal;
        public static GestorDeUsuarios gestorDeUsuario;
        public static PantallaLogueo pantallaLog;

        //public static MapManager mapper = new MapManager();
       
        //METODOS GLOBALES//
        public static void setUsuario(string nameUsuario)
        {
            usuario = nameUsuario;
        }

        public static void borrarNombreUsuario()
        {
            usuario = null;
        }

        public static void setPantallaLog(PantallaLogueo log)
        {
            pantallaLog = log;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //mapper.init();
            terminal = new TerminalConsola("Terminal de prueba", 5);
            gestorDeUsuario = new GestorDeUsuarios();
            PantallaDeCarga formPantallaDeCarga = new PantallaDeCarga(terminal, gestorDeUsuario);
            Application.Run(formPantallaDeCarga);

        }
    }
}
