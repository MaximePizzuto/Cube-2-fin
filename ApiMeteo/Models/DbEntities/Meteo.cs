using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMeteo.Models.DbEntities
{
    [Table("meteo")]
    public class Meteo
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("temperature")]
        public float? Temperature { get; set; }

        [Column("pression")]
        public float? Pression { get; set; }

        [Column("humidite")]
        public float? Humidite { get; set; }

        [Column("created_at")]
        public DateTime? CreateAt { get; set; }

        [Column("sonde_id")]
        public int? SondeId { get; set; }

        [ForeignKey("SondeId")]
        public virtual Sonde? Sonde { get; set; }

    }
}