import { SerieController } from '../controllers/SerieController';
import { type Serie, SerieBuilder } from '../models/Serie';
import { decimal, entero, fechaHora, texto } from '../utils/parseo';
import type { EntityConfig } from './EntityConfig';

export const serieConfig: EntityConfig<Serie> = {
  nombre: 'Serie',
  campos: [
    { key: 'id', label: 'ID', tipo: 'text', soloLecturaAlEditar: true },
    { key: 'titulo', label: 'Título', tipo: 'text' },
    { key: 'temporadas', label: 'Temporadas', tipo: 'int' },
    { key: 'calificacion', label: 'Calificación (0-10)', tipo: 'float' },
    { key: 'fechaEstreno', label: 'Fecha de estreno', tipo: 'datetime' },
    { key: 'enEmision', label: 'En emisión', tipo: 'boolean' },
  ],
  camposBusqueda: [
    { key: 'id', label: 'ID', tipo: 'text' },
    { key: 'titulo', label: 'Título (exacto)', tipo: 'text' },
  ],
  camposFiltro: [
    { key: 'titulo', label: 'Título contiene', tipo: 'text' },
    { key: 'calificacionMinima', label: 'Calificación mínima', tipo: 'float' },
  ],
  controller: SerieController.getInstance(),
  desdeFormulario: (r) =>
    new SerieBuilder()
      .id(texto(String(r.id), 'ID'))
      .titulo(texto(String(r.titulo), 'Título'))
      .temporadas(entero(String(r.temporadas), 'Temporadas', 1))
      .calificacion(decimal(String(r.calificacion), 'Calificación', 0, 10))
      .fechaEstreno(fechaHora(String(r.fechaEstreno), 'Fecha de estreno'))
      .enEmision(r.enEmision === true)
      .build(),
};
