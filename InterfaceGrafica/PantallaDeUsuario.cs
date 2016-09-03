using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UssersGestion;
using Consola;

namespace InterfaceGrafica
{
    public partial class PantallaDeUsuario : Form
    {
        //ATRIBUTOS//
        private TerminalConsola terminal;
        private GestorDeUsuarios gestorDeUsuarios;
        private string usuario;

        //CONSTRUCTOR//
        public PantallaDeUsuario(GestorDeUsuarios gestor, TerminalConsola terminal, string usuario)
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


            Usuario.Text = "Usuario:" + Program.usuario;

            //Mostrar Fecha y Hora
            Fecha.Text = DateTime.Now.ToLongDateString();
            

            //Centrar imagenes
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //captura el tamaño del monitor


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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PantallaBusqueda busqueda = new PantallaBusqueda(terminal);
            busqueda.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            PantallaHistorial historial = new PantallaHistorial();
            historial.ShowDialog();
        }

        //REVISAR ACA//
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //PantallaAdministrarUsuarios config = new PantallaAdministrarUsuarios();
            //config.ShowDialog();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void BotonBuscar_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void BotonBuscar_MouseLeave(object sender, EventArgs e)
        {
            // BotonBuscar.Size = new Size(200, 200); NO SIRVE NI PA MIERDA
        }

        private void BotonHistorial_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void BotonHistorial_MouseLeave(object sender, EventArgs e)
        {
            
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

        //BOTON CERRAR SESION//
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
    }
}
