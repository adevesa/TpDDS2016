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
    public partial class PantallaAdministrarUsuarios : Form
    {
        //ATRIBUTOS//
        private string administrador;

        //CONSTRUCTOR//
        public PantallaAdministrarUsuarios(string admin)
        {
            this.administrador = admin;
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

        //BOTON QUE ABRE PANTALLA DE EDITAR USUARIO//
        private void BotonEditarUsuario_Click(object sender, EventArgs e)
        {
            PantallaEditarUsuario fr = new PantallaEditarUsuario(administrador);
            fr.ShowDialog();
        }

        //BOTON QUE ABRE PANTALLA PARA CREAR ADMINISTRADOR//
        private void button1_Click(object sender, EventArgs e)
        {
            PantallaCrearAdministrador fr = new PantallaCrearAdministrador(administrador);
            fr.ShowDialog();
        }

        //BOTON VOLVER -- RETORNA A PANTALLA PRINCIPAL DE ADMINISTRADOR//
        private void BotonVolver_Click(object sender, EventArgs e)
        {
            PantallaPrincipal fr = new PantallaPrincipal(Program.gestorDeUsuario, Program.terminal, administrador);
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }
    }
}
