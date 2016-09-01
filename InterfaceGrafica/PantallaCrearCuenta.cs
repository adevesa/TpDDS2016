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
    public partial class PantallaCrearCuenta : Form
    {
        public PantallaCrearCuenta()
        {
            InitializeComponent();
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BotonComenzar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PantallaCrearCuenta_Load(object sender, EventArgs e)
        {
            BotonConfirmar.BackgroundImage = Properties.Resources.Confirmar;
            BotonDesHacer.BackgroundImage = Properties.Resources.Deshacer;
        }

        private void BotonConfirmar_MouseHover(object sender, EventArgs e)
        {
            BotonConfirmar.BackgroundImage = Properties.Resources.Confirmar2;
        }

        private void BotonConfirmar_MouseLeave(object sender, EventArgs e)
        {
            BotonConfirmar.BackgroundImage = Properties.Resources.Confirmar;
        }

        private void BotonDesHacer_MouseHover(object sender, EventArgs e)
        {
            BotonDesHacer.BackgroundImage = Properties.Resources.Deshacer2;
        }

        private void BotonDesHacer_MouseLeave(object sender, EventArgs e)
        {
            BotonDesHacer.BackgroundImage = Properties.Resources.Deshacer;
        }

        private void BotonDesHacer_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
