package com.mycompany.aniflexproyecto2.controlador;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.time.format.DateTimeParseException;

/** GraphQL no tiene LocalDateTime: la fecha viaja como texto ISO-8601 ("2024-05-01T20:30:00"). */
final class FechasIso {

    private FechasIso() {
    }

    static LocalDateTime leer(String texto, String campo) {
        try {
            return LocalDateTime.parse(texto);
        } catch (DateTimeParseException | NullPointerException e) {
            throw new IllegalArgumentException("El campo \"" + campo
                    + "\" debe tener formato ISO-8601, por ejemplo 2024-05-01T20:30:00");
        }
    }

    static String escribir(LocalDateTime fecha) {
        return fecha.format(DateTimeFormatter.ISO_LOCAL_DATE_TIME);
    }
}
