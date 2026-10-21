import type { Params } from '../services/ICrudService';

export interface ICrudController<T> {
  adicionar(entidad: T): Promise<T>;
  buscar(params: Params): Promise<T | null>;
  actualizar(entidad: T): Promise<T>;
  eliminar(id: string): Promise<boolean>;
  listar(filtro: Params): Promise<T[]>;
  subscribe(listener: () => void): () => void;
}
