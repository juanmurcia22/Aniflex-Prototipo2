package com.mycompany.aniflexproyecto2.model;

import java.time.LocalDateTime;

/**
 * Clase estructural DETALLE. Pertenece a una Serie mediante serieId.
 * Atributos: String (id, serieId, titulo), int (noEpisodio), double (calificacion),
 * LocalDateTime (fechaEmision) y boolean (esEspecial).
 */
public final class Episodio {

    private final String id;
    private final String serieId;
    private final int noEpisodio;
    private final String titulo;
    private final double calificacion;
    private final LocalDateTime fechaEmision;
    private final boolean esEspecial;

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
