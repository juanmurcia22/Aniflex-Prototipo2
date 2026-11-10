package com.mycompany.aniflexproyecto2.repository;

import com.mycompany.aniflexproyecto2.model.Serie;
import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.stereotype.Repository;

import java.util.List;
import java.util.Optional;

/** Acceso a la coleccion "series" (maestro). Las consultas se derivan del nombre del metodo. */
@Repository
public interface SerieRepository extends MongoRepository<Serie, String> {

    Optional<Serie> findByTituloIgnoreCase(String titulo);

    List<Serie> findByTituloContainingIgnoreCase(String titulo);

    List<Serie> findByCalificacionGreaterThanEqual(double calificacion);

    List<Serie> findByTituloContainingIgnoreCaseAndCalificacionGreaterThanEqual(String titulo, double calificacion);
}
