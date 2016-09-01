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

namespace InterfaceGrafica
{
    public partial class PantallaBusqueda : Form
    {
        private TerminalConsola terminal;

        public PantallaBusqueda(TerminalConsola terminalUtilizada)
        {
            this.terminal = terminalUtilizada;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //BOTON AGREGAR-- AGREGA UN CRITERIO DE BUSQUEDA//
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string criterio_de_busqueda = TextoAgregar.Text.ToString();
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

       
        //BOTON QUE DISPARA LA ACCION DE BUSCAR//
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            string criterio_de_busqueda = TextoAgregar.Text.ToString();
            List<string> lista_obtenida = new List<string>();
            lista_obtenida=terminal.mappearNombresPois(terminal.buscar(criterio_de_busqueda));
            agregar_elementos_a_listBox(lista_obtenida);
        }
        private void agregar_elementos_a_listBox(List<string> resultados)
        {
            foreach(string nombrePoi in resultados)
            {
                listBox1.Items.Add(nombrePoi);
            }
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

        //BOX QUE MUESTRA LA LISTA DE POIS DEVUELTO POR EL SISTEMA//
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

        //BOTON DESHACER -- ELIMINA PALABRAS A BUSCAR//
        private void BotonDeshacer_Click(object sender, EventArgs e)
        {

        }

        //BOX QUE CONTIENE PALABRA A BUSCAR//
        private void textoAgregar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
