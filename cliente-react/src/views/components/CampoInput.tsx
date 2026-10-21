import type { FieldDef } from '../../entities/EntityConfig';
import { SerieSelect } from './SerieSelect';

interface Props {
  campo: FieldDef;
  valor: string | boolean;
  onChange: (v: string | boolean) => void;
  soloLectura?: boolean;
}

export function CampoInput({ campo, valor, onChange, soloLectura }: Props) {
  if (campo.tipo === 'boolean') {
    return (
      <label className="campo check">
        <input type="checkbox" checked={valor === true} disabled={soloLectura}
               onChange={(e) => onChange(e.target.checked)} />
        {campo.label}
      </label>
    );
  }
  if (campo.tipo === 'serieRef') {
    return (
      <label className="campo">
        <span>{campo.label}</span>
        <SerieSelect valor={String(valor)} onChange={onChange} disabled={soloLectura} />
      </label>
    );
  }
  const type = campo.tipo === 'datetime' ? 'datetime-local' : campo.tipo === 'text' ? 'text' : 'number';
  return (
    <label className="campo">
      <span>{campo.label}</span>
      <input type={type} step={campo.tipo === 'float' ? 'any' : campo.tipo === 'int' ? 1 : undefined}
             value={String(valor)} readOnly={soloLectura}
             onChange={(e) => onChange(e.target.value)} />
    </label>
  );
}
