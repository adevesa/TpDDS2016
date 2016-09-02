﻿using System;
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
    public partial class PantallaAdministrarPois : Form
    {
        public PantallaAdministrarPois()
        {
            InitializeComponent();
        }

        private void PantallaDeConfig_Load(object sender, EventArgs e)
        {
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;

            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);

            //Cerrar
            Int32 anchoDeX = (this.Width - BotonCerrar.Width) - 10;
            BotonCerrar.Location = new Point(anchoDeX, BotonCerrar.Location.Y);
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
            
        }

        private void BotonAplicar_Click(object sender, EventArgs e)
        {

        }

        private void BotonAplicar_MouseLeave(object sender, EventArgs e)
        {
           
        }


        private void BotonEditarPOI_Click(object sender, EventArgs e)
        {
            PantallaEditarPOI fr = new PantallaEditarPOI();
            fr.ShowDialog();
        }

        private void BotonElimiarPOI_Click(object sender, EventArgs e)
        {
            PantallaBorrarPoi fr = new PantallaBorrarPoi();
            fr.ShowDialog();
        }

        private void CrearPOI_Click(object sender, EventArgs e)
        {
            PantallaCrearPOI fr = new PantallaCrearPOI();
            fr.ShowDialog();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            
            //PantallaPrincipal fr = new PantallaPrincipal();
            //fr.ShowDialog();
        }
    }
}
