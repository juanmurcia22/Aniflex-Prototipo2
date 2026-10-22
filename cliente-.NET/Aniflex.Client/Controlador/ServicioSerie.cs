using Aniflex.Client.Controlador;
using Aniflex.Client.Modelo;
using GraphQL;
using Newtonsoft.Json;

namespace Aniflex.Client.Servicios
{
    public sealed class ServicioSerie
    {
        private static readonly ServicioSerie _instancia = new ServicioSerie();

        private ServicioSerie() { }
        public static ServicioSerie GetInstance() => _instancia;
        private const string Campos =
            "id titulo temporadas calificacion fechaEstreno enEmision";

        public async Task<List<Serie>> ListarAsync(string titulo = null, double? calificacionMinima = null)
        {
            var request = new GraphQLRequest
            {
                Query = $@"
                query($titulo: String, $calificacionMinima: Float) {{
                    listarSeries(titulo: $titulo, calificacionMinima: $calificacionMinima) {{ {Campos} }}
                }}",
                Variables = new { titulo, calificacionMinima }
            };
            var r = await GraphQLConexion.Cliente.SendQueryAsync<ListarResponse>(request);
            GraphQLConexion.VerificarErrores(r);
            return r.Data?.ListarSeries ?? new List<Serie>();
        }

        public async Task<Serie> BuscarAsync(string id = null, string titulo = null)
        {
            var request = new GraphQLRequest
            {
                Query = $@"
                query($id: ID, $titulo: String) {{
                    buscarSerie(id: $id, titulo: $titulo) {{ {Campos} }}
                }}",
                Variables = new { id, titulo }
            };
            var r = await GraphQLConexion.Cliente.SendQueryAsync<BuscarResponse>(request);
            GraphQLConexion.VerificarErrores(r);
            return r.Data?.BuscarSerie;
        }

        public async Task<Serie> AdicionarAsync(Serie s)
        {
            var request = new GraphQLRequest
            {
                Query = $@"
                mutation($input: SerieInput!) {{
                    adicionarSerie(input: $input) {{ {Campos} }}
                }}",
                Variables = new { input = AInput(s) }
            };
            var r = await GraphQLConexion.Cliente.SendMutationAsync<AdicionarResponse>(request);
            GraphQLConexion.VerificarErrores(r);
            return r.Data?.AdicionarSerie;
        }

        public async Task<Serie> ActualizarAsync(Serie s)
        {
            var request = new GraphQLRequest
            {
                Query = $@"
                mutation($input: SerieInput!) {{
                    actualizarSerie(input: $input) {{ {Campos} }}
                }}",
                Variables = new { input = AInput(s) }
            };
            var r = await GraphQLConexion.Cliente.SendMutationAsync<ActualizarResponse>(request);
            GraphQLConexion.VerificarErrores(r);
            return r.Data?.ActualizarSerie;
        }

        public async Task<bool> EliminarAsync(string id)
        {
            var request = new GraphQLRequest
            {
                Query = "mutation($id: ID!) { eliminarSerie(id: $id) }",
                Variables = new { id }
            };
            var r = await GraphQLConexion.Cliente.SendMutationAsync<EliminarResponse>(request);
            GraphQLConexion.VerificarErrores(r);
            return r.Data?.EliminarSerie ?? false;
        }

        private static object AInput(Serie s) => new
        {
            id = s.Id,
            titulo = s.Titulo,
            temporadas = s.Temporadas,
            calificacion = s.Calificacion,
            fechaEstreno = s.FechaEstreno,
            enEmision = s.EnEmision
        };

        private class ListarResponse { [JsonProperty("listarSeries")] public List<Serie> ListarSeries { get; set; } }
        private class BuscarResponse { [JsonProperty("buscarSerie")] public Serie BuscarSerie { get; set; } }
        private class AdicionarResponse { [JsonProperty("adicionarSerie")] public Serie AdicionarSerie { get; set; } }
        private class ActualizarResponse { [JsonProperty("actualizarSerie")] public Serie ActualizarSerie { get; set; } }
        private class EliminarResponse { [JsonProperty("eliminarSerie")] public bool EliminarSerie { get; set; } }
    }
}