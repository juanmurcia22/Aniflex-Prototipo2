package com.mycompany.aniflexproyecto2;

import com.mycompany.aniflexproyecto2.servicios.BitacoraConsola;
import com.mycompany.aniflexproyecto2.servicios.PublicadorCambios;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class Aniflexprototipo2Application {

    public static void main(String[] args) {
        // Observer: la bitácora se suscribe al publicador de cambios (Singleton).
        PublicadorCambios.getInstance().registrar(new BitacoraConsola());
        SpringApplication.run(Aniflexprototipo2Application.class, args);
    }
}
