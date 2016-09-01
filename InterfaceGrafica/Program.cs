using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceGrafica
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static string usuario; 
        
        public static void setUsuario(string nameUsuario)
        {
            usuario = nameUsuario;
        }

        public static void borrarNombreUsuario()
        {
            usuario = null;
        }

        public static PantallaLogueo pantallaLog;
        
        public static void setPantallaLog(PantallaLogueo log)
        {
            pantallaLog = log;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PantallaDeCarga formPantallaDeCarga = new PantallaDeCarga();
            Application.Run(formPantallaDeCarga);
            //formPantallaDeCarga.ShowDialog();

        }
    }
}
