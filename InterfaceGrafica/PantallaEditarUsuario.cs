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
        private Usuario usser;

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
            cambiar_nombre_si_es_necesario();
            cambiar_mail_si_es_necesario();
            cambiar_contraseña_si_es_necesario();
            this.Close();
        }
        private void cambiar_nombre_si_es_necesario()
        {
            if(NuevoNombre.Text.ToString() == "") { }
            else { usser.setNombreCompleto(NuevoNombre.Text.ToString()); }
        }

        private void cambiar_contraseña_si_es_necesario()
        {
            if (NuevaContraseña.Text.ToString() == "") { }
            else { usser.setContraseña(NuevaContraseña.Text.ToString()); }
        }

        private void cambiar_mail_si_es_necesario()
        {
            if (NuevoEmail.Text.ToString() == "") { }
            else { usser.setMail(NuevoEmail.Text.ToString()); }
        }

        private void cambiar_tipo_si_es_necesario()
        {
          
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
            limpiar_campos();
            string usuarioBuscado = IngresarUsuario.Text.ToString();
            Usuario usserBuscado = Program.gestorDeUsuario.buscarUsuario(usuarioBuscado);
            if(usserBuscado != null)
            {
                this.usser = usserBuscado;
                rellenar_los_datos(usserBuscado);
            }
            else {
                    MessageBox.Show("No existe el usuario buscado");
                IngresarUsuario.Clear();
                 }
        }

        private void limpiar_campos()
        {
            InfoActual.Items.Clear();
            NuevoEmail.Clear();
            NuevaContraseña.Clear();
            NuevoNombre.Clear();
        }
        private void rellenar_los_datos(Usuario usser)
        {
            ListViewItem item = new ListViewItem(usser.getNombreCompleto());
            item.SubItems.Add(usser.getContraseña());
            item.SubItems.Add(usser.getMail());
            if (usser.esAdministrador())
            {
                item.SubItems.Add("Admin");
            }
            else { item.SubItems.Add("Común"); }
            InfoActual.Items.Add(item);
        }

        private void OpcionSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void IngresarUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpcionNo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
