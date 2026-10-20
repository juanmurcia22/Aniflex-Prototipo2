import { Observable } from '../patterns/Observable';
import type { ICrudService, Params } from '../services/ICrudService';
import type { ICrudController } from './ICrudController';

export abstract class CrudController<T> implements ICrudController<T> {
  private readonly observable = new Observable();

  protected constructor(private readonly servicio: ICrudService<T>) { }

  subscribe(listener: () => void): () => void {
    return this.observable.subscribe(listener);
  }

  async adicionar(entidad: T): Promise<T> {
    const r = await this.servicio.adicionar(entidad);
    this.observable.notify();
    return r;
  }

  buscar(params: Params): Promise<T | null> {
    return this.servicio.buscar(params);
  }

  async actualizar(entidad: T): Promise<T> {
    const r = await this.servicio.actualizar(entidad);
    this.observable.notify();
    return r;
  }

  async eliminar(id: string): Promise<boolean> {
    const r = await this.servicio.eliminar(id);
    this.observable.notify();
    return r;
  }

  listar(filtro: Params): Promise<T[]> {
    return this.servicio.listar(filtro);
  }
}
