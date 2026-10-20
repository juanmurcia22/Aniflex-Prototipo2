import { type FormEvent, useState } from 'react';
import { type EntityConfig, type Raw, aFormulario } from '../../entities/EntityConfig';
import { mensajeDe } from '../../utils/parseo';
import { EntityForm } from '../components/EntityForm';
import { type Msg, Mensaje } from '../components/Mensaje';
import { SearchPanel } from '../components/SearchPanel';

/** Caso de uso: ACTUALIZAR. Primero se busca el objeto; luego se muestran TODOS sus atributos para editarlos. */
export function ActualizarWindow<T extends { id: string }>({ config }: { config: EntityConfig<T> }) {
  const [encontrado, setEncontrado] = useState<T | null>(null);
  const [valores, setValores] = useState<Raw>({});
  const [msg, setMsg] = useState<Msg | null>(null);

  function alBuscar(e: T | null) {
    setEncontrado(e);
    setMsg(null);
    if (e) setValores(aFormulario(config.campos, e));
  }

  async function guardar(e: FormEvent) {
    e.preventDefault();
    try {
      const actualizado = await config.controller.actualizar(config.desdeFormulario(valores));
      setEncontrado(actualizado);
      setMsg({ tipo: 'ok', texto: `Se actualizó el registro de ${config.nombre} con ID ${actualizado.id}.` });
    } catch (err) {
      setMsg({ tipo: 'error', texto: mensajeDe(err) });
    }
  }

  return (
    <>
      <SearchPanel config={config} onResultado={alBuscar} />
      {encontrado && (
        <form className="formulario" onSubmit={guardar}>
          <EntityForm campos={config.campos} valores={valores} modoEdicion
                      onChange={(k, v) => setValores({ ...valores, [k]: v })} />
          <div className="acciones"><button type="submit">Guardar cambios</button></div>
          <Mensaje msg={msg} />
        </form>
      )}
    </>
  );
}
