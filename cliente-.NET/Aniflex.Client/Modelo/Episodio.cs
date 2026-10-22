using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aniflex.Client.Modelo
{
    public class Episodio
    {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("serieId")] public string SerieId { get; set; }
        [JsonProperty("noEpisodio")] public int NoEpisodio { get; set; }
        [JsonProperty("titulo")] public string Titulo { get; set; }
        [JsonProperty("calificacion")] public double Calificacion { get; set; }
        [JsonProperty("fechaEmision")] public string FechaEmision { get; set; }
        [JsonProperty("esEspecial")] public bool EsEspecial { get; set; }
    }
}
