import type { Serie } from '../models/Serie';
import { SerieService } from '../services/SerieService';
import { CrudController } from './CrudController';

// Singleton
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
