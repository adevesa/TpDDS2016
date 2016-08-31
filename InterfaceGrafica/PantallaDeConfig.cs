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
    public partial class PantallaDeConfig : Form
    {
        public PantallaDeConfig()
        {
            InitializeComponent();
        }

        private void PantallaDeConfig_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BotonBuscar_MouseHover(object sender, EventArgs e)
        {
            BotonAplicar.Size = new Size(160, 160);
        }

        private void BotonAplicar_Click(object sender, EventArgs e)
        {

        }

        private void BotonAplicar_MouseLeave(object sender, EventArgs e)
        {
            BotonAplicar.Size = new Size(150, 150);
        }
    }
}
