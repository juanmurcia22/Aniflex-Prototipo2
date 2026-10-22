using System;

namespace Aniflex.Client.Controlador
{
    public static class EpisodioObserver
    {
        public static event Action OnEpisodiosCambiados;
        public static void NotificarCambio() => OnEpisodiosCambiados?.Invoke();
    }
}
