using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Aniflex.Client.Modelo
{
    public class Serie
    {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("titulo")] public string Titulo { get; set; }
        [JsonProperty("temporadas")] public int Temporadas { get; set; }
        [JsonProperty("calificacion")] public double Calificacion { get; set; }
        [JsonProperty("fechaEstreno")] public string FechaEstreno { get; set; }
        [JsonProperty("enEmision")] public bool EnEmision { get; set; }
    }

}

