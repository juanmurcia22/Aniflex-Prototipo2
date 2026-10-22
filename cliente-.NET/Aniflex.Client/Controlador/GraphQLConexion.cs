using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

namespace Aniflex.Client.Controlador
{
    public static class GraphQLConexion
    {
        public static readonly GraphQLHttpClient Cliente =
            new GraphQLHttpClient("http://localhost:8080/graphql",
                                  new NewtonsoftJsonSerializer());

        public static void VerificarErrores<T>(GraphQLResponse<T> response)
        {
            if (response.Errors != null && response.Errors.Length > 0)
                throw new Exception(response.Errors[0].Message);
        }
    }
}