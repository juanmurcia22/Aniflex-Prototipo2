package com.mycompany.aniflexproyecto2.observador;

/** Observador concreto: imprime en la consola del servidor cada cambio que ocurre (útil en la sustentación). */
public class BitacoraConsola implements ObservadorCambios {

    @Override
    public void alCambiar(CambioDatos cambio) {
        System.out.printf("[BITACORA] %s %s (ID %s)%n", cambio.entidad(), cambio.operacion(), cambio.id());
    }
}
