package com.mycompany.aniflexproyecto2.controller;

import graphql.GraphQLError;
import graphql.GraphqlErrorBuilder;
import graphql.schema.DataFetchingEnvironment;
import org.springframework.dao.DataAccessException;
import org.springframework.graphql.execution.DataFetcherExceptionResolverAdapter;
import org.springframework.graphql.execution.ErrorType;
import org.springframework.stereotype.Component;

/**
 * Convierte las IllegalArgumentException (ID duplicado, calificación fuera de rango, serie inexistente...)
 * en errores GraphQL con el mensaje real (y los fallos de MongoDB en un mensaje claro); el cliente lo lee en errors[0].message y se lo muestra al usuario.
 */
@Component
public class ManejadorErroresGraphQL extends DataFetcherExceptionResolverAdapter {

    @Override
    protected GraphQLError resolveToSingleError(Throwable ex, DataFetchingEnvironment env) {
        if (ex instanceof IllegalArgumentException) {
            return GraphqlErrorBuilder.newError(env)
                    .errorType(ErrorType.BAD_REQUEST)
                    .message(ex.getMessage())
                    .build();
        }
        if (ex instanceof DataAccessException || ex instanceof com.mongodb.MongoException) {
            return GraphqlErrorBuilder.newError(env)
                    .errorType(ErrorType.INTERNAL_ERROR)
                    .message("No se pudo acceder a la base de datos MongoDB. Verifique que el servicio esté encendido.")
                    .build();
        }
        return null;
    }
}
