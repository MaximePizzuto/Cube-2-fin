using ApiMeteo.Models.DbEntities;
using Microsoft.EntityFrameworkCore;


namespace ApiMeteo.Services
{
    public class ApiMeteoDbContext : DbContext
    {
        private string _connectionString { get; set; }

        public ApiMeteoDbContext(string connectionString) : base()
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql(_connectionString);

        // Ajouter ici les DbSets (liés aux classes représentant les entités de la BDD, placées dans le répertoire Models\DbEntities)
        // Ex. : public virtual DbSet<Agent>? Agents { get; set; }

        public virtual DbSet<Sonde>? Sondes { get; set; }
        public virtual DbSet<Meteo>? Meteos { get; set; }
    }
}
