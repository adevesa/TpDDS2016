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
        //ATRIBUTOS//
        private TerminalConsola terminal;
        private GestorDeUsuarios gestorDeUsuario; 

        //CONSTRUCTOR//
        public PantallaLogueo()
        {   this.terminal = new TerminalConsola("Terminal de prueba", 5); 
            this.gestorDeUsuario = new GestorDeUsuarios();
            InitializeComponent();
        }

        //OBJETOS BOTONES//
        private void PantallaLogueo_Load(object sender, EventArgs e)
        {
            BotonComenzar.BackgroundImage = Properties.Resources.iniciar_sesion1;
            BotonRegistrarse.BackgroundImage = Properties.Resources.Registrarse;

            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;

            //Cerrar
            Int32 anchoDeX = (this.Width - BotonCerrar.Width) - 10;
            BotonCerrar.Location = new Point(anchoDeX, BotonCerrar.Location.Y);

            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);

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

        //BOTON DE INICIAR SESION -- CONTIENE TODA LA LOGICA PARA LOGGEAR UN USUARIO//
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string usuario = IngresarUsuario.Text.ToString();
            string contraseña = IngresarContraseña.Text.ToString();

            bool existeUsuario = gestorDeUsuario.loggearUsuarioEn(usuario, contraseña, terminal);
            if(existeUsuario)
            {
                Program.setUsuario(usuario);
                this.Close();

                if (gestorDeUsuario.esAdmin(IngresarUsuario.Text.ToString()))
                {
                    //PantallaPrincipal pantallaDeAdmin = new PantallaPrincipal(gestorDeUsuario, terminal, usuario);
                    if (this.DialogResult == DialogResult.OK)
                    {
                        PantallaPrincipal pantallaDeAdmin = new PantallaPrincipal(gestorDeUsuario, terminal, usuario);
                        Application.Run(pantallaDeAdmin);
                    }
                }
                else
                {
                    PantallaDeUsuario pantallaDeUsuario = new PantallaDeUsuario(gestorDeUsuario, terminal, usuario);
                    pantallaDeUsuario.ShowDialog();
                }
            }
            else
            {
                //REEMPLAZAR POR UNA PEQUEÑA VENTANA QUE DE AVISO DE ESTO//
                Console.WriteLine("Usuario y/o contraseña incorrecto");
            }

        }

        //----DISEÑO DE BOTONES----//
        //Cambia de imagen al pasar el cursor sobre el boton
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            BotonComenzar.BackgroundImage = Properties.Resources.inision_sesion2;
        }
        
        //Vuelve a la imagen original al quitar el cursor del boton
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            BotonComenzar.BackgroundImage = Properties.Resources.iniciar_sesion1;
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

        private void BotonRegistrarse_Click_1(object sender, EventArgs e)
        {
            PantallaCrearCuenta pantallaCrearCuenta = new PantallaCrearCuenta();
            pantallaCrearCuenta.ShowDialog();
        }

        private void BotonRegistrarse_MouseHover_1(object sender, EventArgs e)
        {
            BotonRegistrarse.BackgroundImage = Properties.Resources.Registrarse2;
        }

        private void BotonRegistrarse_MouseLeave(object sender, EventArgs e)
        {
            BotonRegistrarse.BackgroundImage = Properties.Resources.Registrarse;
        }
    }
}
