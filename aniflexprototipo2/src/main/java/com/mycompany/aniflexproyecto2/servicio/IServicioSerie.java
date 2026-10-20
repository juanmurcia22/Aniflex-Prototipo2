package com.mycompany.aniflexproyecto2.servicio;

import com.mycompany.aniflexproyecto2.model.Serie;

import java.util.List;
import java.util.Optional;

public interface IServicioSerie {
    Serie adicionar(Serie serie);
    /** Consulta individual por uno o dos parámetros (si llegan ambos, deben coincidir ambos). */
    Optional<Serie> buscar(String id, String titulo);
    Serie actualizar(Serie serie);
    /** Elimina la serie y, en cascada, sus episodios. */
    boolean eliminar(String id);
    /** Listado con filtros opcionales (título contiene, calificación mínima). */
    List<Serie> listar(String titulo, Double calificacionMinima);
}
