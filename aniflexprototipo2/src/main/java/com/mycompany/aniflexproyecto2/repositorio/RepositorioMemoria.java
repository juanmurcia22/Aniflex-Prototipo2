package com.mycompany.aniflexproyecto2.repositorio;

import com.mycompany.aniflexproyecto2.model.Identificable;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

/**
 * Almacenamiento en memoria principal usando una List (requisito de la rúbrica).
 * No sincroniza por sí mismo: los servicios lo usan siempre dentro de CerrojoDatos.
 */
public abstract class RepositorioMemoria<T extends Identificable> implements IRepositorio<T> {

    protected final List<T> datos = new ArrayList<>();

    @Override
    public List<T> todos() {
        return List.copyOf(datos);   // copia: nadie modifica la lista interna desde fuera
    }

    @Override
    public Optional<T> buscarPorId(String id) {
        return datos.stream().filter(e -> e.getId().equals(id)).findFirst();
    }

    @Override
    public void agregar(T entidad) {
        datos.add(entidad);
    }

    @Override
    public void reemplazar(T entidad) {
        for (int i = 0; i < datos.size(); i++) {
            if (datos.get(i).getId().equals(entidad.getId())) {
                datos.set(i, entidad);
                return;
            }
        }
        throw new IllegalArgumentException("No existe un registro con el ID " + entidad.getId());
    }

    @Override
    public boolean eliminar(String id) {
        return datos.removeIf(e -> e.getId().equals(id));
    }
}
