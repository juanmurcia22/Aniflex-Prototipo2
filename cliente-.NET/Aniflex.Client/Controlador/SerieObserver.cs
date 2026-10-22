using System;

namespace Aniflex.Client.Controlador
{
    public static class SerieObserver
    {
        // Evento al que se suscribirá el formulario de listar
        public static event Action OnSeriesCambiadas;

        // Método para notificar el cambio
        public static void NotificarCambio() => OnSeriesCambiadas?.Invoke();
    }
}
