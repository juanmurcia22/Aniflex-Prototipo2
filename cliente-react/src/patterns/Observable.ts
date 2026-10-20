export type Listener = () => void;

/**
 * Patrón Observer (sujeto). Los observadores (p. ej. la ventana Listar) se suscriben
 * y reciben aviso cada vez que los datos cambian. subscribe() devuelve la función
 * para cancelar la suscripción.
 */
export class Observable {
  private readonly observadores = new Set<Listener>();

  subscribe(l: Listener): () => void {
    this.observadores.add(l);
    return () => { this.observadores.delete(l); };
  }

  notify(): void {
    this.observadores.forEach((l) => l());
  }
}
