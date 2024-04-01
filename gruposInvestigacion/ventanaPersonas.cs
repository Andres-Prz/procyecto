using System;
using Wisej.Web;

namespace gruposInvestigacion
{
    public partial class ventanaPersonas : Form
    {
        public ventanaPersonas()
        {
            InitializeComponent();
        }

        private void ventanaPersonas_Load(object sender, EventArgs e)
        {
            refreshScreen();
            txtId.Enabled = false;
        }

        public void refreshScreen()
        {
            dataGridView1.DataSource = PersonaDAL.presentarPersona();
            clearScreen();
        }

        public void clearScreen()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            comBoxGenero.SelectedIndex = -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OPersona persona = new OPersona();
            persona.nombre = txtNombre.Text;
            persona.edad = Convert.ToInt32(txtEdad.Text);
            persona.genero = comBoxGenero.Text;

            int result = PersonaDAL.agregarPersona(persona);

            if (result > 0)
            {
                MessageBox.Show("Exito al guardar");
            }
            else
            {
                MessageBox.Show("No se logro guardar");

            }

            refreshScreen();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            OPersona persona = new OPersona();
            persona.nombre = txtNombre.Text;
            persona.edad = Convert.ToInt32(txtEdad.Text);
            persona.genero = comBoxGenero.Text;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idPersona"].Value);
            persona.idPersona = id;

            int result = PersonaDAL.modificarPersona(persona);



            if (result > 0)
            {
                MessageBox.Show("Exito al editar registro");
            }
            else
            {
                MessageBox.Show("No se logro editar el registro");

            }
            refreshScreen();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["idPersona"].Value);
            txtNombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nombre"].Value);
            txtEdad.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["edad"].Value);
            comBoxGenero.SelectedItem = dataGridView1.CurrentRow.Cells["genero"].Value;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idPersona"].Value);
                int resultado = PersonaDAL.eliminarPersona(id);
                if (resultado > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                }
                else
                {
                    MessageBox.Show("Eliminado con exito");
                }
            }

            refreshScreen();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clearScreen();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshScreen();
        }
    }
}
