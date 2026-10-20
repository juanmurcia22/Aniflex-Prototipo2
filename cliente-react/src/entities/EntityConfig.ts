import type { ICrudController } from '../controllers/ICrudController';
import type { Params } from '../services/ICrudService';
import { paraInput } from '../utils/fecha';

export type TipoCampo = 'text' | 'int' | 'float' | 'datetime' | 'boolean' | 'serieRef';

export interface FieldDef {
  key: string;
  label: string;
  tipo: TipoCampo;
  /** En la ventana Actualizar el campo se muestra pero no se puede cambiar (llaves). */
  soloLecturaAlEditar?: boolean;
}

/** Valores crudos de un formulario. */
export type Raw = Record<string, string | boolean>;

/**
 * Descriptor de una entidad: dice qué campos tiene, cómo buscarla/filtrarla y cómo armarla.
 * Las 5 ventanas genéricas se alimentan de este descriptor (principio abierto/cerrado:
 * una entidad nueva = un descriptor nuevo, sin tocar las ventanas).
 */
export interface EntityConfig<T extends { id: string }> {
  nombre: string;
  campos: FieldDef[];
  camposBusqueda: FieldDef[];
  camposFiltro: FieldDef[];
  controller: ICrudController<T>;
  desdeFormulario(raw: Raw): T;
}

// eslint-disable-next-line @typescript-eslint/no-explicit-any
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
