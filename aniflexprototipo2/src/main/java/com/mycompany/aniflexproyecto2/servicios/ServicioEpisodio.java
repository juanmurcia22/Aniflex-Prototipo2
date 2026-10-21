package com.mycompany.aniflexproyecto2.servicios;

import com.mycompany.aniflexproyecto2.model.Episodio;

import java.time.LocalDateTime;
import java.util.List;
import java.util.Optional;
import java.util.concurrent.CopyOnWriteArrayList;

/**
 * Patrón SINGLETON: guarda los episodios (detalle) en una Lista. Un episodio siempre pertenece a una serie existente.
 * Las escrituras se sincronizan sobre el MISMO objeto que ServicioSerie (su instancia): así adicionar un episodio
 * y eliminar su serie nunca ocurren a la vez, y no hay riesgo de bloqueo mutuo (un solo cerrojo).
 */
public final class ServicioEpisodio {

    private static final ServicioEpisodio INSTANCIA = new ServicioEpisodio();

    private final List<Episodio> episodios = new CopyOnWriteArrayList<>();
    private final ServicioSerie series = ServicioSerie.getInstance();
    private final PublicadorCambios publicador = PublicadorCambios.getInstance();

    private ServicioEpisodio() {
        episodios.add(new Episodio("E001", "S001", 1, "A ti, dentro de 2000 años", 8.7,
                LocalDateTime.of(2013, 4, 7, 9, 0), false));
        episodios.add(new Episodio("E002", "S002", 1, "El final de la aventura", 9.0,
                LocalDateTime.of(2023, 9, 29, 21, 0), true));
    }

    public static ServicioEpisodio getInstance() {
        return INSTANCIA;
    }

    public Episodio adicionar(Episodio episodio) {
        synchronized (series) {
            if (episodios.stream().anyMatch(e -> e.getId().equals(episodio.getId()))) {
                throw new IllegalArgumentException("Ya existe un episodio con el ID " + episodio.getId());
            }
            validarRelacion(episodio);
            episodios.add(episodio);
            publicador.notificar("Episodio", "ADICIONADO", episodio.getId());
            return episodio;
        }
    }

    /** Consulta individual por serie + número de episodio. */
    public Optional<Episodio> buscar(String serieId, int noEpisodio) {
        return episodios.stream()
                .filter(e -> e.getSerieId().equals(serieId) && e.getNoEpisodio() == noEpisodio)
                .findFirst();
    }

    public Episodio actualizar(Episodio episodio) {
        synchronized (series) {
            for (int i = 0; i < episodios.size(); i++) {
                if (episodios.get(i).getId().equals(episodio.getId())) {
                    validarRelacion(episodio);
                    episodios.set(i, episodio);
                    publicador.notificar("Episodio", "ACTUALIZADO", episodio.getId());
                    return episodio;
                }
            }
            throw new IllegalArgumentException("No existe un episodio con el ID " + episodio.getId());
        }
    }

    public boolean eliminar(String id) {
        synchronized (series) {
            String limpio = id.trim();
            boolean existia = episodios.removeIf(e -> e.getId().equals(limpio));
            if (existia) {
                publicador.notificar("Episodio", "ELIMINADO", limpio);
            }
            return existia;
        }
    }

    /** Listado con filtros opcionales: serie y título contiene. */
    public List<Episodio> listar(String serieId, String titulo) {
        boolean sinSerie = serieId == null || serieId.isBlank();
        String buscado = titulo == null ? "" : titulo.trim().toLowerCase();
        return episodios.stream()
                .filter(e -> sinSerie || e.getSerieId().equals(serieId.trim()))
                .filter(e -> buscado.isEmpty() || e.getTitulo().toLowerCase().contains(buscado))
                .toList();
    }

    /** Lo usa ServicioSerie para el borrado en cascada. */
    void eliminarDeSerie(String serieId) {
        synchronized (series) {
            episodios.removeIf(e -> e.getSerieId().equals(serieId));
        }
    }

    /** Reglas maestro-detalle: la serie existe y el nº de episodio no se repite dentro de ella. */
    private void validarRelacion(Episodio e) {
        if (!series.existe(e.getSerieId())) {
            throw new IllegalArgumentException("No existe la serie " + e.getSerieId() + ".");
        }
        boolean repetido = episodios.stream().anyMatch(x -> !x.getId().equals(e.getId())
                && x.getSerieId().equals(e.getSerieId()) && x.getNoEpisodio() == e.getNoEpisodio());
        if (repetido) {
            throw new IllegalArgumentException("La serie " + e.getSerieId() + " ya tiene el episodio " + e.getNoEpisodio() + ".");
        }
    }
}
