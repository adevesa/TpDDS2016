using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using AlmacenadorBusquedas;

namespace InterfaceGrafica
{
    public partial class PantallaHistorial : Form
    {
        public PantallaHistorial()
        {
            InitializeComponent();
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //BOTON ACEPTAR//
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            Info.Clear();
            if (Usuario.Text.ToString() == "")
            {
                if (Desde.Text.ToString() != "" && Hasta.Text.ToString() != "")
                {
                    generar_lista_por_fecha();
                }
                MessageBox.Show("Ingrese fechas o nombre de usuario");
                Desde.Clear();
                Hasta.Clear();
            }
            else { generar_lista_por_usuario(); }

        }

        private void generar_lista_por_usuario()
        {
            List<busquedaPorUsuario> lista = AlmacenadorDeBusquedas.generarReportePorUsuario(Usuario.Text.ToString());
            if(lista.Count() == 0)
            {
                MessageBox.Show("Este usuario no tiene busquedas realizadas");
            }
            rellenar_lista_por_usuario(lista);
        }

        private void generar_lista_por_fecha()
        {
            //Genero los datetimes//
            string pattern = "dd-mm-yy";
            DateTime fechaIncial;
            DateTime fechaFinal;
            DateTime.TryParseExact(Desde.Text.ToString(), pattern, null,
                                   DateTimeStyles.None, out fechaIncial);
            DateTime.TryParseExact(Hasta.Text.ToString(), pattern, null,
                                  DateTimeStyles.None, out fechaFinal);

            //Busco resultados//
            List<busquedaPorFecha> lista = AlmacenadorDeBusquedas.generarReportePorFecha(fechaIncial, fechaFinal);
            if (lista.Count() == 0)
            {
                MessageBox.Show("No existen busquedas entre las fechas mencionadas");
            }
            rellenar_lista_por_fecha(lista);
        }
        private void rellenar_lista_por_fecha(List<busquedaPorFecha> lista)
        {
            Info.Clear();
            Info.Columns.Add("Fecha");
            Info.Columns.Add("Cantidad resultados");
            foreach(busquedaPorFecha unabusqueda in lista)
            {
                ListViewItem item = new ListViewItem(unabusqueda.fecha.ToString());
                item.SubItems.Add(unabusqueda.cantidadDeResultados.ToString());
            }
        }

        private void rellenar_lista_por_usuario(List<busquedaPorUsuario> lista)
        {
            Info.Clear();
            Info.Columns.Add("Usuario");
            Info.Columns.Add("Cantidad de resultados");
            foreach(busquedaPorUsuario unabusqueda in lista)
            {
                ListViewItem item = new ListViewItem(unabusqueda.nombreDelUsuario.ToString());
                item.SubItems.Add(unabusqueda.cantidadDeResultados.ToString());
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            //BotonAplicar.Size = new Size(150, 150);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Desde_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
