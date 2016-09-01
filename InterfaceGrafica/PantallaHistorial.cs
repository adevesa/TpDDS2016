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
    public partial class PantallaHistorial : Form
    {
        public PantallaHistorial()
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
            BotonAplicar.Size = new Size(160, 160);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            BotonAplicar.Size = new Size(150, 150);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
