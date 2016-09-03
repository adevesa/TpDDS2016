using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositorio;

namespace InterfaceGrafica
{
    public partial class PantallaBorrarPoi : Form
    {
        //Atributos//
        private RepositorioDePois repo;

        public PantallaBorrarPoi()
        {
            repo = RepositorioDePois.getInstance();
            InitializeComponent();
        }

        private void PantallaCrearCuenta_Load(object sender, EventArgs e)
        {
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON CONFIRMAR BORRADO -- ELIMINA EL POI//
        private void BotonConfirmar2_Click(object sender, EventArgs e)
        {
            if (repo.verificarExistencia(PoiABorrar.Text.ToString()))
            {
                MessageBox.Show("ATENCION: se borrará un poi");
                repo.localOrigin.borrar2(repo.localOrigin.buscarPoiLlamado(PoiABorrar.Text.ToString()));
                this.Close();
            }
            else MessageBox.Show("No existe el poi que intenta eliminar");
            
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

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
