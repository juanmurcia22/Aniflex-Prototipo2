export type Episodio = {
  id: string;
  serieId: string;
  noEpisodio: number;
  titulo: string;
  calificacion: number;
  fechaEmision: string;
  esEspecial: boolean;
};

// Builder de Episodio
export class EpisodioBuilder {
  private datos: Partial<Episodio> = {};

  id(v: string) { this.datos.id = v; return this; }
  serieId(v: string) { this.datos.serieId = v; return this; }
  noEpisodio(v: number) { this.datos.noEpisodio = v; return this; }
  titulo(v: string) { this.datos.titulo = v; return this; }
  calificacion(v: number) { this.datos.calificacion = v; return this; }
  fechaEmision(v: string) { this.datos.fechaEmision = v; return this; }
  esEspecial(v: boolean) { this.datos.esEspecial = v; return this; }

  build(): Episodio {
    const d = this.datos;
    if (d.id === undefined || d.serieId === undefined || d.noEpisodio === undefined ||
        d.titulo === undefined || d.calificacion === undefined ||
        d.fechaEmision === undefined || d.esEspecial === undefined) {
      throw new Error('Faltan atributos para construir el Episodio.');
    }
    return d as Episodio;
  }
}
