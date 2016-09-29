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
using LibreriaClasesPoi;
using HorariosDeAtencion;

namespace InterfaceGrafica
{
    public partial class PantallaEditarPOI : Form
    {
        //Atributos//
        private RepositorioDePois repo;
        private Dictionary<String, Tuple<int, int>> horarios;
        private bool boton_horarios = false;

        //Constructor//
        public PantallaEditarPOI()
        {
            this.repo = RepositorioDePois.getInstance();
            InitializeComponent();
        }

        private void PantallaCrearCuenta_Load(object sender, EventArgs e)
        {
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON CONFIRMAR -- EJECUTA LA EDICION DEL POI//
        private void BotonConfirmar2_Click(object sender, EventArgs e)
        {
            POI new_poi = modelarPoi();
            repo.localOrigin.editar(new_poi);
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
            if (!boton_horarios)
            {
                agregar_horarios(poi);
            }
            else { copiar_mismos_horarios(poi); }
            
        }

        private void copiar_mismos_horarios(POI poi)
        {
           POI poiBuscado = repo.localOrigin.buscarPoiLlamado(poi.getNombre());
           foreach(HorarioDeAtencion horario in poiBuscado.getHorarioDeAtencion())
            {
                poi.agregarHorarioDeAtencion(horario);
            }
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
            foreach (object item in ListaDePalabrasClaves.Items)
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
        
        
        //BOTONES NO RELEVANTES//
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

        //BOTON HORARIO DE ATENCION -- LINKEA CON LISTA DE HORARIOS OBTENIDA //
        private void button1_Click(object sender, EventArgs e)
        {
            boton_horarios = true;
            PantallaHorarios pantallaHorarios = new PantallaHorarios();
            pantallaHorarios.ShowDialog();
            this.horarios = pantallaHorarios.horarios;
        }

        //BOTON BUSCAR -- RELLENA TODOS LOS FORMULARIOS//
        private void BotonBuscarPOI_Click(object sender, EventArgs e)
        {
            borrar_contenido_textos();
            if (repo.verificarExistencia(Nombre.Text.ToString()))
            {
                POI poi = repo.localOrigin.buscarPoiLlamado(Nombre.Text.ToString());
                Direccion.Paste(poi.getDireccion());
                mostrar_palabras_claves_listbox(poi);
                mostrar_comuna(poi);
                //mostrar_fecha_baja(poi);
            }
              else MessageBox.Show("No existe el poi buscado");
        }

        private void mostrar_comuna(POI poi)
        {
            if(poi.getComuna().ToString() == "0") { }
            else Comuna.Paste(poi.getComuna().ToString());

        }

        private void mostrar_fecha_baja(POI poi)
        {
            //if(poi.fechaDeBaja.Equals(null)) { }
           // else
            //{
                AnioDeBaja.Value = int.Parse(poi.getFechaBaja().Year.ToString());
                MesDeBaja.Value = int.Parse(poi.getFechaBaja().Month.ToString());
                DiaDeBaja.Value = int.Parse(poi.getFechaBaja().Day.ToString());
            //}
        }

        private void mostrar_palabras_claves_listbox(POI poi)
        {
            foreach(string palabra in poi.getPalabrasClaves())
            {
                ListaDePalabrasClaves.Items.Add(palabra);
            }
        }

        private void borrar_contenido_textos()
        {
            Direccion.Clear();
            ListaDePalabrasClaves.Items.Clear();
            Comuna.Clear();
            PalabraClave.Clear();
        }

        //BOTON QUITAR -- ELIMINA UN ELEMENTO DE LISTBOX//
        private void BotonQuitar_Click(object sender, EventArgs e)
        {
            ListaDePalabrasClaves.Items.RemoveAt(ListaDePalabrasClaves.SelectedIndex);
        }

        //BOTON AGREGAR -- AGREGA UNA PALABRA A LISTBOX//
        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            string palabraClave = PalabraClave.Text.ToString();
            ListaDePalabrasClaves.Items.Add(palabraClave);
            PalabraClave.Clear();
        }

        private void Comuna_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
