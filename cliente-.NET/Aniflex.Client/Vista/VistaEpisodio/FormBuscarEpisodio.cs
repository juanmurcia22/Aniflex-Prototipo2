using Aniflex.Client.Modelo;
using Aniflex.Client.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Aniflex.Client.Vista.VistaEpisodio
{
    public partial class FormBuscarEpisodio : Form
    {
        private readonly ServicioEpisodio _service = ServicioEpisodio.GetInstance();
        private readonly ServicioSerie _serviceSerie = ServicioSerie.GetInstance();

        public FormBuscarEpisodio()
        {
            InitializeComponent();
            dateTimePickerEstreno.Format = DateTimePickerFormat.Custom;
            dateTimePickerEstreno.CustomFormat = "yyyy-MM-dd HH:mm";
            cmbSerie.DropDownStyle = ComboBoxStyle.DropDownList;
            Load += FormBuscarEpisodio_Load;
        }

        private async void FormBuscarEpisodio_Load(object sender, EventArgs e)
        {
            await CargarSeriesAsync();
        }
        private async Task CargarSeriesAsync()
        {
            try
            {
                var series = await _serviceSerie.ListarAsync();

                cmbSerie.DataSource = series;
                cmbSerie.DisplayMember = nameof(Serie.Titulo);
                cmbSerie.ValueMember = nameof(Serie.Id);
                cmbSerie.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron cargar las series: {ex.Message}", "Error de Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbSerie.SelectedValue == null)
                {
                    MessageBox.Show("Selecciona una serie.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string serieId = cmbSerie.SelectedValue.ToString();

                if (!int.TryParse(txtNumEliminar.Text, out int noEpisodio))
                {
                    MessageBox.Show("El nº de episodio debe ser un número entero válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Episodio ep = await _service.BuscarAsync(serieId, noEpisodio);

                if (ep != null)
                {
                    textBoxID.Text = ep.Id;
                    txtTitulo.Text = ep.Titulo;
                    txtCalificacion.Text = ep.Calificacion.ToString();
                    txtNumEpisodio.Text = ep.NoEpisodio.ToString();
                    chkEsEspecial.Checked = ep.EsEspecial;
                    txtSerie.Text = ep.SerieId.ToString();

                    if (DateTime.TryParse(ep.FechaEmision, CultureInfo.InvariantCulture,
                            DateTimeStyles.None, out DateTime fecha))
                    {
                        dateTimePickerEstreno.Value = fecha;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ese episodio en la serie seleccionada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}");
            }
        }
    }
}
