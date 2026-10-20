package com.mycompany.aniflexproyecto2.observador;

/** Evento que describe qué cambió en los datos del servidor. */
public record CambioDatos(String entidad, String operacion, String id) {
}
