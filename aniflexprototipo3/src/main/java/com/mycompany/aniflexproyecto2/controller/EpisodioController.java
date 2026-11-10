package com.mycompany.aniflexproyecto2.controller;

import com.mycompany.aniflexproyecto2.model.Episodio;
import com.mycompany.aniflexproyecto2.model.EpisodioInput;
import com.mycompany.aniflexproyecto2.model.Serie;
import com.mycompany.aniflexproyecto2.servicios.ServicioEpisodio;
import com.mycompany.aniflexproyecto2.servicios.ServicioSerie;
import org.springframework.graphql.data.method.annotation.Argument;
import org.springframework.graphql.data.method.annotation.MutationMapping;
import org.springframework.graphql.data.method.annotation.QueryMapping;
import org.springframework.graphql.data.method.annotation.SchemaMapping;
import org.springframework.stereotype.Controller;

import java.time.format.DateTimeFormatter;
import java.util.List;

/** CONTROLLER (MVC) de Episodio. */
@Controller
public class EpisodioController {

    private final ServicioEpisodio servicio;
    private final ServicioSerie servicioSerie;

    public EpisodioController(ServicioEpisodio servicio, ServicioSerie servicioSerie) {
        this.servicio = servicio;
        this.servicioSerie = servicioSerie;
    }

    @QueryMapping
    public Episodio buscarEpisodio(@Argument String serieId, @Argument int noEpisodio) {
        return servicio.buscar(serieId, noEpisodio).orElse(null);
    }

    @QueryMapping
    public List<Episodio> listarEpisodios(@Argument String serieId, @Argument String titulo) {
        return servicio.listar(serieId, titulo);
    }

    @MutationMapping
    public Episodio adicionarEpisodio(@Argument EpisodioInput input) {
        return servicio.adicionar(input.aEpisodioNuevo());
    }

    @MutationMapping
    public Episodio actualizarEpisodio(@Argument EpisodioInput input) {
        return servicio.actualizar(input.aEpisodio());
    }

    @MutationMapping
    public boolean eliminarEpisodio(@Argument String id) {
        return servicio.eliminar(id);
    }

    @SchemaMapping(typeName = "Episodio", field = "fechaEmision")
    public String fechaEmision(Episodio episodio) {
        return episodio.getFechaEmision().format(DateTimeFormatter.ISO_LOCAL_DATE_TIME);
    }

    /** Atributo de la serie (colección A) mostrado junto a cada episodio (colección B). */
    @SchemaMapping(typeName = "Episodio", field = "serieTitulo")
    public String serieTitulo(Episodio episodio) {
        return servicioSerie.buscarPorId(episodio.getSerieId()).map(Serie::getTitulo).orElse(null);
    }

    /** Segundo atributo de la serie mostrado junto a cada episodio. */
    @SchemaMapping(typeName = "Episodio", field = "serieCalificacion")
    public Double serieCalificacion(Episodio episodio) {
        return servicioSerie.buscarPorId(episodio.getSerieId()).map(Serie::getCalificacion).orElse(null);
    }
}
