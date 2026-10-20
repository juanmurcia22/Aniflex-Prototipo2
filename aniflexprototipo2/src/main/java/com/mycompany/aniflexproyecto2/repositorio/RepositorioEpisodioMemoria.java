package com.mycompany.aniflexproyecto2.repositorio;

import com.mycompany.aniflexproyecto2.model.Episodio;

import java.time.LocalDateTime;

/** Patrón Singleton. */
public final class RepositorioEpisodioMemoria extends RepositorioMemoria<Episodio> implements IRepositorioEpisodio {

    private static final RepositorioEpisodioMemoria INSTANCIA = new RepositorioEpisodioMemoria();

    private RepositorioEpisodioMemoria() {
        datos.add(Episodio.builder().id("E001").serieId("S001").noEpisodio(1).titulo("A ti, dentro de 2000 años")
                .calificacion(8.7).fechaEmision(LocalDateTime.of(2013, 4, 7, 9, 0)).esEspecial(false).build());
        datos.add(Episodio.builder().id("E002").serieId("S002").noEpisodio(1).titulo("El final de la aventura")
                .calificacion(9.0).fechaEmision(LocalDateTime.of(2023, 9, 29, 21, 0)).esEspecial(true).build());
    }

    public static RepositorioEpisodioMemoria getInstance() {
        return INSTANCIA;
    }

    @Override
    public int eliminarDeSerie(String serieId) {
        int antes = datos.size();
        datos.removeIf(e -> e.getSerieId().equals(serieId));
        return antes - datos.size();
    }
}
