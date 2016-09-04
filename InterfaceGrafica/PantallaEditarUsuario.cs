using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UssersGestion;
using Usuarios;

namespace InterfaceGrafica
{
    public partial class PantallaEditarUsuario : Form
    {
        //ATRIBUTOS//
        private string admin;

        //CONSTRUCTOR//
        public PantallaEditarUsuario(string administrador)
        {
            this.admin = administrador;
            InitializeComponent();
        }

        private void PantallaCrearCuenta_Load(object sender, EventArgs e)
        {
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON CONFIRMAR CAMBIOS//
        private void BotonConfirmar2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //BOTON BUSCAR USUARIO//
        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            /*string usuarioBuscado = IngresarUsuario.Text.ToString();
            Usuario usserBuscado = Program.gestorDeUsuario.buscarUsuario(usuarioBuscado);
            rellenar_los_datos(usserBuscado);*/
        }

        private void rellenar_los_datos(Usuario usser)
        {

        }

        private void OpcionSi_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
