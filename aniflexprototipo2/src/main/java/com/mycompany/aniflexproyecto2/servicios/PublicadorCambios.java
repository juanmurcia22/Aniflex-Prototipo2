package com.mycompany.aniflexproyecto2.servicios;

import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/**
 * Patrones SINGLETON + OBSERVER.
 * Es el sujeto observado y existe una sola instancia en todo el servidor.
 * Los servicios le avisan cada vez que adicionan, actualizan o eliminan; él avisa a los observadores.
 */
public final class PublicadorCambios {

    /** Observer: quien quiera enterarse de los cambios implementa esta interfaz. */
    public interface Observador {
        void alCambiar(Cambio cambio);
    }

    /** Evento que describe qué cambió. */
    public record Cambio(String entidad, String operacion, String id) {
    }

    private static final PublicadorCambios INSTANCIA = new PublicadorCambios();

    private final List<Observador> observadores = new CopyOnWriteArrayList<>();

    private PublicadorCambios() {
    }

    public static PublicadorCambios getInstance() {
        return INSTANCIA;
    }

    public void registrar(Observador observador) {
        observadores.add(observador);
    }

    public void retirar(Observador observador) {
        observadores.remove(observador);
    }

    public void notificar(String entidad, String operacion, String id) {
        Cambio cambio = new Cambio(entidad, operacion, id);
        for (Observador o : observadores) {
            o.alCambiar(cambio);
        }
    }
}
