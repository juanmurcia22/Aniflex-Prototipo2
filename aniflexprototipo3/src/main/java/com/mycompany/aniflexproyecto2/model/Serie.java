package com.mycompany.aniflexproyecto2.model;

import org.springframework.data.annotation.Id;
import org.springframework.data.annotation.PersistenceCreator;
import org.springframework.data.mongodb.core.mapping.Document;

import java.time.LocalDateTime;

/**
 * Clase estructural MAESTRO (Serie 1..1 --> 0..* Episodio).
 * Atributos: String (id, titulo), int (temporadas), double (calificacion),
 * LocalDateTime (fechaEstreno) y boolean (enEmision).
 * Se guarda en la coleccion MongoDB "series"; el id es la llave primaria (_id) y es un ObjectId
 * generado por MongoDB al insertar (igual que el ejemplo del profe): en Java se maneja como String.
 */
@Document(collection = "series")
public final class Serie {

    @Id
    private String id;   // no es final: Spring Data le asigna el ObjectId generado al insertar
    private final String titulo;
    private final int temporadas;
    private final double calificacion;
    private final LocalDateTime fechaEstreno;
    private final boolean enEmision;

    /** Serie NUEVA: sin id (id = null); MongoDB genera el ObjectId al insertar. */
    public Serie(String titulo, int temporadas, double calificacion,
                 LocalDateTime fechaEstreno, boolean enEmision) {
        this.titulo = Validaciones.texto(titulo, "Título");
        Validaciones.entero(temporadas, 1, "Temporadas");
        Validaciones.calificacion(calificacion);
        Validaciones.fecha(fechaEstreno, "Fecha de estreno");
        this.temporadas = temporadas;
        this.calificacion = calificacion;
        this.fechaEstreno = fechaEstreno;
        this.enEmision = enEmision;
    }

    /** Serie EXISTENTE (lectura desde Mongo y actualizar): el id es obligatorio. */
    @PersistenceCreator
    public Serie(String id, String titulo, int temporadas, double calificacion,
                 LocalDateTime fechaEstreno, boolean enEmision) {
        this.id = Validaciones.texto(id, "ID");
        this.titulo = Validaciones.texto(titulo, "Título");
        Validaciones.entero(temporadas, 1, "Temporadas");
        Validaciones.calificacion(calificacion);
        Validaciones.fecha(fechaEstreno, "Fecha de estreno");
        this.temporadas = temporadas;
        this.calificacion = calificacion;
        this.fechaEstreno = fechaEstreno;
        this.enEmision = enEmision;
    }

    public String getId() { return id; }
    public String getTitulo() { return titulo; }
    public int getTemporadas() { return temporadas; }
    public double getCalificacion() { return calificacion; }
    public LocalDateTime getFechaEstreno() { return fechaEstreno; }
    public boolean isEnEmision() { return enEmision; }
}
