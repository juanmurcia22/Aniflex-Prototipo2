using Aniflex.Client.Vista.VistaEpisodio;

namespace Aniflex.Client
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void listarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarSerie formListar = new FormListarSerie();
            formListar.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarSerie formAgregar = new FormAgregarSerie();
            formAgregar.Show();
        }

        private void buscarConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscarSerie formBuscar = new FormBuscarSerie();
            formBuscar.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActualizarSerie formActualizar = new FormActualizarSerie();
            formActualizar.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminarSerie formEliminar = new FormEliminarSerie();
            formEliminar.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAcercaDe form = new FormAcercaDe();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormAgregarEpisodio form = new FormAgregarEpisodio();
            form.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FormEliminarEpisodio form = new FormEliminarEpisodio();
            form.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormBuscarEpisodio form = new FormBuscarEpisodio();
            form.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FormActualizarEpisodio form = new FormActualizarEpisodio();
            form.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormListarEpisodio form = new FormListarEpisodio();
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
