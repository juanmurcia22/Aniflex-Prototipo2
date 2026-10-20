package com.mycompany.aniflexproyecto2.model;

import java.time.LocalDateTime;

/** Reglas de validación compartidas por los Builder. Lanzan IllegalArgumentException con mensaje para el usuario. */
final class Validaciones {

    private Validaciones() {
    }

    static String textoObligatorio(String valor, String campo) {
        if (valor == null || valor.isBlank()) {
            throw new IllegalArgumentException("El campo \"" + campo + "\" es obligatorio.");
        }
        return valor.trim();
    }

    static int enteroMinimo(int valor, int minimo, String campo) {
        if (valor < minimo) {
            throw new IllegalArgumentException("El campo \"" + campo + "\" debe ser un entero mayor o igual a " + minimo + ".");
        }
        return valor;
    }

    static double calificacion(double valor) {
        if (Double.isNaN(valor) || valor < 0.0 || valor > 10.0) {
            throw new IllegalArgumentException("La calificación debe estar entre 0.0 y 10.0.");
        }
        return valor;
    }

    static LocalDateTime fechaObligatoria(LocalDateTime valor, String campo) {
        if (valor == null) {
            throw new IllegalArgumentException("El campo \"" + campo + "\" es obligatorio.");
        }
        return valor;
    }
}
