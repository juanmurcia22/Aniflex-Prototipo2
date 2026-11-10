package com.mycompany.aniflexproyecto2.model;

/**
 * Datos que llegan del cliente (coincide con "input EpisodioInput" del schema).
 * El id es opcional: al ADICIONAR se ignora (lo genera MongoDB como ObjectId); al ACTUALIZAR es obligatorio.
 */
public record EpisodioInput(String id, String serieId, int noEpisodio, String titulo,
                            double calificacion, String fechaEmision, boolean esEspecial) {

    /** Para ADICIONAR: episodio sin id, MongoDB le asigna el ObjectId al insertar. */
    public Episodio aEpisodioNuevo() {
        return new Episodio(serieId, noEpisodio, titulo, calificacion,
                Validaciones.leerFecha(fechaEmision, "Fecha de emisión"), esEspecial);
    }

    /** Para ACTUALIZAR: episodio con el id (ObjectId en texto) del episodio ya existente. */
    public Episodio aEpisodio() {
        return new Episodio(id, serieId, noEpisodio, titulo, calificacion,
                Validaciones.leerFecha(fechaEmision, "Fecha de emisión"), esEspecial);
    }
}
