package com.mycompany.aniflexproyecto2.model;

/** Datos que llegan del cliente (coincide con "input SerieInput" del schema). */
public record SerieInput(String id, String titulo, int temporadas, double calificacion,
                         String fechaEstreno, boolean enEmision) {

    public Serie aSerie() {
        return new Serie(id, titulo, temporadas, calificacion,
                Validaciones.leerFecha(fechaEstreno, "Fecha de estreno"), enEmision);
    }
}
