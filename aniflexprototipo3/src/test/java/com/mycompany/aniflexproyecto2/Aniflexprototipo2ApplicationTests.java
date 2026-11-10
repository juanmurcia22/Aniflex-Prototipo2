package com.mycompany.aniflexproyecto2;

import org.junit.jupiter.api.Test;
import org.springframework.boot.test.context.SpringBootTest;

// Sin datos iniciales para que el test no dependa de que MongoDB esté encendido.
@SpringBootTest(properties = "aniflex.datos-iniciales=false")
class Aniflexprototipo2ApplicationTests {

    @Test
    void contextLoads() {
    }
}
