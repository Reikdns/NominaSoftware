using BLL.Enums;
using BLL.Services;
using Entity;

namespace GUI
{
    public partial class Formulario : Form
    {
        public NominaServices NominaServices { get; set; }

        public Formulario()
        {
            InitializeComponent();
            NominaServices = new NominaServices();

            dataGridView1.DataSource = NominaServices.ObtenerDocentes();

            Normalizar();
            ValidarSeccion1();
            ValidarSeccionII();
            rdbtn_opcion2.Checked = true;
            tab2_rdbtn_opcion1.Checked = true;
        }

        private void Formulario_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           

        }

        private void tab1_btn_submit_Click(object sender, EventArgs e)
        {

            
        }

        private Categorias DefinirCategoria()
        {
            if (tab2_rdbtn_opcion2.Checked)
            {
                return Categorias.Asistente;
            }

            if (tab2_rdbtn_opcion3.Checked)
            {
                return Categorias.Asociado;
            }

            if (tab2_rdbtn_opcion4.Checked)
            {
                return Categorias.Titular;
            }

            return Categorias.Instructor;
        }

        private void ValidarSeccion1()
        {
            if (rdbtn_opcion1.Checked)
            {
                tab1_txtbx2.Text = "0";
                tab1_txtbx2.Enabled = false;
                tab1_txtbx1.Enabled = true;
            }
            if (rdbtn_opcion2.Checked)
            {
                tab1_txtbx1.Text = "0";
                tab1_txtbx1.Enabled = false;
                tab1_txtbx2.Enabled = true;
            }
        }

        private void ValidarSeccionII()
        {
            if (tab3_txtbx1.Text.Equals(string.Empty))
            {
                tab3_txtbx1.Text = "0";
            }
            if(tab3_txtbx2.Text.Equals(string.Empty))
            {
                tab3_txtbx2.Text = "0";
            }
            if (tab3_txtbx3.Text.Equals(string.Empty))
            {
                tab3_txtbx3.Text = "0";
            }
            if (tab3_txtbx4.Text.Equals(string.Empty))
            {
                tab3_txtbx4.Text = "0";
            }
        }



        private void Normalizar()
        {
            tab1_txtbx1.Text = string.IsNullOrEmpty(tab1_txtbx1.Text) ? "0" : tab1_txtbx1.Text;
            tab1_txtbx2.Text = string.IsNullOrEmpty(tab1_txtbx2.Text) ? "0" : tab1_txtbx2.Text;
            tab1_txtbx3.Text = string.IsNullOrEmpty(tab1_txtbx3.Text) ? "0" : tab1_txtbx3.Text;
            tab1_txtbx4.Text = string.IsNullOrEmpty(tab1_txtbx4.Text) ? "0" : tab1_txtbx4.Text;
        }

        private void rdbtn_opcion1_CheckedChanged(object sender, EventArgs e)
        {
            ValidarSeccion1();
        }

        private void rdbtn_opcion2_CheckedChanged(object sender, EventArgs e)
        {
            ValidarSeccion1();
        }

        private void tab1_btn_submit_Click_1(object sender, EventArgs e)
        {
            prueba.Text = "Nomina: $" + NominaServices.ObtenerNomina().ToString();
        }

        private void prueba_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Titulos titulo = rdbtn_opcion1.Checked ? Titulos.Medicina_Musica : Titulos.OtraArea;
            NominaServices.CalcularPuntosCalcularPuntosPorTitulosDePregrado(titulo);
            NominaServices.CalcularPuntosCalcularPuntosPorTitulosDePosgrado(int.Parse(tab1_txtbx1.Text), int.Parse(tab1_txtbx2.Text), int.Parse(tab1_txtbx3.Text), int.Parse(tab1_txtbx4.Text));

            ValidarSeccionII();
            Normalizar();

            Docente docente = new Docente();
            docente.Puntos = NominaServices.ObtenerPuntosSeccionI();
            docente.Puntos += NominaServices.ObtenerPuntosSeccionII(DefinirCategoria());
            docente.Puntos += NominaServices.ObtenerPuntosSeccionIII(DefinirCategoria(), int.Parse(tab3_txtbx1.Text), int.Parse(tab3_txtbx2.Text), int.Parse(tab3_txtbx3.Text), int.Parse(tab3_txtbx4.Text));
            docente.Categoria = DefinirCategoria().ToString();
            docente.CalcularSalario();

            NominaServices.AgregarDocente(docente);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = NominaServices.ObtenerDocentes();

            NominaServices.CalcularNomina();
        }
    }
}