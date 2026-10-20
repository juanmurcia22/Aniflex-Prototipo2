package com.mycompany.aniflexproyecto2.observador;

import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/**
 * Sujeto del patrón Observer, y además Singleton (una única instancia para todo el servidor).
 * Los servicios le avisan cuando adicionan, actualizan o eliminan; él avisa a todos los observadores.
 */
public final class PublicadorCambios {

    private static final PublicadorCambios INSTANCIA = new PublicadorCambios();

    private final List<ObservadorCambios> observadores = new CopyOnWriteArrayList<>();

    private PublicadorCambios() {
    }

    public static PublicadorCambios getInstance() {
        return INSTANCIA;
    }

    public void registrar(ObservadorCambios observador) {
        observadores.add(observador);
    }

    public void retirar(ObservadorCambios observador) {
        observadores.remove(observador);
    }

    public void notificar(CambioDatos cambio) {
        for (ObservadorCambios o : observadores) {
            o.alCambiar(cambio);
        }
    }
}
