package com.mycompany.aniflexproyecto2.repository;

import com.mycompany.aniflexproyecto2.model.Episodio;
import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.stereotype.Repository;

import java.util.List;
import java.util.Optional;

/** Acceso a la coleccion "episodios" (detalle). Cada documento guarda el id de su serie en "serieId". */
@Repository
public interface EpisodioRepository extends MongoRepository<Episodio, String> {

    Optional<Episodio> findBySerieIdAndNoEpisodio(String serieId, int noEpisodio);

    List<Episodio> findBySerieId(String serieId);

    List<Episodio> findByTituloContainingIgnoreCase(String titulo);

    List<Episodio> findBySerieIdAndTituloContainingIgnoreCase(String serieId, String titulo);

    void deleteBySerieId(String serieId);
}
