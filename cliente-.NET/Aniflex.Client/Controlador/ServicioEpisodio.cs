using Aniflex.Client.Controlador;
using Aniflex.Client.Modelo;
using GraphQL;
using Newtonsoft.Json;

namespace Aniflex.Client.Servicios
{
    public sealed class ServicioEpisodio
    {
        private static readonly ServicioEpisodio _instancia = new ServicioEpisodio();

        private ServicioEpisodio() { }
        public static ServicioEpisodio GetInstance() => _instancia;
        private const string Campos =
            "id serieId noEpisodio titulo calificacion fechaEmision esEspecial";

        public async Task<List<Episodio>> ListarAsync(string serieId = null, string titulo = null)
        {
            var request = new GraphQLRequest
            {
                Query = $@"
                query($serieId: ID, $titulo: String) {{
                    listarEpisodios(serieId: $serieId, titulo: $titulo) {{ {Campos} }}
                }}",
                Variables = new { serieId, titulo }
            };
            var r = await GraphQLConexion.Cliente.SendQueryAsync<ListarResponse>(request);
            GraphQLConexion.VerificarErrores(r);
            return r.Data?.ListarEpisodios ?? new List<Episodio>();
        }

        public async Task<Episodio> BuscarAsync(string serieId, int noEpisodio)
        {
            var request = new GraphQLRequest
            {
                Query = $@"
                query($serieId: ID!, $noEpisodio: Int!) {{
                    buscarEpisodio(serieId: $serieId, noEpisodio: $noEpisodio) {{ {Campos} }}
                }}",
                Variables = new { serieId, noEpisodio }
            };
            var r = await GraphQLConexion.Cliente.SendQueryAsync<BuscarResponse>(request);
            GraphQLConexion.VerificarErrores(r);
            return r.Data?.BuscarEpisodio;
        }

        public async Task<Episodio> AdicionarAsync(Episodio e)
        {
            var request = new GraphQLRequest
            {
                Query = $@"
                mutation($input: EpisodioInput!) {{
                    adicionarEpisodio(input: $input) {{ {Campos} }}
                }}",
                Variables = new { input = AInput(e) }
            };
            var r = await GraphQLConexion.Cliente.SendMutationAsync<AdicionarResponse>(request);
            GraphQLConexion.VerificarErrores(r);
            return r.Data?.AdicionarEpisodio;
        }

        public async Task<Episodio> ActualizarAsync(Episodio e)
        {
            var request = new GraphQLRequest
            {
                Query = $@"
                mutation($input: EpisodioInput!) {{
                    actualizarEpisodio(input: $input) {{ {Campos} }}
                }}",
                Variables = new { input = AInput(e) }
            };
            var r = await GraphQLConexion.Cliente.SendMutationAsync<ActualizarResponse>(request);
            GraphQLConexion.VerificarErrores(r);
            return r.Data?.ActualizarEpisodio;
        }

        public async Task<bool> EliminarAsync(string id)
        {
            var request = new GraphQLRequest
            {
                Query = "mutation($id: ID!) { eliminarEpisodio(id: $id) }",
                Variables = new { id }
            };
            var r = await GraphQLConexion.Cliente.SendMutationAsync<EliminarResponse>(request);
            GraphQLConexion.VerificarErrores(r);
            return r.Data?.EliminarEpisodio ?? false;
        }

        private static object AInput(Episodio e) => new
        {
            id = e.Id,
            serieId = e.SerieId,
            noEpisodio = e.NoEpisodio,
            titulo = e.Titulo,
            calificacion = e.Calificacion,
            fechaEmision = e.FechaEmision,
            esEspecial = e.EsEspecial
        };

        private class ListarResponse { [JsonProperty("listarEpisodios")] public List<Episodio> ListarEpisodios { get; set; } }
        private class BuscarResponse { [JsonProperty("buscarEpisodio")] public Episodio BuscarEpisodio { get; set; } }
        private class AdicionarResponse { [JsonProperty("adicionarEpisodio")] public Episodio AdicionarEpisodio { get; set; } }
        private class ActualizarResponse { [JsonProperty("actualizarEpisodio")] public Episodio ActualizarEpisodio { get; set; } }
        private class EliminarResponse { [JsonProperty("eliminarEpisodio")] public bool EliminarEpisodio { get; set; } }
    }
}