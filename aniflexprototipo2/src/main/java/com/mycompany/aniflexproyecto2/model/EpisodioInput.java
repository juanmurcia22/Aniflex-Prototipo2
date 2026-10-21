package com.mycompany.aniflexproyecto2.model;

/** Datos que llegan del cliente (coincide con "input EpisodioInput" del schema). */
public record EpisodioInput(String id, String serieId, int noEpisodio, String titulo,
                            double calificacion, String fechaEmision, boolean esEspecial) {

    public Episodio aEpisodio() {
        return new Episodio(id, serieId, noEpisodio, titulo, calificacion,
                Validaciones.leerFecha(fechaEmision, "Fecha de emisión"), esEspecial);
    }
}
