using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceGrafica;

namespace InterfaceGrafica
{
    public partial class PantallaDeCarga : Form
    {
        public PantallaDeCarga()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        //Contador de porcentaje
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(BarraDeCarga.Value<100)
            {
                
                BarraDeCarga.Value = BarraDeCarga.Value + 10; //le voy sumando de a 10 a la barra de carga
                contador.Text = "Cargando..." + BarraDeCarga.Value + "%"; //muestra el valor de la barra de carga
            }
            else
            {
                timer1.Enabled = false; //desactivo el timer
                this.Close(); //cierrar pantalla de carga
                
    
            }
        }
        //Abre la Pantalla de Logueo
        private void PantallaDeCarga_FormClosing(object sender, FormClosingEventArgs e)
        {
            PantallaLogueo logueo = new PantallaLogueo();
            logueo.ShowDialog();
        }

        private void PantallaDeCarga_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void contador_Click(object sender, EventArgs e)
        {

        }

        private void PantallaDeCarga_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
