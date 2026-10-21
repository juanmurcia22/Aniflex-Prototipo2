import type { Episodio } from '../models/Episodio';
import { EpisodioService } from '../services/EpisodioService';
import { CrudController } from './CrudController';

// Singleton
export class EpisodioController extends CrudController<Episodio> {
  private static instancia: EpisodioController;

  private constructor() {
    super(new EpisodioService());
  }

  static getInstance(): EpisodioController {
    EpisodioController.instancia ??= new EpisodioController();
    return EpisodioController.instancia;
  }
}
