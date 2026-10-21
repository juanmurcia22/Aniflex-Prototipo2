package com.mycompany.aniflexproyecto2.model;

import java.time.LocalDateTime;

/**
 * Clase estructural MAESTRO (Serie 1..1 --> 0..* Episodio).
 * Atributos: String (id, titulo), int (temporadas), double (calificacion),
 * LocalDateTime (fechaEstreno) y boolean (enEmision).
 */
public final class Serie {

    private final String id;
    private final String titulo;
    private final int temporadas;
    private final double calificacion;
    private final LocalDateTime fechaEstreno;
    private final boolean enEmision;

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
