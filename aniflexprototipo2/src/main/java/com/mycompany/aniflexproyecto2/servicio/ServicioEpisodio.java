package com.mycompany.aniflexproyecto2.servicio;

import com.mycompany.aniflexproyecto2.concurrencia.CerrojoDatos;
import com.mycompany.aniflexproyecto2.model.Episodio;
import com.mycompany.aniflexproyecto2.observador.CambioDatos;
import com.mycompany.aniflexproyecto2.observador.PublicadorCambios;
import com.mycompany.aniflexproyecto2.repositorio.IRepositorioEpisodio;
import com.mycompany.aniflexproyecto2.repositorio.IRepositorioSerie;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

/** Lógica de negocio de Episodio (el "detalle"): siempre debe pertenecer a una serie existente. */
@Service
public class ServicioEpisodio implements IServicioEpisodio {

    private final IRepositorioEpisodio repositorio;
    private final IRepositorioSerie series;
    private final PublicadorCambios publicador;
    private final CerrojoDatos cerrojo;

    public ServicioEpisodio(IRepositorioEpisodio repositorio, IRepositorioSerie series,
                            PublicadorCambios publicador, CerrojoDatos cerrojo) {
        this.repositorio = repositorio;
        this.series = series;
        this.publicador = publicador;
        this.cerrojo = cerrojo;
    }

    @Override
    public Episodio adicionar(Episodio episodio) {
        return cerrojo.conBloqueo(() -> {
            if (repositorio.buscarPorId(episodio.getId()).isPresent()) {
                throw new IllegalArgumentException("Ya existe un episodio con el ID " + episodio.getId());
            }
            validarRelacion(episodio);
            repositorio.agregar(episodio);
            publicador.notificar(new CambioDatos("Episodio", "ADICIONADO", episodio.getId()));
            return episodio;
        });
    }

    @Override
    public Optional<Episodio> buscar(String serieId, int noEpisodio) {
        return cerrojo.conBloqueo(() -> repositorio.todos().stream()
                .filter(e -> e.getSerieId().equals(serieId) && e.getNoEpisodio() == noEpisodio)
                .findFirst());
    }

    @Override
    public Episodio actualizar(Episodio episodio) {
        return cerrojo.conBloqueo(() -> {
            if (repositorio.buscarPorId(episodio.getId()).isEmpty()) {
                throw new IllegalArgumentException("No existe un episodio con el ID " + episodio.getId());
            }
            validarRelacion(episodio);
            repositorio.reemplazar(episodio);
            publicador.notificar(new CambioDatos("Episodio", "ACTUALIZADO", episodio.getId()));
            return episodio;
        });
    }

    @Override
    public boolean eliminar(String id) {
        return cerrojo.conBloqueo(() -> {
            boolean existia = repositorio.eliminar(id.trim());
            if (existia) {
                publicador.notificar(new CambioDatos("Episodio", "ELIMINADO", id.trim()));
            }
            return existia;
        });
    }

    @Override
    public List<Episodio> listar(String serieId, String titulo) {
        boolean sinSerie = serieId == null || serieId.isBlank();
        String buscado = titulo == null ? "" : titulo.trim().toLowerCase();
        return cerrojo.conBloqueo(() -> repositorio.todos().stream()
                .filter(e -> sinSerie || e.getSerieId().equals(serieId.trim()))
                .filter(e -> buscado.isEmpty() || e.getTitulo().toLowerCase().contains(buscado))
                .toList());
    }

    @Override
    public int eliminarDeSerie(String serieId) {
        return cerrojo.conBloqueo(() -> {
            int n = repositorio.eliminarDeSerie(serieId);
            if (n > 0) {
                publicador.notificar(new CambioDatos("Episodio", "ELIMINADOS_EN_CASCADA", serieId));
            }
            return n;
        });
    }

    /** Reglas de la relación maestro-detalle: la serie existe y no se repite el número de episodio dentro de ella. */
    private void validarRelacion(Episodio e) {
        if (series.buscarPorId(e.getSerieId()).isEmpty()) {
            throw new IllegalArgumentException("No existe la serie " + e.getSerieId() + ".");
        }
        boolean repetido = repositorio.todos().stream().anyMatch(x ->
                !x.getId().equals(e.getId()) && x.getSerieId().equals(e.getSerieId()) && x.getNoEpisodio() == e.getNoEpisodio());
        if (repetido) {
            throw new IllegalArgumentException("La serie " + e.getSerieId() + " ya tiene el episodio " + e.getNoEpisodio() + ".");
        }
    }
}
