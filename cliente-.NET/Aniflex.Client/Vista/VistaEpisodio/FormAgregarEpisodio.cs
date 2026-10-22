using Aniflex.Client.Controlador;
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
    public partial class FormAgregarEpisodio : Form
    {
        private readonly ServicioEpisodio _service = ServicioEpisodio.GetInstance();
        private readonly ServicioSerie _serviceSerie = ServicioSerie.GetInstance();

        public FormAgregarEpisodio()
        {
            InitializeComponent();
            dateTimePickerEstreno.Format = DateTimePickerFormat.Custom;
            dateTimePickerEstreno.CustomFormat = "yyyy-MM-dd HH:mm";
            cmbSerie.DropDownStyle = ComboBoxStyle.DropDownList;
            Load += FormAgregarEpisodio_Load;
        }

        private async void FormAgregarEpisodio_Load(object sender, EventArgs e)
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
                cmbSerie.SelectedIndex = -1; // obliga al usuario a elegir
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron cargar las series: {ex.Message}", "Error de Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNumEpisodio.Clear();
            txtTitulo.Clear();
            txtCalificacion.Clear();
            cmbSerie.SelectedIndex = -1;
            chkEsEspecial.Checked = false;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtId.Text.Trim();
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Debes ingresar un ID.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbSerie.SelectedValue == null)
                {
                    MessageBox.Show("Debes seleccionar una serie.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string serieId = cmbSerie.SelectedValue.ToString();

                if (!int.TryParse(txtNumEpisodio.Text, out int noEpisodio))
                {
                    MessageBox.Show("El nº de episodio debe ser un número entero válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (noEpisodio < 1)
                {
                    MessageBox.Show("El nº de episodio debe ser mayor o igual a 1.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string titulo = txtTitulo.Text.Trim();
                if (string.IsNullOrEmpty(titulo))
                {
                    MessageBox.Show("El título es obligatorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(txtCalificacion.Text, out double calificacion))
                {
                    MessageBox.Show("La calificación debe ser un valor numérico válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool esEspecial = chkEsEspecial.Checked;

                string fechaEmision = dateTimePickerEstreno.Value.ToString("yyyy-MM-dd'T'HH:mm:ss", CultureInfo.InvariantCulture);

                Episodio nuevoEpisodio = new Episodio
                {
                    Id = id,
                    SerieId = serieId,
                    NoEpisodio = noEpisodio,
                    Titulo = titulo,
                    Calificacion = calificacion,
                    FechaEmision = fechaEmision,
                    EsEspecial = esEspecial
                };

                Episodio resultado = await _service.AdicionarAsync(nuevoEpisodio);

                if (resultado != null)
                {
                    MessageBox.Show($"Episodio '{resultado.Titulo}' creado con éxito (ID: {resultado.Id}).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EpisodioObserver.NotificarCambio();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error de Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
