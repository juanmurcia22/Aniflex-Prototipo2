export type Serie = {
  id: string;
  titulo: string;
  temporadas: number;
  calificacion: number;
  fechaEstreno: string;
  enEmision: boolean;
};

// Builder de Serie
export class SerieBuilder {
  private datos: Partial<Serie> = {};

  id(v: string) { this.datos.id = v; return this; }
  titulo(v: string) { this.datos.titulo = v; return this; }
  temporadas(v: number) { this.datos.temporadas = v; return this; }
  calificacion(v: number) { this.datos.calificacion = v; return this; }
  fechaEstreno(v: string) { this.datos.fechaEstreno = v; return this; }
  enEmision(v: boolean) { this.datos.enEmision = v; return this; }

  build(): Serie {
    const d = this.datos;
    if (d.id === undefined || d.titulo === undefined || d.temporadas === undefined ||
        d.calificacion === undefined || d.fechaEstreno === undefined || d.enEmision === undefined) {
      throw new Error('Faltan atributos para construir la Serie.');
    }
    return d as Serie;
  }
}
