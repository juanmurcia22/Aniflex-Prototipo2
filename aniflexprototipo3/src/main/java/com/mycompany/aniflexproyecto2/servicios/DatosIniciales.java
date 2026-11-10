package com.mycompany.aniflexproyecto2.servicios;

import com.mycompany.aniflexproyecto2.model.Episodio;
import com.mycompany.aniflexproyecto2.model.Serie;
import com.mycompany.aniflexproyecto2.repository.EpisodioRepository;
import com.mycompany.aniflexproyecto2.repository.SerieRepository;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.boot.CommandLineRunner;
import org.springframework.stereotype.Component;

import java.time.LocalDateTime;

/** Al arrancar, si las colecciones están vacías, inserta datos de ejemplo para poder probar de inmediato. */
@Component
public class DatosIniciales implements CommandLineRunner {

    private final SerieRepository series;
    private final EpisodioRepository episodios;

    @Value("${aniflex.datos-iniciales:true}")
    private boolean activo;

    public DatosIniciales(SerieRepository series, EpisodioRepository episodios) {
        this.series = series;
        this.episodios = episodios;
    }

    @Override
    public void run(String... args) {
        if (!activo) {
            return;
        }
        try {
            // Los ids (ObjectId) los genera MongoDB; los episodios se enlazan a la serie por su titulo.
            if (series.count() == 0) {
                series.insert(new Serie("Attack on Titan", 4, 9.1, LocalDateTime.of(2013, 4, 7, 9, 0), false));
                series.insert(new Serie("Frieren", 1, 9.3, LocalDateTime.of(2023, 9, 29, 21, 0), true));
            }
            if (episodios.count() == 0) {
                series.findByTituloIgnoreCase("Attack on Titan").ifPresent(s ->
                        episodios.insert(new Episodio(s.getId(), 1, "A ti, dentro de 2000 años", 8.7,
                                LocalDateTime.of(2013, 4, 7, 9, 0), false)));
                series.findByTituloIgnoreCase("Frieren").ifPresent(s ->
                        episodios.insert(new Episodio(s.getId(), 1, "El final de la aventura", 9.0,
                                LocalDateTime.of(2023, 9, 29, 21, 0), true)));
            }
        } catch (RuntimeException e) {
            // Mongo apagado: el servidor sigue arriba y cada consulta devolverá un mensaje claro al cliente.
            System.err.println("[AVISO] No se pudieron cargar los datos iniciales (¿MongoDB está encendido?): " + e.getMessage());
        }
    }
}
