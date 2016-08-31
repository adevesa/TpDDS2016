using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceGrafica
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

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
            BotonBuscar.BackgroundImage = Properties.Resources.BuscarPOI;
            BotonHistorial.BackgroundImage = Properties.Resources.HistorialDeBusquedas;
            BotonConfig.BackgroundImage = Properties.Resources.ConfigurarBusqueda;


            timer1.Enabled = true;

            Usuario.Text = "Admin:" + Program.usuario;

            //Mostrar Fecha y Hora
            Fecha.Text = DateTime.Now.ToLongDateString();
            Hora.Text = DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;

            //Centrar imagenes
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //captura el tamaño del monitor

            //Lupa
            //Int32 anchoDeLupa = (this.Width - BotonBuscar.Width) / 2;
            //BotonBuscar.Location = new Point(anchoDeLupa, BotonBuscar.Location.Y);

            //Libro
            //Int32 anchoDeLibro = (this.Width - BotonHistorial.Width) / 4;
            //BotonHistorial.Location = new Point(anchoDeLibro , BotonHistorial.Location.Y);

            //Tuerca
            //Int32 anchoDeTuerca = (this.Width + BotonConfig.Width) / 8 ;
            //Int32 anchoDeTuerca = (anchoDeLupa - anchoDeLibro) + (this.Width / 2);
            //BotonConfig.Location = new Point(anchoDeTuerca * 5 , BotonConfig.Location.Y);

            //Cerrar
            Int32 anchoDeX = (this.Width - BotonCerrar.Width) - 10;
            BotonCerrar.Location = new Point(anchoDeX, BotonCerrar.Location.Y);

            //CerrarSecion
            //Int32 anchoDeCerrarSecion = (this.Width - CerrarSecion.Width) / 2;
            //Int32 largoDeCerrarSecion = (this.Width - CerrarSecion.Width) / 4;
            //CerrarSecion.Location = new Point(anchoDeCerrarSecion, largoDeCerrarSecion * 3);

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

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PantallaBusqueda busqueda = new PantallaBusqueda();
            busqueda.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            PantallaHistorial historial = new PantallaHistorial();
            historial.ShowDialog();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PantallaDeConfig config = new PantallaDeConfig();
            config.ShowDialog();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            BotonConfig.BackgroundImage = Properties.Resources.ConfigurarBusqueda2;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            BotonConfig.BackgroundImage = Properties.Resources.ConfigurarBusqueda;
        }

        private void BotonBuscar_MouseHover(object sender, EventArgs e)
        {
            BotonBuscar.BackgroundImage = Properties.Resources.BuscarPoi2;
        }

        private void BotonBuscar_MouseLeave(object sender, EventArgs e)
        {
            BotonBuscar.BackgroundImage = Properties.Resources.BuscarPOI;
        }

        private void BotonHistorial_MouseHover(object sender, EventArgs e)
        {
            BotonHistorial.BackgroundImage = Properties.Resources.HistorialDeBusquedas2;
        }

        private void BotonHistorial_MouseLeave(object sender, EventArgs e)
        {
            BotonHistorial.BackgroundImage = Properties.Resources.HistorialDeBusquedas;
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

        private void CerrarSecion_Click(object sender, EventArgs e)
        {
            PantallaLogueo loguin = new PantallaLogueo();
            loguin.Show();
            
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
