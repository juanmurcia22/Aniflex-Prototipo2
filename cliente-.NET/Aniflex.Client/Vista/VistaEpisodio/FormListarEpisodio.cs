using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aniflex.Client.Controlador;
using Aniflex.Client.Modelo;
using Aniflex.Client.Servicios;
using System.Threading.Tasks;

namespace Aniflex.Client.Vista.VistaEpisodio
{
    public partial class FormListarEpisodio : Form
    {
        private readonly ServicioEpisodio _service = ServicioEpisodio.GetInstance();
        private readonly ServicioSerie _serviceSerie = ServicioSerie.GetInstance();

        public FormListarEpisodio()
        {
            InitializeComponent();

            cmbSerie.DropDownStyle = ComboBoxStyle.DropDownList;

            // Suscripción al Observer
            EpisodioObserver.OnEpisodiosCambiados += RefrescarGrilla;
            FormClosed += FormListarEpisodio_FormClosed;
            Load += FormListarEpisodio_Load_1;
        }

        private async void FormListarEpisodio_Load_1(object sender, EventArgs e)
        {
            await CargarSeriesAsync();
            await CargarEpisodios();
        }
        private async Task CargarSeriesAsync()
        {
            try
            {
                var series = await _serviceSerie.ListarAsync();

                cmbSerie.DataSource = series;
                cmbSerie.DisplayMember = nameof(Serie.Titulo);
                cmbSerie.ValueMember = nameof(Serie.Id);
                cmbSerie.SelectedIndex = -1; // -1 = sin filtro por serie
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron cargar las series: {ex.Message}");
            }
        }

        private async Task CargarEpisodios()
        {
            string serieId = cmbSerie.SelectedValue?.ToString();   // null si no hay selección
            string titulo = txtTituloContiene.Text.Trim();

            try
            {
                List<Episodio> episodios = await _service.ListarAsync(
                    string.IsNullOrEmpty(serieId) ? null : serieId,
                    string.IsNullOrEmpty(titulo) ? null : titulo);

                dgvEpisodios.DataSource = null;
                dgvEpisodios.DataSource = episodios;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar episodios: {ex.Message}");
            }
        }

        private async void RefrescarGrilla()
        {
            // Lo invoca el Observer cuando se adiciona, actualiza o elimina un episodio
            await CargarEpisodios();
        }

        private void FormListarEpisodio_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Desuscripción limpia del Observer
            EpisodioObserver.OnEpisodiosCambiados -= RefrescarGrilla;
        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            await CargarEpisodios();
        }

        private async void buttonLimpiar_Click(object sender, EventArgs e)
        {
            txtTituloContiene.Clear();
            cmbSerie.SelectedIndex = -1;

            await CargarEpisodios();
        }
    }
}
