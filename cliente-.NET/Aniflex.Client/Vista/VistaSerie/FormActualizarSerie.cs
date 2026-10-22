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

namespace Aniflex.Client
{
    public partial class FormActualizarSerie : Form
    {
        private readonly ServicioSerie _service = ServicioSerie.GetInstance();
        public FormActualizarSerie()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtId.Text.Trim();
                string titulo = txtTituloBuscar.Text.Trim();

                if (string.IsNullOrEmpty(id) & string.IsNullOrEmpty(titulo))
                {
                    MessageBox.Show("Por favor ingresa un ID o un titulo.");
                    return;
                }

                Serie p = await _service.BuscarAsync(id, titulo);

                if (p != null)
                {
                    textBoxID.Text = p.Id;
                    textBoxID.Enabled = false;
                    txtTitulo.Text = p.Titulo;
                    txtTemporadas.Text = p.Temporadas.ToString();
                    txtCalificacion.Text = p.Calificacion.ToString();
                    chkEnEmision.Checked = p.EnEmision;

                    if (DateTime.TryParse(p.FechaEstreno, CultureInfo.InvariantCulture,
                          DateTimeStyles.None, out DateTime fecha))
                    {
                        dateTimePickerEstreno.Value = fecha;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna serie con ese ID o titulo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}");
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxID.Text.Trim();

                if (string.IsNullOrEmpty(id) || !int.TryParse(txtTemporadas.Text, out int Temporadas) || !double.TryParse(txtCalificacion.Text, out double calificacion))
                {
                    MessageBox.Show("Verifica que los campos contengan valores numéricos válidos.");
                    return;
                }

                Serie pEditada = new Serie
                {
                    Id = id,
                    Titulo = txtTitulo.Text.Trim(),
                    Temporadas = Temporadas,
                    Calificacion = calificacion,
                    EnEmision = chkEnEmision.Checked,
                    FechaEstreno = dateTimePickerEstreno.Value.ToString("yyyy-MM-dd'T'HH:mm:ss", CultureInfo.InvariantCulture)
                };

                Serie resultado = await _service.ActualizarAsync(pEditada);

                if (resultado != null)
                {
                    MessageBox.Show("Serie actualizada exitosamente.");
                    SerieObserver.NotificarCambio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar: {ex.Message}");
            }
        }

        private void FormActualizar_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
