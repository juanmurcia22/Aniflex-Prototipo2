package com.mycompany.aniflexproyecto2.concurrencia;

import java.util.concurrent.locks.ReentrantLock;
import java.util.function.Supplier;

/**
 * Singleton con el cerrojo que protege las colecciones en memoria.
 * Varios clientes llaman al servidor a la vez y las operaciones del tipo "¿existe? -> agrego" deben ser atómicas.
 * Un solo cerrojo compartido por ambos servicios también evita que se agregue un episodio a una serie
 * justo mientras esa serie se elimina. Es reentrante: un servicio puede llamar al otro con el cerrojo tomado.
 */
public final class CerrojoDatos {

    private static final CerrojoDatos INSTANCIA = new CerrojoDatos();

    private final ReentrantLock cerrojo = new ReentrantLock();

    private CerrojoDatos() {
    }

    public static CerrojoDatos getInstance() {
        return INSTANCIA;
    }

    public <R> R conBloqueo(Supplier<R> accion) {
        cerrojo.lock();
        try {
            return accion.get();
        } finally {
            cerrojo.unlock();
        }
    }
}
