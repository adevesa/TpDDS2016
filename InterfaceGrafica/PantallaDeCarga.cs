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
using Consola;
using UssersGestion;

namespace InterfaceGrafica
{
    public partial class PantallaDeCarga : Form
    {
        //ATRIBUTOS//
        private TerminalConsola terminal;
        private GestorDeUsuarios gestorDeUsser;
        //CONSTRUCTOR//
        public PantallaDeCarga(TerminalConsola terminalUtilizada, GestorDeUsuarios gestor)
        {
            this.terminal = terminalUtilizada;
            this.gestorDeUsser = gestor;
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
                
                BarraDeCarga.Value = BarraDeCarga.Value + 2; 
                contador.Text = "Cargando..." + BarraDeCarga.Value + "%"; 
            }
            else
            {
                timer1.Enabled = false; //desactivo el timer
                PantallaLogueo logueo = new PantallaLogueo(terminal, gestorDeUsser);
                this.Hide();
                logueo.ShowDialog();
                this.Close(); //cierrar pantalla de carga
            }

            


        }
        
        //Abre la Pantalla de Logueo
        private void PantallaDeCarga_FormClosing(object sender, FormClosingEventArgs e)
        {
            //PantallaLogueo logueo = new PantallaLogueo(terminal, gestorDeUsser);
           
            //logueo.ShowDialog();
           
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
