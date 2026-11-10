package com.mycompany.aniflexproyecto2.config;

import com.mongodb.ConnectionString;
import com.mongodb.MongoClientSettings;
import com.mongodb.client.MongoClient;
import com.mongodb.client.MongoClients;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.context.annotation.Configuration;
import org.springframework.data.mongodb.config.AbstractMongoClientConfiguration;
import org.springframework.data.mongodb.repository.config.EnableMongoRepositories;

import java.util.concurrent.TimeUnit;

/**
 * Conexion a MongoDB (misma estructura del ejemplo del profe: AbstractMongoClientConfiguration).
 * Base de datos: "Aniflex"; colecciones: "series" (maestro) y "episodios" (detalle).
 */
@Configuration
@EnableMongoRepositories(basePackages = "com.mycompany.aniflexproyecto2.repository")
public class MongoConfig extends AbstractMongoClientConfiguration {

    @Value("${aniflex.mongodb.uri:mongodb://localhost:27017}")
    private String uri;

    @Value("${aniflex.mongodb.database:Aniflex}")
    private String baseDeDatos;

    @Value("${aniflex.mongodb.timeout-segundos:3}")
    private int timeoutSegundos;

    @Override
    protected String getDatabaseName() {
        return baseDeDatos;
    }

    @Override
    public MongoClient mongoClient() {
        MongoClientSettings settings = MongoClientSettings.builder()
                .applyConnectionString(new ConnectionString(uri))
                // Si Mongo esta apagado, el cliente recibe un mensaje rapido en vez de esperar 30 s.
                .applyToClusterSettings(b -> b.serverSelectionTimeout(timeoutSegundos, TimeUnit.SECONDS))
                .build();
        return MongoClients.create(settings);
    }
}
