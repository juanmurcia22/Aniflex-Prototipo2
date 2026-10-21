package com.mycompany.aniflexproyecto2.servicios;

/** Observador concreto: imprime en la consola del servidor cada cambio (útil en la sustentación). */
public class BitacoraConsola implements PublicadorCambios.Observador {

    @Override
    public void alCambiar(PublicadorCambios.Cambio cambio) {
        System.out.printf("[BITACORA] %s %s (ID %s)%n", cambio.entidad(), cambio.operacion(), cambio.id());
    }
}
