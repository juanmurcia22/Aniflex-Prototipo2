import type { Params } from '../services/ICrudService';

/** Lo único que las vistas necesitan saber de un controlador (segregación de interfaces). */
export interface ICrudController<T> {
  adicionar(entidad: T): Promise<T>;
  buscar(params: Params): Promise<T | null>;
  actualizar(entidad: T): Promise<T>;
  eliminar(id: string): Promise<boolean>;
  listar(filtro: Params): Promise<T[]>;
  /** Observer: avisa cuando los datos cambian. Devuelve la función para desuscribirse. */
  subscribe(listener: () => void): () => void;
}
