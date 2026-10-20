package com.mycompany.aniflexproyecto2.controlador;

import com.mycompany.aniflexproyecto2.model.Serie;

/** Datos que llegan del cliente (coincide con "input SerieInput" del schema). */
public record EntradaSerie(String id, String titulo, int temporadas, double calificacion,
                           String fechaEstreno, boolean enEmision) {

    public Serie aSerie() {
        return Serie.builder()
                .id(id)
                .titulo(titulo)
                .temporadas(temporadas)
                .calificacion(calificacion)
                .fechaEstreno(FechasIso.leer(fechaEstreno, "Fecha de estreno"))
                .enEmision(enEmision)
                .build();
    }
}
