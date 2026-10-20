package com.mycompany.aniflexproyecto2.repositorio;

import com.mycompany.aniflexproyecto2.model.Identificable;

import java.util.List;
import java.util.Optional;

/** Contrato de almacenamiento. Los servicios dependen de esta interfaz, no de cómo se guardan los datos (DIP). */
public interface IRepositorio<T extends Identificable> {
    List<T> todos();
    Optional<T> buscarPorId(String id);
    void agregar(T entidad);
    void reemplazar(T entidad);
    boolean eliminar(String id);
}
