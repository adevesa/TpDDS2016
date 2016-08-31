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
    public partial class PantallaBusqueda : Form
    {
        public PantallaBusqueda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            BotonAgregar.BackgroundImage = Properties.Resources.AgregarPOI2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            BotonAgregar.BackgroundImage = Properties.Resources.AgregarPOI;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        //cambia de tamaño al pasar el mouse
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            BotonBuscar.Size = new Size(160,160);
        }


        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            BotonBuscar.Size = new Size(150, 150);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PantallaBusqueda_Load(object sender, EventArgs e)
        {
            BotonAgregar.BackgroundImage = Properties.Resources.AgregarPOI;
            BotonDeshacer.BackgroundImage = Properties.Resources.Deshacer;
        }

        private void BotonDeshacer_MouseLeave(object sender, EventArgs e)
        {
            BotonDeshacer.BackgroundImage = Properties.Resources.Deshacer;
        }

        private void BotonDeshacer_MouseHover(object sender, EventArgs e)
        {
            BotonDeshacer.BackgroundImage = Properties.Resources.Deshacer2;
        }

        private void BotonDeshacer_Click(object sender, EventArgs e)
        {

        }
    }
}
