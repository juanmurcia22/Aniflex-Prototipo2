import type { FieldDef, Raw } from '../../entities/EntityConfig';
import { CampoInput } from './CampoInput';

interface Props {
  campos: FieldDef[];
  valores: Raw;
  onChange: (key: string, v: string | boolean) => void;
  modoEdicion?: boolean;
}

export function EntityForm({ campos, valores, onChange, modoEdicion = false }: Props) {
  return (
    <>
      {campos.map((c) => (
        <CampoInput key={c.key} campo={c} valor={valores[c.key] ?? ''}
                    onChange={(v) => onChange(c.key, v)}
                    soloLectura={modoEdicion && c.soloLecturaAlEditar} />
      ))}
    </>
  );
}
