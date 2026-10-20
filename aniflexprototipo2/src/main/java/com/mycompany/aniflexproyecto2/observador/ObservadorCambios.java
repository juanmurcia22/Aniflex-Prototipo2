package com.mycompany.aniflexproyecto2.observador;

/** Observer: cualquier clase que quiera enterarse de los cambios implementa esta interfaz. */
public interface ObservadorCambios {
    void alCambiar(CambioDatos cambio);
}
