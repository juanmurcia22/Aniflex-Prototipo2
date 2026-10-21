export type Params = Record<string, string>;

export interface ICrudService<T> {
  adicionar(entidad: T): Promise<T>;
  buscar(params: Params): Promise<T | null>;
  actualizar(entidad: T): Promise<T>;
  eliminar(id: string): Promise<boolean>;
  listar(filtro: Params): Promise<T[]>;
}
