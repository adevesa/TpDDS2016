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
using LibreriaClasesPoi;

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

        private void Agregar_Click(object sender, EventArgs e)
        {
            string criterio_de_busqueda = TextoAgregar.Text.ToString();
            ListViewItem imte = new ListViewItem(criterio_de_busqueda);
            TextoAgregar.Clear();
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       
        //BOTON QUE DISPARA LA ACCION DE BUSCAR//
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            string criterio_de_busqueda = TextoAgregar.Text.ToString();
            List<POI> results = terminal.buscar(criterio_de_busqueda);
            agregar_elementos_a_listView(results);

        }
        private List<string> recuperar_elementos_listBox()
        {
            List<string> palabras_a_buscar = new List<string>();
            int cantidad_elemtentos = Palabras.Items.Count;
            int contador;
            string[] palabras = new string[cantidad_elemtentos];
            for(contador=0; contador < cantidad_elemtentos; contador++)
            {
                Palabras.Items.CopyTo(palabras, contador);
            }
            foreach(string palabra in palabras)
            {
                palabras_a_buscar.Add(palabra);
            }
            return palabras_a_buscar;
        }

        private void agregar_elementos_a_listView(List<POI> resultados)
        {
            foreach(POI poi in resultados)
            {
                ListViewItem item = new ListViewItem(poi.getNombre());
                item.SubItems.Add(poi.getDireccion());
                if (poi.estaDisponible(DateTime.Now))
                {
                    item.SubItems.Add("Si");
                }
                else { item.SubItems.Add("No"); }
                ListViewPois.Items.Add(item);
            }
        }

        //cambia de tamaño al pasar el mouse
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
           // BotonBuscar.Size = new Size(160,160);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
           // BotonBuscar.Size = new Size(150, 150);
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
            
        }

        

        //BOTON DESHACER -- ELIMINA PALABRAS A BUSCAR//
        private void Deshacer_Click(object sender, EventArgs e)
        {
            Palabras.SelectedItems.Clear();
        }

        //BOX QUE CONTIENE PALABRA A BUSCAR//
        private void textoAgregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void ListViewPois_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
