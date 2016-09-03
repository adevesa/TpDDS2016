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
    public partial class PantallaPrincipal : Form
    {
        //ATRIBUTOS//
        private TerminalConsola terminal;
        private GestorDeUsuarios gestorDeUsuarios;
        private string usuario;

        //CONSTRUCTOR//
        public PantallaPrincipal(GestorDeUsuarios gestor, TerminalConsola terminal, string usuario)
        {
            this.terminal = terminal;
            this.gestorDeUsuarios = gestor;
            this.usuario = usuario;
            InitializeComponent();
        }

        //OBJETOS BOTONES//
        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hora_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            

            timer1.Enabled = true;

            Usuario.Text = "Admin: " + Program.usuario;

            //Mostrar Fecha y Hora
            Fecha.Text = DateTime.Now.ToLongDateString();
            

            //Centrar imagenes
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            

            //Cerrar
            Int32 anchoDeX = (this.Width - BotonCerrar.Width) - 10;
            BotonCerrar.Location = new Point(anchoDeX, BotonCerrar.Location.Y);

        

            //Centrar Panel3
            Int32 anchoDePanel = (this.Width - panel3.Width) / 2;
            Int32 largoDePanel = (this.Height - panel3.Height) / 2;
            panel3.Location = new Point(anchoDePanel, largoDePanel);

            //Usuario
            Int32 anchoUsuario = (this.Width - Usuario.Width) / 2;
            Usuario.Location = new Point(anchoUsuario, Usuario.Location.Y);

            //Fecha
            Int32 anchoFecha = (this.Width - Fecha.Width);
            Fecha.Location = new Point(anchoFecha, Fecha.Location.Y);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;
        }

        //BOTON QUE ABRE PANTALLA DE HISTORIAL DE BUSQUEDAS//
        private void HistorialDeBusquedas_Click(object sender, EventArgs e)
        {
            PantallaHistorial historial = new PantallaHistorial();
            historial.ShowDialog();
        }

        //BOTON QUE ABRE LA PANTALLA DE BUSUQEDA DE POIS//
        private void BuscarPOIs_Click(object sender, EventArgs e)
        {
            PantallaBusqueda busqueda = new PantallaBusqueda(terminal);
            busqueda.ShowDialog();
        }

        //BOTON QUE INICIA PANTALLA DE ADMIN DE POIS//
        private void AdministrarPois_Click(object sender, EventArgs e)
        {
            PantallaAdministrarPois administrarAdmins = new PantallaAdministrarPois(usuario);
            this.Hide();
            administrarAdmins.ShowDialog();
            this.Close();
        }

        //BOTON QUE INICIA PANTALLA DE ADMIN DE USUARIOS//
        private void BotonConfig_Click(object sender, EventArgs e)
        {
            PantallaAdministrarUsuarios administarUsers = new PantallaAdministrarUsuarios(usuario);
            this.Hide();
            administarUsers.ShowDialog();
            this.Close();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
           // BotonConfig.BackgroundImage = Properties.Resources.ConfigurarBusqueda2;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
          //  BotonConfig.BackgroundImage = Properties.Resources.ConfigurarBusqueda;
        }

        private void BotonBuscar_MouseHover(object sender, EventArgs e)
        {
           // BotonBuscar.BackgroundImage = Properties.Resources.BuscarPoi2;
        }

        private void BotonBuscar_MouseLeave(object sender, EventArgs e)
        {
           // BotonBuscar.BackgroundImage = Properties.Resources.BuscarPOI;
        }

        private void BotonHistorial_MouseHover(object sender, EventArgs e)
        {
           // BotonHistorial.BackgroundImage = Properties.Resources.HistorialDeBusquedas2;
        }

        private void BotonHistorial_MouseLeave(object sender, EventArgs e)
        {
            //BotonHistorial.BackgroundImage = Properties.Resources.HistorialDeBusquedas;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void BotonCerrarSecion_Click(object sender, EventArgs e)
        {
            
        }

        //BOTON CERRAR SESION -- DESLOGUEA AL USSER DE LA TERMINAL//
        private void CerrarSecion_Click(object sender, EventArgs e)
        {
            gestorDeUsuarios.cerrarSesionDe(this.usuario, terminal);
            PantallaLogueo loguin = new PantallaLogueo(terminal, gestorDeUsuarios);
            Program.borrarNombreUsuario();
            this.Hide();
            loguin.ShowDialog();
            this.Dispose();
            this.Close();
            
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void PantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

       
    }
}
