using Aniflex.Client.Controlador;
using Aniflex.Client.Modelo;
using Aniflex.Client.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aniflex.Client
{
    public partial class FormListarSerie : Form
    {
        private readonly ServicioSerie _service = ServicioSerie.GetInstance();

        public FormListarSerie()
        {
            InitializeComponent();

            // Suscripción al Observer
            SerieObserver.OnSeriesCambiadas += RefrescarGrilla;
        }

        private async void FormListar_Load(object sender, EventArgs e)
        {
            await CargarSeries();
        }

        private async void buttonFiltrar_Click(object sender, EventArgs e)
        {
            await CargarSeries();
        }

        private async System.Threading.Tasks.Task CargarSeries()
        {
            string calMin = textCalificacionMin.Text.Trim();
            string tituloCont = txtTituloContiene.Text.Trim();

            try
            {
                List<Serie> series;

                if (string.IsNullOrEmpty(tituloCont) &&
                    string.IsNullOrEmpty(calMin))
                {
                    series = await _service.ListarAsync();
                }
                else if (!string.IsNullOrEmpty(calMin))
                {
                    if (!double.TryParse(calMin, out double calificacion))
                    {
                        MessageBox.Show("Ingrese una calificación mínima válida.");
                        return;
                    }

                    series = await _service.ListarAsync(tituloCont, calificacion);
                }
                else
                {
                    series = await _service.ListarAsync(tituloCont, 0);
                }

                dgvSeries.DataSource = null;
                dgvSeries.DataSource = series;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar series: {ex.Message}");
            }

        }

        private async void RefrescarGrilla()
        {
            // Método que invoca el Observer cuando ocurre una modificación
            await CargarSeries();
        }

        private void FormListar_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Desuscripción limpia del Observer
            SerieObserver.OnSeriesCambiadas -= RefrescarGrilla;
        }

        private void FormListar_Load_1(object sender, EventArgs e)
        {

        }

        private async void buttonLimpiar_Click_1(object sender, EventArgs e)
        {
            txtTituloContiene.Clear();
            textCalificacionMin.Clear();

            await CargarSeries();
        }
    }
}

