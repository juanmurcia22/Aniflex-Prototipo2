package com.mycompany.aniflexproyecto2.servicio;

import com.mycompany.aniflexproyecto2.model.Episodio;

import java.util.List;
import java.util.Optional;

public interface IServicioEpisodio {
    Episodio adicionar(Episodio episodio);
    Optional<Episodio> buscar(String serieId, int noEpisodio);
    Episodio actualizar(Episodio episodio);
    boolean eliminar(String id);
    /** Listado con filtros opcionales (serie, título contiene). */
    List<Episodio> listar(String serieId, String titulo);
    /** Usado por ServicioSerie para el borrado en cascada. */
    int eliminarDeSerie(String serieId);
}
