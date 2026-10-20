package com.mycompany.aniflexproyecto2.servicio;

import com.mycompany.aniflexproyecto2.concurrencia.CerrojoDatos;
import com.mycompany.aniflexproyecto2.model.Serie;
import com.mycompany.aniflexproyecto2.observador.CambioDatos;
import com.mycompany.aniflexproyecto2.observador.PublicadorCambios;
import com.mycompany.aniflexproyecto2.repositorio.IRepositorioSerie;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

/**
 * Lógica de negocio de Serie. Todas sus dependencias llegan por el constructor y son interfaces
 * (principio de inversión de dependencias): este servicio no sabe si los datos viven en una lista o en una base de datos.
 */
@Service
public class ServicioSerie implements IServicioSerie {

    private final IRepositorioSerie repositorio;
    private final IServicioEpisodio episodios;
    private final PublicadorCambios publicador;
    private final CerrojoDatos cerrojo;

    public ServicioSerie(IRepositorioSerie repositorio, IServicioEpisodio episodios,
                         PublicadorCambios publicador, CerrojoDatos cerrojo) {
        this.repositorio = repositorio;
        this.episodios = episodios;
        this.publicador = publicador;
        this.cerrojo = cerrojo;
    }

    @Override
    public Serie adicionar(Serie serie) {
        return cerrojo.conBloqueo(() -> {
            if (repositorio.buscarPorId(serie.getId()).isPresent()) {
                throw new IllegalArgumentException("Ya existe una serie con el ID " + serie.getId());
            }
            repositorio.agregar(serie);
            publicador.notificar(new CambioDatos("Serie", "ADICIONADA", serie.getId()));
            return serie;
        });
    }

    @Override
    public Optional<Serie> buscar(String id, String titulo) {
        boolean sinId = id == null || id.isBlank();
        boolean sinTitulo = titulo == null || titulo.isBlank();
        if (sinId && sinTitulo) {
            throw new IllegalArgumentException("Indique al menos un parámetro de búsqueda.");
        }
        return cerrojo.conBloqueo(() -> repositorio.todos().stream()
                .filter(s -> sinId || s.getId().equals(id.trim()))
                .filter(s -> sinTitulo || s.getTitulo().equalsIgnoreCase(titulo.trim()))
                .findFirst());
    }

    @Override
    public Serie actualizar(Serie serie) {
        return cerrojo.conBloqueo(() -> {
            if (repositorio.buscarPorId(serie.getId()).isEmpty()) {
                throw new IllegalArgumentException("No existe una serie con el ID " + serie.getId());
            }
            repositorio.reemplazar(serie);
            publicador.notificar(new CambioDatos("Serie", "ACTUALIZADA", serie.getId()));
            return serie;
        });
    }

    @Override
    public boolean eliminar(String id) {
        return cerrojo.conBloqueo(() -> {
            String limpio = id.trim();
            boolean existia = repositorio.eliminar(limpio);
            if (existia) {
                episodios.eliminarDeSerie(limpio);   // cascada: no deben quedar episodios huérfanos
                publicador.notificar(new CambioDatos("Serie", "ELIMINADA", limpio));
            }
            return existia;
        });
    }

    @Override
    public List<Serie> listar(String titulo, Double calificacionMinima) {
        String buscado = titulo == null ? "" : titulo.trim().toLowerCase();
        return cerrojo.conBloqueo(() -> repositorio.todos().stream()
                .filter(s -> buscado.isEmpty() || s.getTitulo().toLowerCase().contains(buscado))
                .filter(s -> calificacionMinima == null || s.getCalificacion() >= calificacionMinima)
                .toList());
    }
}
