package com.mycompany.aniflexproyecto2.controller;

import com.mycompany.aniflexproyecto2.model.Serie;
import com.mycompany.aniflexproyecto2.model.SerieInput;
import com.mycompany.aniflexproyecto2.servicios.ServicioSerie;
import org.springframework.graphql.data.method.annotation.Argument;
import org.springframework.graphql.data.method.annotation.MutationMapping;
import org.springframework.graphql.data.method.annotation.QueryMapping;
import org.springframework.graphql.data.method.annotation.SchemaMapping;
import org.springframework.stereotype.Controller;

import java.time.format.DateTimeFormatter;
import java.util.List;

/** CONTROLLER (MVC) de Serie: cada método se enlaza por NOMBRE con el schema; solo recibe, delega y devuelve. */
@Controller
public class SerieController {

    private final ServicioSerie servicio = ServicioSerie.getInstance();

    @QueryMapping
    public Serie buscarSerie(@Argument String id, @Argument String titulo) {
        return servicio.buscar(id, titulo).orElse(null);   // null => "no existe" para el cliente
    }

    @QueryMapping
    public List<Serie> listarSeries(@Argument String titulo, @Argument Double calificacionMinima) {
        return servicio.listar(titulo, calificacionMinima);
    }

    @MutationMapping
    public Serie adicionarSerie(@Argument SerieInput input) {
        return servicio.adicionar(input.aSerie());
    }

    @MutationMapping
    public Serie actualizarSerie(@Argument SerieInput input) {
        return servicio.actualizar(input.aSerie());
    }

    @MutationMapping
    public boolean eliminarSerie(@Argument String id) {
        return servicio.eliminar(id);
    }

    /** La fecha viaja como texto ISO-8601 con segundos: "2024-05-01T20:30:00". */
    @SchemaMapping(typeName = "Serie", field = "fechaEstreno")
    public String fechaEstreno(Serie serie) {
        return serie.getFechaEstreno().format(DateTimeFormatter.ISO_LOCAL_DATE_TIME);
    }
}
