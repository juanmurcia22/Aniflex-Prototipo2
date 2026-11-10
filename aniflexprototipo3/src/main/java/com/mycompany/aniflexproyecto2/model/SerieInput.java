package com.mycompany.aniflexproyecto2.model;

/**
 * Datos que llegan del cliente (coincide con "input SerieInput" del schema).
 * El id es opcional: al ADICIONAR se ignora (lo genera MongoDB como ObjectId); al ACTUALIZAR es obligatorio.
 */
public record SerieInput(String id, String titulo, int temporadas, double calificacion,
                         String fechaEstreno, boolean enEmision) {

    /** Para ADICIONAR: serie sin id, MongoDB le asigna el ObjectId al insertar. */
    public Serie aSerieNueva() {
        return new Serie(titulo, temporadas, calificacion,
                Validaciones.leerFecha(fechaEstreno, "Fecha de estreno"), enEmision);
    }

    /** Para ACTUALIZAR: serie con el id (ObjectId en texto) de la serie ya existente. */
    public Serie aSerie() {
        return new Serie(id, titulo, temporadas, calificacion,
                Validaciones.leerFecha(fechaEstreno, "Fecha de estreno"), enEmision);
    }
}
