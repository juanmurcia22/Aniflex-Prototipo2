import { useState } from 'react';
import type { EntityConfig } from '../../entities/EntityConfig';
import { EntityDetail } from '../components/EntityDetail';
import { SearchPanel } from '../components/SearchPanel';

/** Caso de uso: BUSCAR (consulta de UN solo objeto con uno o dos parámetros). */
export function BuscarWindow<T extends { id: string }>({ config }: { config: EntityConfig<T> }) {
  const [encontrado, setEncontrado] = useState<T | null>(null);

  return (
    <>
      <SearchPanel config={config} onResultado={setEncontrado} />
      {encontrado && <EntityDetail campos={config.campos} entidad={encontrado} />}
    </>
  );
}
