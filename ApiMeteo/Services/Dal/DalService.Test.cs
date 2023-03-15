using ApiMeteo.Models.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace ApiMeteo.Services.Dal
{
    public partial class DalService
    {
        public Sonde? GetSonde(int id)
        {
            using var ctx = GetDbContext();

            return ctx.Sondes!.FirstOrDefault(m => m.Id == id);
        }

        public Meteo? GetMeteo(int id)
        {
            using var ctx = GetDbContext();

            return ctx.Meteos!.Include("Sonde").FirstOrDefault(m => m.Id == id);
        }

        /// <summary>
        /// Méthode pour mise à jour des données
        /// </summary>
        /// <param name="id"></param>
        /// <param name="temperature"></param>
        /// <param name="pression"></param>
        /// <param name="humidite"></param>
        /// <param name="datetime"></param>
        public void UpdateMeteo(int id, float temperature, float pression, float humidite, DateTime datetime)
        {
            using var ctx = GetDbContext();

            var meteo = new Meteo { Id = id, Temperature = temperature, Pression = pression, Humidite = humidite, CreateAt = datetime };
            ctx.Attach(meteo);
            ctx.Entry(meteo).Property(m => m.Temperature).IsModified = true;
            ctx.Entry(meteo).Property(m => m.Pression).IsModified = true;
            ctx.Entry(meteo).Property(m => m.Humidite).IsModified = true;
            ctx.Entry(meteo).Property(m => m.CreateAt).IsModified = true;
            ctx.SaveChanges();
        }

    }
}
