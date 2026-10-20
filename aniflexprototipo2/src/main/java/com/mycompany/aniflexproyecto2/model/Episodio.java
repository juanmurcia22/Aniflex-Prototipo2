package com.mycompany.aniflexproyecto2.model;

import java.time.LocalDateTime;

/**
 * Clase estructural DETALLE. Pertenece a una Serie mediante serieId.
 * Atributos: String (id, serieId, titulo), int (noEpisodio), double (calificacion),
 * LocalDateTime (fechaEmision) y boolean (esEspecial, el atributo libre).
 */
public final class Episodio implements Identificable {

    private final String id;
    private final String serieId;
    private final int noEpisodio;
    private final String titulo;
    private final double calificacion;
    private final LocalDateTime fechaEmision;
    private final boolean esEspecial;

    private Episodio(Builder b) {
        this.id = b.id;
        this.serieId = b.serieId;
        this.noEpisodio = b.noEpisodio;
        this.titulo = b.titulo;
        this.calificacion = b.calificacion;
        this.fechaEmision = b.fechaEmision;
        this.esEspecial = b.esEspecial;
    }

    @Override
    public String getId() { return id; }
    public String getSerieId() { return serieId; }
    public int getNoEpisodio() { return noEpisodio; }
    public String getTitulo() { return titulo; }
    public double getCalificacion() { return calificacion; }
    public LocalDateTime getFechaEmision() { return fechaEmision; }
    public boolean isEsEspecial() { return esEspecial; }

    public static Builder builder() {
        return new Builder();
    }

    /** Patrón Builder. */
    public static final class Builder {
        private String id;
        private String serieId;
        private int noEpisodio;
        private String titulo;
        private double calificacion;
        private LocalDateTime fechaEmision;
        private boolean esEspecial;

        private Builder() {
        }

        public Builder id(String v) { this.id = v; return this; }
        public Builder serieId(String v) { this.serieId = v; return this; }
        public Builder noEpisodio(int v) { this.noEpisodio = v; return this; }
        public Builder titulo(String v) { this.titulo = v; return this; }
        public Builder calificacion(double v) { this.calificacion = v; return this; }
        public Builder fechaEmision(LocalDateTime v) { this.fechaEmision = v; return this; }
        public Builder esEspecial(boolean v) { this.esEspecial = v; return this; }

        public Episodio build() {
            id = Validaciones.textoObligatorio(id, "ID");
            serieId = Validaciones.textoObligatorio(serieId, "Serie");
            Validaciones.enteroMinimo(noEpisodio, 1, "Nº de episodio");
            titulo = Validaciones.textoObligatorio(titulo, "Título");
            Validaciones.calificacion(calificacion);
            Validaciones.fechaObligatoria(fechaEmision, "Fecha de emisión");
            return new Episodio(this);
        }
    }
}
