package com.mycompany.aniflexproyecto2.controlador;

import com.mycompany.aniflexproyecto2.model.Episodio;
import com.mycompany.aniflexproyecto2.servicio.IServicioEpisodio;
import org.springframework.graphql.data.method.annotation.Argument;
import org.springframework.graphql.data.method.annotation.MutationMapping;
import org.springframework.graphql.data.method.annotation.QueryMapping;
import org.springframework.graphql.data.method.annotation.SchemaMapping;
import org.springframework.stereotype.Controller;

import java.util.List;

/** CONTROLLER (MVC) de Episodio. */
@Controller
public class EpisodioController {

    private final IServicioEpisodio servicio;

    public EpisodioController(IServicioEpisodio servicio) {
        this.servicio = servicio;
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
    public Episodio adicionarEpisodio(@Argument EntradaEpisodio input) {
        return servicio.adicionar(input.aEpisodio());
    }

    @MutationMapping
    public Episodio actualizarEpisodio(@Argument EntradaEpisodio input) {
        return servicio.actualizar(input.aEpisodio());
    }

    @MutationMapping
    public boolean eliminarEpisodio(@Argument String id) {
        return servicio.eliminar(id);
    }

    @SchemaMapping(typeName = "Episodio", field = "fechaEmision")
    public String fechaEmision(Episodio episodio) {
        return FechasIso.escribir(episodio.getFechaEmision());
    }
}
