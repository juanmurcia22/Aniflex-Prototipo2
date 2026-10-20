package com.mycompany.aniflexproyecto2.model;

import java.time.LocalDateTime;

/**
 * Clase estructural MAESTRO (Serie 1..1 --> 0..* Episodio).
 * Atributos: String (id, titulo), int (temporadas), double (calificacion),
 * LocalDateTime (fechaEstreno) y boolean (enEmision, el atributo libre).
 * Inmutable: la única forma de crearla es el Builder, que valida; así nunca existe una Serie inválida.
 */
public final class Serie implements Identificable {

    private final String id;
    private final String titulo;
    private final int temporadas;
    private final double calificacion;
    private final LocalDateTime fechaEstreno;
    private final boolean enEmision;

    private Serie(Builder b) {
        this.id = b.id;
        this.titulo = b.titulo;
        this.temporadas = b.temporadas;
        this.calificacion = b.calificacion;
        this.fechaEstreno = b.fechaEstreno;
        this.enEmision = b.enEmision;
    }

    @Override
    public String getId() { return id; }
    public String getTitulo() { return titulo; }
    public int getTemporadas() { return temporadas; }
    public double getCalificacion() { return calificacion; }
    public LocalDateTime getFechaEstreno() { return fechaEstreno; }
    public boolean isEnEmision() { return enEmision; }

    public static Builder builder() {
        return new Builder();
    }

    /** Patrón Builder. */
    public static final class Builder {
        private String id;
        private String titulo;
        private int temporadas;
        private double calificacion;
        private LocalDateTime fechaEstreno;
        private boolean enEmision;

        private Builder() {
        }

        public Builder id(String v) { this.id = v; return this; }
        public Builder titulo(String v) { this.titulo = v; return this; }
        public Builder temporadas(int v) { this.temporadas = v; return this; }
        public Builder calificacion(double v) { this.calificacion = v; return this; }
        public Builder fechaEstreno(LocalDateTime v) { this.fechaEstreno = v; return this; }
        public Builder enEmision(boolean v) { this.enEmision = v; return this; }

        public Serie build() {
            id = Validaciones.textoObligatorio(id, "ID");
            titulo = Validaciones.textoObligatorio(titulo, "Título");
            Validaciones.enteroMinimo(temporadas, 1, "Temporadas");
            Validaciones.calificacion(calificacion);
            Validaciones.fechaObligatoria(fechaEstreno, "Fecha de estreno");
            return new Serie(this);
        }
    }
}
