import type { FieldDef } from '../../entities/EntityConfig';
import { paraMostrar } from '../../utils/fecha';

export function formatear(campo: FieldDef, valor: unknown): string {
  if (campo.tipo === 'boolean') return valor === true ? 'Sí' : 'No';
  if (campo.tipo === 'datetime') return paraMostrar(String(valor));
  return String(valor ?? '');
}
