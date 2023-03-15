using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMeteo.Models.DbEntities
{
    [Table("sonde")]
    public class Sonde
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("mac")]
        public string? Mac { get; set; }

        [Column("created_at")]
        public DateTime? CreateAt { get; set; }

        [Column("last_connected")]
        public DateTime? LastConnected { get; set; }
    }
}
