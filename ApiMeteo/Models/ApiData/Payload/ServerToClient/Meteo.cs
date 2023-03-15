using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMeteo.Models.ApiData.Payload.ServerToClient
{
    public class Meteo
    {
        public float? Temperature { get; set; }
        public float? Pression { get; set; }
        public float? Humidite { get; set; }
        public DateTime? CreateAt { get; set; }
    }
}
