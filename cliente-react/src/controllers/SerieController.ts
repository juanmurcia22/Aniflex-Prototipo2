import type { Serie } from '../models/Serie';
import { SerieService } from '../services/SerieService';
import { CrudController } from './CrudController';

/** Patrón Singleton: todas las ventanas comparten el mismo controlador (y sus observadores). */
export class SerieController extends CrudController<Serie> {
  private static instancia: SerieController;

  private constructor() {
    super(new SerieService());
  }

  static getInstance(): SerieController {
    SerieController.instancia ??= new SerieController();
    return SerieController.instancia;
  }
}
