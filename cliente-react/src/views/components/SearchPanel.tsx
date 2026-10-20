import { type FormEvent, useState } from 'react';
import { type EntityConfig, type Raw, comoParams } from '../../entities/EntityConfig';
import { mensajeDe } from '../../utils/parseo';
import { CampoInput } from './CampoInput';
import { type Msg, Mensaje } from './Mensaje';

interface Props<T extends { id: string }> {
  config: EntityConfig<T>;
  onResultado: (encontrado: T | null) => void;
}

/** Búsqueda individual reutilizada por Buscar, Actualizar y Eliminar ("previa búsqueda del objeto"). */
export function SearchPanel<T extends { id: string }>({ config, onResultado }: Props<T>) {
  const [params, setParams] = useState<Raw>({});
  const [msg, setMsg] = useState<Msg | null>(null);

  async function buscar(e: FormEvent) {
    e.preventDefault();
    try {
      const r = await config.controller.buscar(comoParams(params));
      onResultado(r);
      setMsg(r ? null : { tipo: 'error', texto: `No se encontró ningún registro de ${config.nombre} con esos datos.` });
    } catch (err) {
      onResultado(null);
      setMsg({ tipo: 'error', texto: mensajeDe(err) });
    }
  }

  return (
    <form className="formulario" onSubmit={buscar}>
      {config.camposBusqueda.map((c) => (
        <CampoInput key={c.key} campo={c} valor={params[c.key] ?? ''}
                    onChange={(v) => setParams({ ...params, [c.key]: v })} />
      ))}
      <div className="acciones"><button type="submit">Buscar</button></div>
      <Mensaje msg={msg} />
    </form>
  );
}
