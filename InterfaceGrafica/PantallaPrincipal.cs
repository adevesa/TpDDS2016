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
            Usuario.Text = "Usuario:" + Program.usuario;

            //Mostrar Fecha y Hora
            Fecha.Text = DateTime.Now.ToLongDateString();
            Hora.Text = DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;

            //Centrar Panel2
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //captura el tamaño del monitor
            Int32 ancho = (this.Width - panel2.Width) / 2;
            panel1.Location = new Point(ancho, panel1.Location.Y);
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

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            BotonConfig.Size = new Size(93, 103);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PantallaDeConfig config = new PantallaDeConfig();
            config.ShowDialog();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            BotonConfig.Size = new Size(83, 93);
        }

        private void BotonBuscar_MouseHover(object sender, EventArgs e)
        {
            BotonBuscar.Size = new Size(130, 130);
        }

        private void BotonBuscar_MouseLeave(object sender, EventArgs e)
        {
            BotonBuscar.Size = new Size(120, 120);
        }

        private void BotonHistorial_MouseHover(object sender, EventArgs e)
        {
            BotonHistorial.Size = new Size(93, 103);
        }

        private void BotonHistorial_MouseLeave(object sender, EventArgs e)
        {
            BotonHistorial.Size = new Size(83, 93);
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
    }
}
