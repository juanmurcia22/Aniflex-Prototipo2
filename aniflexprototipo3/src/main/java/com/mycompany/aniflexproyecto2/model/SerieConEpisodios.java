package com.mycompany.aniflexproyecto2.model;

import java.util.List;

/**
 * Resultado de la consulta personalizada maestro-detalle: TODOS los datos de la serie (maestro)
 * y dos atributos de cada uno de sus episodios (detalle). Solo se usa para responder, no se guarda.
 * La fecha viaja como texto ISO-8601.
 */
public record SerieConEpisodios(String id, String titulo, int temporadas, double calificacion,
                                String fechaEstreno, boolean enEmision, List<EpisodioResumen> episodios) {
}
