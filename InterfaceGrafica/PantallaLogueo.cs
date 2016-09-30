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
        public PantallaLogueo(TerminalConsola terminalUtilizada, GestorDeUsuarios gestor)
        {   //this.terminal = new TerminalConsola("Terminal de prueba", 5); 
            //this.gestorDeUsuario = new GestorDeUsuarios();
            terminal = terminalUtilizada;
            gestorDeUsuario = gestor;
            InitializeComponent();
        }

        //OBJETOS BOTONES//
        private void PantallaLogueo_Load(object sender, EventArgs e)
        {
            
            

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

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = IngresarUsuario.Text.ToString();
            string contraseña = IngresarContraseña.Text.ToString();

            bool existeUsuario = gestorDeUsuario.loggearUsuarioEn(usuario, contraseña, terminal);
            if (existeUsuario)
            {
                Program.setUsuario(usuario);
                this.Close();

                if (gestorDeUsuario.esAdmin(IngresarUsuario.Text.ToString()))
                {
                    PantallaPrincipal pantallaDeAdmin = new PantallaPrincipal(gestorDeUsuario, terminal, usuario);
                    this.Hide();
                    pantallaDeAdmin.ShowDialog();
                    this.Close();
                }
                else
                {
                    PantallaDeUsuario pantallaDeUsuario = new PantallaDeUsuario(gestorDeUsuario, terminal, usuario);
                    this.Hide();
                    pantallaDeUsuario.ShowDialog();
                    this.Close();
                    
                }
            }
            else
            {
               
               MessageBox.Show("Usuario y/o contraseña incorrecto");
            }
        }


        private void CrearCuenta_Click(object sender, EventArgs e)
        {
            PantallaCrearCuenta pantallaCrearCuenta = new PantallaCrearCuenta();
            pantallaCrearCuenta.ShowDialog();
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

      


        //----DISEÑO DE BOTONES----//
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON REGISTRAR//
        private void BotonRegistrarse_Click_1(object sender, EventArgs e)
        {
            
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        
    }
}
