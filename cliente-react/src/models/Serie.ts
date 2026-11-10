export type Serie = {
  id: string;
  titulo: string;
  temporadas: number;
  calificacion: number;
  fechaEstreno: string;
  enEmision: boolean;
};

// Serie que todavía no existe en el servidor: aún no tiene id (lo genera MongoDB al insertar)
export type SerieNueva = Omit<Serie, 'id'>;

// Builder de Serie
export class SerieBuilder {
  private datos: Partial<Serie> = {};

  id(v: string) { this.datos.id = v; return this; }
  titulo(v: string) { this.datos.titulo = v; return this; }
  temporadas(v: number) { this.datos.temporadas = v; return this; }
  calificacion(v: number) { this.datos.calificacion = v; return this; }
  fechaEstreno(v: string) { this.datos.fechaEstreno = v; return this; }
  enEmision(v: boolean) { this.datos.enEmision = v; return this; }

  /** Para ADICIONAR: sin id (lo genera el servidor). */
  buildNueva(): SerieNueva {
    const { id: _omitido, ...resto } = this.build(false);
    return resto;
  }

  /** Para ACTUALIZAR: el id es obligatorio. */
  build(exigirId = true): Serie {
    const d = this.datos;
    if ((exigirId && d.id === undefined) || d.titulo === undefined || d.temporadas === undefined ||
        d.calificacion === undefined || d.fechaEstreno === undefined || d.enEmision === undefined) {
      throw new Error('Faltan atributos para construir la Serie.');
    }
    return d as Serie;
  }
}
