import type { FieldDef } from '../../entities/EntityConfig';
import { formatear } from './formato';

/** Muestra TODOS los atributos de un objeto (exigido antes de actualizar o eliminar). */
export function EntityDetail({ campos, entidad }: { campos: FieldDef[]; entidad: object }) {
  const e = entidad as Record<string, unknown>;
  return (
    <dl className="detalle">
      {campos.map((c) => (
        <div key={c.key}>
          <dt>{c.label}</dt>
          <dd>{formatear(c, e[c.key])}</dd>
        </div>
      ))}
    </dl>
  );
}
