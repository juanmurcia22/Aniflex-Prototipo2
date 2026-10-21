export type Listener = () => void;

// Sujeto Observer
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
