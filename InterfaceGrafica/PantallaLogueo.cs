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
