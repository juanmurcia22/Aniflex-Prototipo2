package com.mycompany.aniflexproyecto2.controlador;

import graphql.GraphQLError;
import graphql.GraphqlErrorBuilder;
import graphql.schema.DataFetchingEnvironment;
import org.springframework.graphql.execution.DataFetcherExceptionResolverAdapter;
import org.springframework.graphql.execution.ErrorType;
import org.springframework.stereotype.Component;

/**
 * Sin esto, toda excepción llega al cliente como un genérico "INTERNAL_ERROR".
 * Aquí las IllegalArgumentException (ID duplicado, calificación fuera de rango, serie inexistente...)
 * se convierten en errores GraphQL con el mensaje real, que el cliente React muestra al usuario.
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
        return null;   // otras excepciones: comportamiento por defecto de Spring
    }
}
