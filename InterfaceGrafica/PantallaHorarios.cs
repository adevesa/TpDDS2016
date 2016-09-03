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
    public partial class PantallaHorarios : Form
    {
        public Dictionary<String, Tuple<int, int>> horarios;

        //CONSTRUCTOR//
        public PantallaHorarios()
        {
            this.horarios = new Dictionary<String, Tuple<int, int>>();
            InitializeComponent();
        }

        private void PantallaCrearCuenta_Load(object sender, EventArgs e)
        {
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON CONFIRMAR -- AGREGA LOS HORARIOS A UNA LISTA QUE SE USARÁ  PARA CREAR EL POI//
        private void BotonConfirmar2_Click(object sender, EventArgs e)
        {
            agregar_elementos_a_lista_horarios();
            this.Close();
        }
        
        private void agregar_elementos_a_lista_horarios()
        {
            Tuple<int, int> lunes = new Tuple<int, int>((int)LunesDesde.Value, (int)LunesHasta.Value);
            horarios.Add("lunes", lunes);

            Tuple<int, int> martes = new Tuple<int, int>((int)MartesDesde.Value, (int)MartesHasta.Value);
            horarios.Add("martes", martes);

            Tuple<int, int> miercoles = new Tuple<int, int>((int)MiercolesDesde.Value, (int)MiercolesHasta.Value);
            horarios.Add("miercoles", miercoles);

            Tuple<int, int> jueves = new Tuple<int, int>((int)JuevesDesde.Value, (int)JuevesHasta.Value);
            horarios.Add("jueves", jueves);

            Tuple<int, int> viernes = new Tuple<int, int>((int)ViernesDesde.Value, (int)ViernesHasta.Value);
            horarios.Add("viernes", viernes);

            Tuple<int, int> sabado = new Tuple<int, int>((int)SabadoDesde.Value, (int)SabadoHasta.Value);
            horarios.Add("sabado", sabado);

            Tuple<int, int> domingo = new Tuple<int, int>((int)DomingoDesde.Value, (int)DomingoHasta.Value);
            horarios.Add("domingo", domingo);
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

    }
}
