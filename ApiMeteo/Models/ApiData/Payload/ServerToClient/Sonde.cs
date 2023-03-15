using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMeteo.Models.ApiData.Payload.ServerToClient
{
    public class Sonde
    {
        public string? Mac { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? LastConnected { get; set; }
    }
}
