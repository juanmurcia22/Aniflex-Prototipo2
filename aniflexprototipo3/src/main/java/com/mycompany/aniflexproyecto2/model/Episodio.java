package com.mycompany.aniflexproyecto2.model;

import org.springframework.data.annotation.Id;
import org.springframework.data.annotation.PersistenceCreator;
import org.springframework.data.mongodb.core.mapping.Document;
import org.springframework.data.mongodb.core.mapping.Field;
import org.springframework.data.mongodb.core.mapping.FieldType;

import java.time.LocalDateTime;

/**
 * Clase estructural DETALLE. Pertenece a una Serie mediante serieId.
 * Atributos: String (id, serieId, titulo), int (noEpisodio), double (calificacion),
 * LocalDateTime (fechaEmision) y boolean (esEspecial).
 * Se guarda en la coleccion MongoDB "episodios"; el _id es un ObjectId generado por MongoDB al insertar
 * y serieId referencia (tambien como ObjectId) al _id de la coleccion "series".
 */
@Document(collection = "episodios")
public final class Episodio {

    @Id
    private String id;   // no es final: Spring Data le asigna el ObjectId generado al insertar
    @Field(targetType = FieldType.OBJECT_ID)   // se guarda como ObjectId, igual que el _id de "series"
    private final String serieId;
    private final int noEpisodio;
    private final String titulo;
    private final double calificacion;
    private final LocalDateTime fechaEmision;
    private final boolean esEspecial;

    /** Episodio NUEVO: sin id (id = null); MongoDB genera el ObjectId al insertar. */
    public Episodio(String serieId, int noEpisodio, String titulo, double calificacion,
                    LocalDateTime fechaEmision, boolean esEspecial) {
        this.serieId = Validaciones.texto(serieId, "Serie");
        Validaciones.entero(noEpisodio, 1, "Nº de episodio");
        this.titulo = Validaciones.texto(titulo, "Título");
        Validaciones.calificacion(calificacion);
        Validaciones.fecha(fechaEmision, "Fecha de emisión");
        this.noEpisodio = noEpisodio;
        this.calificacion = calificacion;
        this.fechaEmision = fechaEmision;
        this.esEspecial = esEspecial;
    }

    /** Episodio EXISTENTE (lectura desde Mongo y actualizar): el id es obligatorio. */
    @PersistenceCreator
    public Episodio(String id, String serieId, int noEpisodio, String titulo, double calificacion,
                    LocalDateTime fechaEmision, boolean esEspecial) {
        this.id = Validaciones.texto(id, "ID");
        this.serieId = Validaciones.texto(serieId, "Serie");
        Validaciones.entero(noEpisodio, 1, "Nº de episodio");
        this.titulo = Validaciones.texto(titulo, "Título");
        Validaciones.calificacion(calificacion);
        Validaciones.fecha(fechaEmision, "Fecha de emisión");
        this.noEpisodio = noEpisodio;
        this.calificacion = calificacion;
        this.fechaEmision = fechaEmision;
        this.esEspecial = esEspecial;
    }

    public String getId() { return id; }
    public String getSerieId() { return serieId; }
    public int getNoEpisodio() { return noEpisodio; }
    public String getTitulo() { return titulo; }
    public double getCalificacion() { return calificacion; }
    public LocalDateTime getFechaEmision() { return fechaEmision; }
    public boolean isEsEspecial() { return esEspecial; }
}
