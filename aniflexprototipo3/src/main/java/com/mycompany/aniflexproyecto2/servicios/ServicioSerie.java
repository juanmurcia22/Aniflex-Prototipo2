package com.mycompany.aniflexproyecto2.servicios;

import com.mycompany.aniflexproyecto2.model.EpisodioResumen;
import com.mycompany.aniflexproyecto2.model.Serie;
import com.mycompany.aniflexproyecto2.model.SerieConEpisodios;
import com.mycompany.aniflexproyecto2.repository.EpisodioRepository;
import com.mycompany.aniflexproyecto2.repository.SerieRepository;
import org.springframework.stereotype.Service;

import java.time.format.DateTimeFormatter;
import java.util.List;
import java.util.Optional;

/**
 * Lógica del MAESTRO (Serie). Los datos viven en la colección MongoDB "series"
 * (ya no hay listas en memoria); el servicio solo valida reglas y delega en el repositorio.
 */
@Service
public class ServicioSerie {

    private final SerieRepository series;
    private final EpisodioRepository episodios;
    private final PublicadorCambios publicador = PublicadorCambios.getInstance();

    public ServicioSerie(SerieRepository series, EpisodioRepository episodios) {
        this.series = series;
        this.episodios = episodios;
    }

    /** El id (ObjectId) lo genera MongoDB al insertar, por eso ya no hay validación de ID duplicado. */
    public Serie adicionar(Serie serie) {
        Serie guardada = series.insert(serie);
        publicador.notificar("Serie", "ADICIONADA", guardada.getId());
        return guardada;
    }

    /** Consulta individual por uno o dos parámetros (si llegan ambos, deben coincidir ambos). */
    public Optional<Serie> buscar(String id, String titulo) {
        boolean sinId = id == null || id.isBlank();
        boolean sinTitulo = titulo == null || titulo.isBlank();
        if (sinId && sinTitulo) {
            throw new IllegalArgumentException("Indique al menos un parámetro de búsqueda.");
        }
        if (sinTitulo) {
            return series.findById(id.trim());
        }
        Optional<Serie> porTitulo = series.findByTituloIgnoreCase(titulo.trim());
        if (sinId) {
            return porTitulo;
        }
        return porTitulo.filter(s -> s.getId().equals(id.trim()));
    }

    public Optional<Serie> buscarPorId(String id) {
        return id == null ? Optional.empty() : series.findById(id.trim());
    }

    public Serie actualizar(Serie serie) {
        if (!series.existsById(serie.getId())) {
            throw new IllegalArgumentException("No existe una serie con el ID " + serie.getId());
        }
        Serie guardada = series.save(serie);
        publicador.notificar("Serie", "ACTUALIZADA", guardada.getId());
        return guardada;
    }

    /** Elimina la serie y, en cascada, sus episodios (no deben quedar huérfanos). */
    public boolean eliminar(String id) {
        String limpio = id.trim();
        if (!series.existsById(limpio)) {
            return false;
        }
        episodios.deleteBySerieId(limpio);
        series.deleteById(limpio);
        publicador.notificar("Serie", "ELIMINADA", limpio);
        return true;
    }

    /** Listado con filtros opcionales: título contiene y calificación mínima. */
    public List<Serie> listar(String titulo, Double calificacionMinima) {
        boolean sinTitulo = titulo == null || titulo.isBlank();
        if (sinTitulo && calificacionMinima == null) {
            return series.findAll();
        }
        if (calificacionMinima == null) {
            return series.findByTituloContainingIgnoreCase(titulo.trim());
        }
        if (sinTitulo) {
            return series.findByCalificacionGreaterThanEqual(calificacionMinima);
        }
        return series.findByTituloContainingIgnoreCaseAndCalificacionGreaterThanEqual(titulo.trim(), calificacionMinima);
    }

    /**
     * Consulta personalizada maestro-detalle: datos completos de la serie (colección A)
     * con el nº y título de cada uno de sus episodios (colección B). Filtro opcional por título.
     */
    public List<SerieConEpisodios> listarConEpisodios(String titulo) {
        return listar(titulo, null).stream()
                .map(s -> new SerieConEpisodios(
                        s.getId(), s.getTitulo(), s.getTemporadas(), s.getCalificacion(),
                        s.getFechaEstreno().format(DateTimeFormatter.ISO_LOCAL_DATE_TIME), s.isEnEmision(),
                        episodios.findBySerieId(s.getId()).stream()
                                .map(e -> new EpisodioResumen(e.getNoEpisodio(), e.getTitulo()))
                                .toList()))
                .toList();
    }
}
