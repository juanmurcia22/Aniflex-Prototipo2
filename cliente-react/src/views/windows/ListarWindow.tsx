import { useCallback, useEffect, useState } from 'react';
import { type EntityConfig, type Raw, comoParams } from '../../entities/EntityConfig';
import type { Params } from '../../services/ICrudService';
import { mensajeDe } from '../../utils/parseo';
import { CampoInput } from '../components/CampoInput';
import { DataGrid } from '../components/DataGrid';
import { type Msg, Mensaje } from '../components/Mensaje';

/**
 * Caso de uso: LISTAR (grilla + filtros aplicados en el SERVIDOR).
 * Es el OBSERVADOR: se suscribe al controlador y se recarga sola cuando otra ventana
 * adiciona, actualiza o elimina un registro.
 */
export function ListarWindow<T extends { id: string }>({ config }: { config: EntityConfig<T> }) {
  const [valores, setValores] = useState<Raw>({});
  const [aplicado, setAplicado] = useState<Params>({});
  const [filas, setFilas] = useState<T[]>([]);
  const [msg, setMsg] = useState<Msg | null>(null);

  const cargar = useCallback(async () => {
    try {
      setFilas(await config.controller.listar(aplicado));
      setMsg(null);
    } catch (err) {
      setMsg({ tipo: 'error', texto: mensajeDe(err) });
    }
  }, [config, aplicado]);

  useEffect(() => {
    void cargar();
    return config.controller.subscribe(() => { void cargar(); });   // Observer
  }, [config, cargar]);

  return (
    <>
      <form className="filtros" onSubmit={(e) => { e.preventDefault(); setAplicado(comoParams(valores)); }}>
        {config.camposFiltro.map((c) => (
          <CampoInput key={c.key} campo={c} valor={valores[c.key] ?? ''}
                      onChange={(v) => setValores({ ...valores, [c.key]: v })} />
        ))}
        <button type="submit">Filtrar</button>
        <button type="button" className="secundario"
                onClick={() => { setValores({}); setAplicado({}); }}>Limpiar</button>
      </form>
      <Mensaje msg={msg} />
      <DataGrid campos={config.campos} filas={filas} />
    </>
  );
}
