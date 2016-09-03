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

namespace InterfaceGrafica
{
    public partial class PantallaCrearAdministrador : Form
    {
        //ATRIBUTOS//
        private string admin;

        //CONSTRUCTOR
        public PantallaCrearAdministrador(string administrador)
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

        //BOTON CONFIRMAR -- CREA UN NUEVO ADMINISTRADOR//
        private void BotonConfirmar2_Click(object sender, EventArgs e)
        {
            string nombreDeUsuario = IngresarUsuario.Text.ToString();
            string contraseña = Contraseña.Text.ToString() ;
            string nombreCompleto = Nombre.Text.ToString() ;
            string email = Mail.Text.ToString() ;
            Program.gestorDeUsuario.crearUsuario("administrador",nombreDeUsuario, contraseña, nombreCompleto, email);
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

        private void IngresarUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        //BOTON DESHACER -- BORRA TODOS LOS CAMPOS//
        private void BotonDesHacer2_Click(object sender, EventArgs e)
        {
            IngresarUsuario.Clear();
            Contraseña.Clear();
            Nombre.Clear();
            Mail.Clear();
        }
    }
}
