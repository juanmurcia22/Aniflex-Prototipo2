import type { FieldDef } from '../../entities/EntityConfig';
import { formatear } from './formato';

export function DataGrid({ campos, filas }: { campos: FieldDef[]; filas: object[] }) {
  return (
    <div className="grilla">
      <table>
        <thead>
          <tr>{campos.map((c) => <th key={c.key}>{c.label}</th>)}</tr>
        </thead>
        <tbody>
          {filas.length === 0 && (
            <tr><td colSpan={campos.length} className="vacio">No hay registros para mostrar.</td></tr>
          )}
          {filas.map((f, i) => (
            <tr key={i}>
              {campos.map((c) => (
                <td key={c.key}>{formatear(c, (f as Record<string, unknown>)[c.key])}</td>
              ))}
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
