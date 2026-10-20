package com.mycompany.aniflexproyecto2.controlador;

import com.mycompany.aniflexproyecto2.model.Serie;
import com.mycompany.aniflexproyecto2.servicio.IServicioSerie;
import org.springframework.graphql.data.method.annotation.Argument;
import org.springframework.graphql.data.method.annotation.MutationMapping;
import org.springframework.graphql.data.method.annotation.QueryMapping;
import org.springframework.graphql.data.method.annotation.SchemaMapping;
import org.springframework.stereotype.Controller;

import java.util.List;

/**
 * CONTROLLER (MVC) de Serie. Cada método se enlaza por NOMBRE con un campo de Query/Mutation del schema.
 * No tiene lógica de negocio: recibe, delega en el servicio y devuelve.
 */
@Controller
public class SerieController {

    private final IServicioSerie servicio;

    public SerieController(IServicioSerie servicio) {
        this.servicio = servicio;
    }

    @QueryMapping
    public Serie buscarSerie(@Argument String id, @Argument String titulo) {
        return servicio.buscar(id, titulo).orElse(null);   // null => "no existe" para el cliente
    }

    @QueryMapping
    public List<Serie> listarSeries(@Argument String titulo, @Argument Double calificacionMinima) {
        return servicio.listar(titulo, calificacionMinima);   // el filtrado ocurre en el servidor
    }

    @MutationMapping
    public Serie adicionarSerie(@Argument EntradaSerie input) {
        return servicio.adicionar(input.aSerie());
    }

    @MutationMapping
    public Serie actualizarSerie(@Argument EntradaSerie input) {
        return servicio.actualizar(input.aSerie());
    }

    @MutationMapping
    public boolean eliminarSerie(@Argument String id) {
        return servicio.eliminar(id);
    }

    @SchemaMapping(typeName = "Serie", field = "fechaEstreno")
    public String fechaEstreno(Serie serie) {
        return FechasIso.escribir(serie.getFechaEstreno());
    }
}
