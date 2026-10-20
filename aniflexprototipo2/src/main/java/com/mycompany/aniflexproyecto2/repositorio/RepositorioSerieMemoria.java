package com.mycompany.aniflexproyecto2.repositorio;

import com.mycompany.aniflexproyecto2.model.Serie;

import java.time.LocalDateTime;

/** Patrón Singleton (instancia creada al cargar la clase, segura entre hilos). */
public final class RepositorioSerieMemoria extends RepositorioMemoria<Serie> implements IRepositorioSerie {

    private static final RepositorioSerieMemoria INSTANCIA = new RepositorioSerieMemoria();

    private RepositorioSerieMemoria() {
        // Datos de demostración para que la grilla no arranque vacía.
        datos.add(Serie.builder().id("S001").titulo("Attack on Titan").temporadas(4).calificacion(9.1)
                .fechaEstreno(LocalDateTime.of(2013, 4, 7, 9, 0)).enEmision(false).build());
        datos.add(Serie.builder().id("S002").titulo("Frieren").temporadas(1).calificacion(9.3)
                .fechaEstreno(LocalDateTime.of(2023, 9, 29, 21, 0)).enEmision(true).build());
    }

    public static RepositorioSerieMemoria getInstance() {
        return INSTANCIA;
    }
}
