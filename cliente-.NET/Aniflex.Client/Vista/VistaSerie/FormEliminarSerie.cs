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
    public partial class FormEliminarSerie : Form
    {
        private readonly ServicioSerie _service = ServicioSerie.GetInstance();
        public FormEliminarSerie()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtId.Text.Trim();
                string titulo = txtTituloEliminar.Text.Trim();

                if (string.IsNullOrEmpty(id) & string.IsNullOrEmpty(titulo))
                {
                    MessageBox.Show("Por favor ingresa un ID o un titulo.");
                    return;
                }

                Serie p = await _service.BuscarAsync(id,titulo);

                if (p != null)
                {
                    txtTitulo.Text = p.Titulo;
                    textBoxID.Text = p.Id;
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
                    MessageBox.Show("No se encontró ninguna serie con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}");
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxID.Text.Trim();

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Ingresa el ID de la serie a eliminar.");
                    return;
                }

                var confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar esta serie?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    bool eliminado = await _service.EliminarAsync(id);

                    if (eliminado)
                    {
                        MessageBox.Show("Serie eliminada correctamente.");
                        SerieObserver.NotificarCambio();
                        txtId.Clear();
                        txtTituloEliminar.Clear();
                        textBoxID.Clear();
                        txtTemporadas.Clear();
                        txtCalificacion.Clear();
                        txtTitulo.Clear();
                        chkEnEmision.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar o el ID no existe.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}");
            }
        }

        private void txtIdBuscar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormEliminar_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePickerEstreno_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
