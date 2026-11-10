package com.mycompany.aniflexproyecto2.model;

import java.time.LocalDateTime;
import java.time.format.DateTimeParseException;

/** Validaciones compartidas por las clases del modelo. Lanzan IllegalArgumentException con mensaje para el usuario. */
final class Validaciones {

    private Validaciones() {
    }

    static String texto(String valor, String campo) {
        if (valor == null || valor.isBlank()) {
            throw new IllegalArgumentException("El campo \"" + campo + "\" es obligatorio.");
        }
        return valor.trim();
    }

    static void entero(int valor, int minimo, String campo) {
        if (valor < minimo) {
            throw new IllegalArgumentException("El campo \"" + campo + "\" debe ser mayor o igual a " + minimo + ".");
        }
    }

    static void calificacion(double valor) {
        if (Double.isNaN(valor) || valor < 0.0 || valor > 10.0) {
            throw new IllegalArgumentException("La calificación debe estar entre 0.0 y 10.0.");
        }
    }

    static void fecha(LocalDateTime valor, String campo) {
        if (valor == null) {
            throw new IllegalArgumentException("El campo \"" + campo + "\" es obligatorio.");
        }
    }

    /** GraphQL no tiene LocalDateTime: la fecha llega como texto ISO-8601 ("2024-05-01T20:30:00"). */
    static LocalDateTime leerFecha(String texto, String campo) {
        try {
            return LocalDateTime.parse(texto);
        } catch (DateTimeParseException | NullPointerException e) {
            throw new IllegalArgumentException("El campo \"" + campo
                    + "\" debe tener formato ISO-8601, por ejemplo 2024-05-01T20:30:00");
        }
    }
}
