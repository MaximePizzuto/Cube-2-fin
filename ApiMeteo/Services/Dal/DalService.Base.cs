using Microsoft.EntityFrameworkCore;

namespace ApiMeteo.Services.Dal
{
    public partial class DalService
    {
        private string _connectionString { get; set; }
        public DalService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new Exception
            ("Chaine de connexion manquante");
        }
        private ApiMeteoDbContext GetDbContext()
        {
            return new ApiMeteoDbContext(_connectionString);
        }
    }
}
