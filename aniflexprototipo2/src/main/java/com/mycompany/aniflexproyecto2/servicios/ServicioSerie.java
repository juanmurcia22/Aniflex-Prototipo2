package com.mycompany.aniflexproyecto2.servicios;

import com.mycompany.aniflexproyecto2.model.Serie;

import java.time.LocalDateTime;
import java.util.List;
import java.util.Optional;
import java.util.concurrent.CopyOnWriteArrayList;

/**
 * Patrón SINGLETON: una única instancia que guarda las series en una Lista (memoria principal).
 * Las escrituras son synchronized (varios clientes a la vez); las lecturas no necesitan bloqueo
 * porque CopyOnWriteArrayList es segura para lectura concurrente.
 */
public final class ServicioSerie {

    private static final ServicioSerie INSTANCIA = new ServicioSerie();

    private final List<Serie> series = new CopyOnWriteArrayList<>();
    private final PublicadorCambios publicador = PublicadorCambios.getInstance();

    private ServicioSerie() {
        series.add(new Serie("S001", "Attack on Titan", 4, 9.1, LocalDateTime.of(2013, 4, 7, 9, 0), false));
        series.add(new Serie("S002", "Frieren", 1, 9.3, LocalDateTime.of(2023, 9, 29, 21, 0), true));
    }

    public static ServicioSerie getInstance() {
        return INSTANCIA;
    }

    public synchronized Serie adicionar(Serie serie) {
        if (existe(serie.getId())) {
            throw new IllegalArgumentException("Ya existe una serie con el ID " + serie.getId());
        }
        series.add(serie);
        publicador.notificar("Serie", "ADICIONADA", serie.getId());
        return serie;
    }

    /** Consulta individual por uno o dos parámetros (si llegan ambos, deben coincidir ambos). */
    public Optional<Serie> buscar(String id, String titulo) {
        boolean sinId = id == null || id.isBlank();
        boolean sinTitulo = titulo == null || titulo.isBlank();
        if (sinId && sinTitulo) {
            throw new IllegalArgumentException("Indique al menos un parámetro de búsqueda.");
        }
        return series.stream()
                .filter(s -> sinId || s.getId().equals(id.trim()))
                .filter(s -> sinTitulo || s.getTitulo().equalsIgnoreCase(titulo.trim()))
                .findFirst();
    }

    public synchronized Serie actualizar(Serie serie) {
        for (int i = 0; i < series.size(); i++) {
            if (series.get(i).getId().equals(serie.getId())) {
                series.set(i, serie);
                publicador.notificar("Serie", "ACTUALIZADA", serie.getId());
                return serie;
            }
        }
        throw new IllegalArgumentException("No existe una serie con el ID " + serie.getId());
    }

    /** Elimina la serie y, en cascada, sus episodios (no deben quedar huérfanos). */
    public synchronized boolean eliminar(String id) {
        String limpio = id.trim();
        boolean existia = series.removeIf(s -> s.getId().equals(limpio));
        if (existia) {
            ServicioEpisodio.getInstance().eliminarDeSerie(limpio);
            publicador.notificar("Serie", "ELIMINADA", limpio);
        }
        return existia;
    }

    /** Listado con filtros opcionales: título contiene y calificación mínima. */
    public List<Serie> listar(String titulo, Double calificacionMinima) {
        String buscado = titulo == null ? "" : titulo.trim().toLowerCase();
        return series.stream()
                .filter(s -> buscado.isEmpty() || s.getTitulo().toLowerCase().contains(buscado))
                .filter(s -> calificacionMinima == null || s.getCalificacion() >= calificacionMinima)
                .toList();
    }

    public boolean existe(String id) {
        return series.stream().anyMatch(s -> s.getId().equals(id));
    }
}
