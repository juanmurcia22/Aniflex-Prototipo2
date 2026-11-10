import type { ICrudController } from '../controllers/ICrudController';
import type { Params } from '../services/ICrudService';
import { paraInput } from '../utils/fecha';

export type TipoCampo = 'text' | 'int' | 'float' | 'datetime' | 'boolean' | 'serieRef';

export interface FieldDef {
  key: string;
  label: string;
  tipo: TipoCampo;
  soloLecturaAlEditar?: boolean;
  ocultoAlAdicionar?: boolean;   // p. ej. el id: lo genera MongoDB, no se pide al adicionar
}

export type Raw = Record<string, string | boolean>;

// Descriptor de entidad
export interface EntityConfig<T extends { id: string }> {
  nombre: string;
  campos: FieldDef[];
  camposBusqueda: FieldDef[];
  camposFiltro: FieldDef[];
  controller: ICrudController<T>;
  desdeFormularioNuevo(raw: Raw): Omit<T, 'id'>;   // para adicionar (sin id)
  desdeFormulario(raw: Raw): T;                    // para actualizar (con id)
}

export type AnyConfig = EntityConfig<any>;

export function valoresIniciales(campos: FieldDef[]): Raw {
  return Object.fromEntries(campos.map((c) => [c.key, c.tipo === 'boolean' ? false : '']));
}

export function aFormulario(campos: FieldDef[], entidad: object): Raw {
  const e = entidad as Record<string, unknown>;
  return Object.fromEntries(
    campos.map((c) => {
      const v = e[c.key];
      if (c.tipo === 'boolean') return [c.key, v === true];
      if (c.tipo === 'datetime') return [c.key, paraInput(String(v))];
      return [c.key, String(v ?? '')];
    }),
  );
}

export function comoParams(raw: Raw): Params {
  return Object.fromEntries(
    Object.entries(raw).filter((par): par is [string, string] => typeof par[1] === 'string'),
  );
}
