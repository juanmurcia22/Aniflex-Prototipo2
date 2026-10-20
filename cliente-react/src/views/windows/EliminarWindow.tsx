import { useState } from 'react';
import type { EntityConfig } from '../../entities/EntityConfig';
import { mensajeDe } from '../../utils/parseo';
import { EntityDetail } from '../components/EntityDetail';
import { type Msg, Mensaje } from '../components/Mensaje';
import { SearchPanel } from '../components/SearchPanel';

/** Caso de uso: ELIMINAR. Se busca, se muestra TODA la información y solo entonces se confirma. */
export function EliminarWindow<T extends { id: string }>({ config }: { config: EntityConfig<T> }) {
  const [encontrado, setEncontrado] = useState<T | null>(null);
  const [msg, setMsg] = useState<Msg | null>(null);

  async function eliminar() {
    if (!encontrado) return;
    if (!window.confirm(`¿Eliminar definitivamente el registro de ${config.nombre} con ID ${encontrado.id}?`)) return;
    try {
      const ok = await config.controller.eliminar(encontrado.id);
      setMsg(ok
        ? { tipo: 'ok', texto: `Se eliminó el registro de ${config.nombre} con ID ${encontrado.id}.` }
        : { tipo: 'error', texto: 'El servidor indicó que el registro ya no existía.' });
      setEncontrado(null);
    } catch (err) {
      setMsg({ tipo: 'error', texto: mensajeDe(err) });
    }
  }

  return (
    <>
      <SearchPanel config={config} onResultado={(e) => { setEncontrado(e); setMsg(null); }} />
      {encontrado && (
        <>
          <EntityDetail campos={config.campos} entidad={encontrado} />
          <div className="acciones"><button type="button" className="peligro" onClick={eliminar}>Eliminar</button></div>
        </>
      )}
      <Mensaje msg={msg} />
    </>
  );
}
