package com.mycompany.aniflexproyecto2.config;

import com.mycompany.aniflexproyecto2.concurrencia.CerrojoDatos;
import com.mycompany.aniflexproyecto2.observador.BitacoraConsola;
import com.mycompany.aniflexproyecto2.observador.PublicadorCambios;
import com.mycompany.aniflexproyecto2.repositorio.IRepositorioEpisodio;
import com.mycompany.aniflexproyecto2.repositorio.IRepositorioSerie;
import com.mycompany.aniflexproyecto2.repositorio.RepositorioEpisodioMemoria;
import com.mycompany.aniflexproyecto2.repositorio.RepositorioSerieMemoria;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

/**
 * Entrega a Spring las instancias Singleton (getInstance) para que las inyecte en los servicios.
 * Es el único lugar donde se decide qué implementación concreta se usa (cambiar a una base de datos = cambiar aquí).
 */
@Configuration
public class ConfiguracionBeans {

    @Bean
    public IRepositorioSerie repositorioSerie() {
        return RepositorioSerieMemoria.getInstance();
    }

    @Bean
    public IRepositorioEpisodio repositorioEpisodio() {
        return RepositorioEpisodioMemoria.getInstance();
    }

    @Bean
    public CerrojoDatos cerrojoDatos() {
        return CerrojoDatos.getInstance();
    }

    @Bean
    public PublicadorCambios publicadorCambios() {
        PublicadorCambios publicador = PublicadorCambios.getInstance();
        publicador.registrar(new BitacoraConsola());   // Observer concreto
        return publicador;
    }
}
