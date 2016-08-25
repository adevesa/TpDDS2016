using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consola;
using UssersGestion;


namespace InterfaceGrafica
{
    public partial class PantallaLogueo : Form
    {
        TerminalConsola terminal = new TerminalConsola("Terminal de prueba", 5);
        GestorDeUsuarios gestorDeUsuario = new GestorDeUsuarios();

        public PantallaLogueo()
        {
            InitializeComponent();
        }

        private void PantallaLogueo_Load(object sender, EventArgs e)
        {
            BotonComenzar.BackgroundImage = Properties.Resources.comenzar;

            //Centrar Componentes
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //captura el tamaño del monitor

            //Texto Usuario
            Int32 anchoDeTextoU = (this.Width - NombreDeUsuario.Width) / 2;
            NombreDeUsuario.Location = new Point(anchoDeTextoU, IngresarUsuario.Location.Y - 30);

            //Texto Contraseña
            Int32 anchoDeTextoC = (this.Width - Contraseña.Width) / 2;
            Contraseña.Location = new Point(anchoDeTextoC, IngresarContraseña.Location.Y -30);

            //Usuario
            Int32 anchoDeUsuario = (this.Width - IngresarUsuario.Width) / 2;
            IngresarUsuario.Location = new Point(anchoDeUsuario, IngresarUsuario.Location.Y);

            //Usuario
            Int32 anchoDeContraseña = (this.Width - IngresarContraseña.Width) / 2;
            IngresarContraseña.Location = new Point(anchoDeContraseña, IngresarContraseña.Location.Y);

            //Cerrar
            Int32 anchoDeX = (this.Width - BotonCerrar.Width) - 10;
            BotonCerrar.Location = new Point(anchoDeX, BotonCerrar.Location.Y);

            //Cerrar
            Int32 anchoDeComenzar = (this.Width - BotonComenzar.Width) / 2;
            BotonComenzar.Location = new Point(anchoDeComenzar, BotonComenzar.Location.Y);
        }

        private void Contraseña_Click(object sender, EventArgs e)
        {

        }

        private void ContenedorContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void IngresoNameUsser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {

        }

        private void NombreDeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            gestorDeUsuario.loggearUsuarioEn(IngresarUsuario.Text,IngresarContraseña.Text, terminal);
            Program.usuario = IngresarUsuario.Text;
            this.Close();
            PantallaPrincipal principal = new PantallaPrincipal();
            principal.ShowDialog();
        }

        //Cambia de imagen al pasar el cursor sobre el boton
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            BotonComenzar.BackgroundImage = Properties.Resources.comenzar2;
        }
        //Vuelve a la imagen original al quitar el cursor del boton
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            BotonComenzar.BackgroundImage = Properties.Resources.comenzar;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
