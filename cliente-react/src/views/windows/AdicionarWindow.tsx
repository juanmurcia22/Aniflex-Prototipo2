import { type FormEvent, useState } from 'react';
import { type EntityConfig, type Raw, valoresIniciales } from '../../entities/EntityConfig';
import { mensajeDe } from '../../utils/parseo';
import { EntityForm } from '../components/EntityForm';
import { type Msg, Mensaje } from '../components/Mensaje';

/** Caso de uso: ADICIONAR (una sola funcionalidad). */
export function AdicionarWindow<T extends { id: string }>({ config }: { config: EntityConfig<T> }) {
  const [valores, setValores] = useState<Raw>(() => valoresIniciales(config.campos));
  const [msg, setMsg] = useState<Msg | null>(null);

  async function guardar(e: FormEvent) {
    e.preventDefault();
    try {
      const nuevo = config.desdeFormulario(valores);        // Builder + validaciones
      await config.controller.adicionar(nuevo);             // Controller -> Service -> GraphQL
      setMsg({ tipo: 'ok', texto: `Se adicionó el registro de ${config.nombre} con ID ${nuevo.id}.` });
      setValores(valoresIniciales(config.campos));
    } catch (err) {
      setMsg({ tipo: 'error', texto: mensajeDe(err) });
    }
  }

  return (
    <form className="formulario" onSubmit={guardar}>
      <EntityForm campos={config.campos} valores={valores}
                  onChange={(k, v) => setValores({ ...valores, [k]: v })} />
      <div className="acciones"><button type="submit">Guardar</button></div>
      <Mensaje msg={msg} />
    </form>
  );
}
