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
    public partial class FormAgregarSerie : Form
    {
        private readonly ServicioSerie _service = ServicioSerie.GetInstance();

        public FormAgregarSerie()
        {
            InitializeComponent();
            dateTimePickerEstreno.Format = DateTimePickerFormat.Custom;
            dateTimePickerEstreno.CustomFormat = "yyyy-MM-dd HH:mm";
        }

        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtTemporadas.Clear();
            txtCalificacion.Clear();
            chkEnEmision.Checked = false;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lectura y casteo de datos desde los controles de la UI
                string titulo = txtTitulo.Text.Trim();

                if (string.IsNullOrEmpty(titulo))
                {
                    MessageBox.Show("El título es obligatorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Casteo/Parseo de cadenas a tipos numéricos
                if (!int.TryParse(txtTemporadas.Text, out int temporadas))
                {
                    MessageBox.Show("El num. de temporadas debe ser un número entero válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtCalificacion.Text, out double calificacion))
                {
                    MessageBox.Show("La calificacion debe ser un valor numérico válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool enEmision = chkEnEmision.Checked;

                string fechaEstreno = dateTimePickerEstreno.Value.ToString("yyyy-MM-dd'T'HH:mm:ss", CultureInfo.InvariantCulture);

                Serie nuevaSerie = new Serie
                {
                    Titulo = titulo,
                    Temporadas = temporadas,
                    Calificacion = calificacion,
                    EnEmision = enEmision,
                    FechaEstreno = fechaEstreno
                };

                Serie resultado = await _service.AdicionarAsync(nuevaSerie);

                if (resultado != null)
                {
                    MessageBox.Show($"Serie '{resultado.Titulo}' creada con éxito (ID: {resultado.Id}).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SerieObserver.NotificarCambio();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error de Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
