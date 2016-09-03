using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrigenesDeDatos;
using LibreriaClasesPoi;
using Repositorio;

namespace InterfaceGrafica
{
    public partial class PantallaCrearPOI : Form
    {
        //ATRIBUTOS//
        private RepositorioDePois repositorio;
        private Dictionary<String, Tuple<int, int>> horarios;

        //CONSTRUCTOR//
        public PantallaCrearPOI()
        {
            this.repositorio = RepositorioDePois.getInstance();
            InitializeComponent();
        }

        private void PantallaCrearCuenta_Load(object sender, EventArgs e)
        {
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON CONFIRMAR -- CREA UN POI//
        private void BotonConfirmar2_Click(object sender, EventArgs e)
        {
            POI new_poi = modelarPoi();
            repositorio.localOrigin.agregar(new_poi);
            this.Close();
        }

        //MODELAR -- MODELA UN POI//
        private POI modelarPoi()
        {
            switch (Rubros.Text.ToString())
            {
                case "CGP": return modelarCGP();
                case "Banco": return modelarBanco();
                case "Local comercial": return modelarLocal();
                default: return modelarParadaDeColectivo();
            }
        }

        private void agregar_baja_palabras_claves_y_horarios(POI poi)
        {
            agregar_fecha_de_baja(poi);
            agregar_palabras_claves(poi);
            agregar_horarios(poi);
        }

        private CGP modelarCGP()
        {
            CGP new_cgp = new CGP(int.Parse(Comuna.Text), Direccion.Text.ToString());
            new_cgp.Nombre = Nombre.Text.ToString();
            agregar_baja_palabras_claves_y_horarios(new_cgp);
            return new_cgp;
        }

        private Banco modelarBanco()
        {
            Banco banco = new Banco(Nombre.Text.ToString());
            banco.setComuna(int.Parse(Comuna.Text));
            banco.setDireccion(Direccion.Text.ToString());
            agregar_baja_palabras_claves_y_horarios(banco);
            return banco;
        }

        private LocalComercial modelarLocal()
        {
            LocalComercial local = new LocalComercial(Nombre.Text.ToString(), Direccion.Text.ToString());
            local.setComuna(int.Parse(Comuna.Text));
            agregar_baja_palabras_claves_y_horarios(local);
            return local;
        }

        private ParadaDeColectivo modelarParadaDeColectivo()
        {
            ParadaDeColectivo parada = new ParadaDeColectivo(Nombre.Text.ToString());
            parada.setComuna(int.Parse(Comuna.Text));
            parada.setDireccion(Direccion.Text.ToString());
            agregar_baja_palabras_claves_y_horarios(parada);
            return parada;
        }

        private void agregar_fecha_de_baja(POI poi)
        {
            int anio = (int)AnioDeBaja.Value;
            int mes = (int)MesDeBaja.Value;
            int dia = (int)DiaDeBaja.Value;
            DateTime fechaDeBaja = new DateTime(anio, mes, dia, 12, 0, 0);
            poi.setFechaDeBaja(fechaDeBaja);
        }

        private void agregar_palabras_claves(POI poi)
        {
            foreach(object item in ListaDePalabrasClaves.Items)
            {
                poi.agregarPalabraClave((string)item);
            }
        }

        private void agregar_horarios(POI poi)
        {
            agregar_horario_dia("lunes", poi);
            agregar_horario_dia("martes", poi);
            agregar_horario_dia("miercoles", poi);
            agregar_horario_dia("jueves", poi);
            agregar_horario_dia("viernes", poi);
            agregar_horario_dia("sabado", poi);
            agregar_horario_dia("domingo", poi);
        }

        private void agregar_horario_dia(string dia, POI poi)
        {
            Tuple<int, int> horarioss;
            bool i = this.horarios.TryGetValue(dia, out horarioss);
            poi.agregarDiaYHorario("full", horarioss.Item1, horarioss.Item2, dia);
        }


        /*      BOTONES SIN IMPORTANCIA                */
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

        //BOTON HORARIOS DE ATENCION -- MANIPULA UNA LISTA CON LOS HORARIOS DE ATENCION//
        private void button1_Click(object sender, EventArgs e)
        {

            PantallaHorarios pantallaHorarios = new PantallaHorarios();
            pantallaHorarios.ShowDialog();
            this.horarios = pantallaHorarios.horarios;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //BOTON AGREGAR -- AGREGA PALABRA CLAVE A LISTBOX DE PALABRAS CLAVES//
        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            string palabraClave = PalabraClave.Text.ToString();
            ListaDePalabrasClaves.Items.Add(palabraClave);
            PalabraClave.Clear();
        }

        //BOTON QUITAR -- QUITA UNA PALABRA CLAVE LISTBOX DE PALABRAS CLAVES//
        private void BotonQuitar_Click(object sender, EventArgs e)
        {
            ListaDePalabrasClaves.Items.RemoveAt(ListaDePalabrasClaves.SelectedIndex);
        }

        private void Rubros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
