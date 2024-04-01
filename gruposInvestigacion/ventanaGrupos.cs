using System;
using System.Collections.Generic;
using Wisej.Web;

namespace gruposInvestigacion
{
    public partial class ventanaGrupos : Form
    {
        public ventanaGrupos()
        {
            InitializeComponent();
            txtId.Enabled = false;

        }

        private void ventanaGrupos_Load(object sender, EventArgs e)
        {
            refreshScreen();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CargarComboBoxPersonas()
        {

            List<OPersona> persona = PersonaDAL.llenadoIdLider();

            comBoxLider.DisplayMember = "Nombre";
            comBoxLider.ValueMember = "idPersona";
            comBoxLider.DataSource = persona;

            comBoxLider.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void refreshScreen()
        {
            CargarComboBoxPersonas();
            dataGridView1.DataSource = GrupoDAL.presentarGrupo();
            clearScreen();
        }
        public void clearScreen()
        {
            txtId.Clear();
            txtNombre.Clear();
            comBoxLider.SelectedIndex = -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            OGrupo grupo = new OGrupo();
            grupo.nombre = txtNombre.Text;
            grupo.idLider = ((OPersona)comBoxLider.SelectedItem).idPersona;

            int result = GrupoDAL.agregarGrupo(grupo);

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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idPersona = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idLider"].Value);

                // Buscar el índice del valor en el ComboBox 
                int indice = -1;
                for (int i = 0; i < comBoxLider.Items.Count; i++)
                {
                    if (((OPersona)comBoxLider.Items[i]).idPersona == idPersona)
                    {
                        indice = i;
                        break;
                    }
                }

                txtId.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["idGrupo"].Value);
                txtNombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nombre"].Value);

                // Establecer el índice seleccionado en el ComboBox
                if (indice != -1)
                {
                    comBoxLider.SelectedIndex = indice;
                }
                else
                {
                    // Si el valor no se encuentra en el ComboBox, deseleccionar cualquier elemento seleccionado
                    comBoxLider.SelectedIndex = -1;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            OGrupo grupo = new OGrupo();
            grupo.nombre = txtNombre.Text;
            grupo.idLider = ((OPersona)comBoxLider.SelectedItem).idPersona;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idGrupo"].Value);
            grupo.idGrupo = id;

            int result = GrupoDAL.modificarGrupo(grupo);



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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idGrupo"].Value);
                int resultado = GrupoDAL.eliminarGrupo(id);
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
