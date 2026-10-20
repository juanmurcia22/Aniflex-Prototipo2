/** Parámetros de búsqueda/filtro tal como salen del formulario (texto). */
export type Params = Record<string, string>;

/** Abstracción (DIP): los controladores dependen de esta interfaz, no de GraphQL. */
export interface ICrudService<T> {
  adicionar(entidad: T): Promise<T>;
  buscar(params: Params): Promise<T | null>;
  actualizar(entidad: T): Promise<T>;
  eliminar(id: string): Promise<boolean>;
  listar(filtro: Params): Promise<T[]>;
}
