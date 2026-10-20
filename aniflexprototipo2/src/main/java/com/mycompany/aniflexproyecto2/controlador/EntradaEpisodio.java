package com.mycompany.aniflexproyecto2.controlador;

import com.mycompany.aniflexproyecto2.model.Episodio;

/** Datos que llegan del cliente (coincide con "input EpisodioInput" del schema). */
public record EntradaEpisodio(String id, String serieId, int noEpisodio, String titulo,
                              double calificacion, String fechaEmision, boolean esEspecial) {

    public Episodio aEpisodio() {
        return Episodio.builder()
                .id(id)
                .serieId(serieId)
                .noEpisodio(noEpisodio)
                .titulo(titulo)
                .calificacion(calificacion)
                .fechaEmision(FechasIso.leer(fechaEmision, "Fecha de emisión"))
                .esEspecial(esEspecial)
                .build();
    }
}
