package com.mycompany.aniflexproyecto2.servicios;

import com.mycompany.aniflexproyecto2.model.Episodio;
import com.mycompany.aniflexproyecto2.repository.EpisodioRepository;
import com.mycompany.aniflexproyecto2.repository.SerieRepository;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

/**
 * Lógica del DETALLE (Episodio). Los datos viven en la colección MongoDB "episodios".
 * Un episodio siempre pertenece a una serie existente y su nº no se repite dentro de la serie.
 */
@Service
public class ServicioEpisodio {

    private final EpisodioRepository episodios;
    private final SerieRepository series;
    private final PublicadorCambios publicador = PublicadorCambios.getInstance();

    public ServicioEpisodio(EpisodioRepository episodios, SerieRepository series) {
        this.episodios = episodios;
        this.series = series;
    }

    /** El id (ObjectId) lo genera MongoDB al insertar, por eso ya no hay validación de ID duplicado. */
    public Episodio adicionar(Episodio episodio) {
        validarRelacion(episodio);
        Episodio guardado = episodios.insert(episodio);
        publicador.notificar("Episodio", "ADICIONADO", guardado.getId());
        return guardado;
    }

    /** Consulta individual por serie + número de episodio. */
    public Optional<Episodio> buscar(String serieId, int noEpisodio) {
        return episodios.findBySerieIdAndNoEpisodio(serieId.trim(), noEpisodio);
    }

    public Episodio actualizar(Episodio episodio) {
        if (!episodios.existsById(episodio.getId())) {
            throw new IllegalArgumentException("No existe un episodio con el ID " + episodio.getId());
        }
        validarRelacion(episodio);
        Episodio guardado = episodios.save(episodio);
        publicador.notificar("Episodio", "ACTUALIZADO", guardado.getId());
        return guardado;
    }

    public boolean eliminar(String id) {
        String limpio = id.trim();
        if (!episodios.existsById(limpio)) {
            return false;
        }
        episodios.deleteById(limpio);
        publicador.notificar("Episodio", "ELIMINADO", limpio);
        return true;
    }

    /** Listado con filtros opcionales: serie y título contiene. */
    public List<Episodio> listar(String serieId, String titulo) {
        boolean sinSerie = serieId == null || serieId.isBlank();
        boolean sinTitulo = titulo == null || titulo.isBlank();
        if (sinSerie && sinTitulo) {
            return episodios.findAll();
        }
        if (sinTitulo) {
            return episodios.findBySerieId(serieId.trim());
        }
        if (sinSerie) {
            return episodios.findByTituloContainingIgnoreCase(titulo.trim());
        }
        return episodios.findBySerieIdAndTituloContainingIgnoreCase(serieId.trim(), titulo.trim());
    }

    /** Reglas maestro-detalle: la serie existe y el nº de episodio no se repite dentro de ella. */
    private void validarRelacion(Episodio e) {
        if (!series.existsById(e.getSerieId())) {
            throw new IllegalArgumentException("No existe la serie " + e.getSerieId() + ".");
        }
        boolean repetido = episodios.findBySerieIdAndNoEpisodio(e.getSerieId(), e.getNoEpisodio())
                .filter(x -> !x.getId().equals(e.getId()))
                .isPresent();
        if (repetido) {
            throw new IllegalArgumentException("La serie " + e.getSerieId() + " ya tiene el episodio " + e.getNoEpisodio() + ".");
        }
    }
}
