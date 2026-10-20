package com.mycompany.aniflexproyecto2.repositorio;

import com.mycompany.aniflexproyecto2.model.Episodio;

public interface IRepositorioEpisodio extends IRepositorio<Episodio> {
    /** Elimina todos los episodios de una serie y devuelve cuántos eliminó. */
    int eliminarDeSerie(String serieId);
}
