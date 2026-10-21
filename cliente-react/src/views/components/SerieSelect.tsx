import { useEffect, useState } from 'react';
import { SerieController } from '../../controllers/SerieController';
import type { Serie } from '../../models/Serie';

interface Props {
  valor: string;
  onChange: (v: string) => void;
  disabled?: boolean;
}

export function SerieSelect({ valor, onChange, disabled }: Props) {
  const [series, setSeries] = useState<Serie[]>([]);

  useEffect(() => {
    const controller = SerieController.getInstance();
    const cargar = () => { controller.listar({}).then(setSeries).catch(() => setSeries([])); };
    cargar();
    return controller.subscribe(cargar);
  }, []);

  return (
    <select value={valor} disabled={disabled} onChange={(e) => onChange(e.target.value)}>
      <option value="">— seleccione —</option>
      {series.map((s) => (
        <option key={s.id} value={s.id}>{s.id} · {s.titulo}</option>
      ))}
    </select>
  );
}
