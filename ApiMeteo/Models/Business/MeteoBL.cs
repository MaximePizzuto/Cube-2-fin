using ApiMeteo.Models.ApiData.Payload.ServerToClient;
using ApiMeteo.Models.DbEntities;
using ApiMeteo.Services.Dal;

namespace ApiMeteo.Models.Business
{
    public class MeteoBL
    {
        private readonly DalService _demoDal;

        public MeteoBL(DalService demoDalService)
        {
            _demoDal = demoDalService;
        }

        public Models.ApiData.Payload.ServerToClient.Sonde? GetSonde(int id)
        {
            var sondeDb = _demoDal.GetSonde(id);

            if (sondeDb == null)
                return null;

            return new ApiData.Payload.ServerToClient.Sonde()
            {
                Mac = sondeDb.Mac,
                CreateAt = sondeDb.CreateAt,
                LastConnected = sondeDb.LastConnected,

            };
        }

        public Models.ApiData.Payload.ServerToClient.Meteo? GetMeteo(int id)
        {
            var meteoDb = _demoDal.GetMeteo(id);

            if (meteoDb == null)
                return null;

            return new ApiData.Payload.ServerToClient.Meteo()
            {
                Temperature = meteoDb.Temperature,
                Pression = meteoDb.Pression,
                Humidite = meteoDb.Humidite,
                CreateAt = meteoDb.CreateAt
            };

   
        }

        public void UpdateMeteo (int id, float temperature, float pression, float humidite)
        {
            _demoDal.UpdateMeteo(id, temperature, pression, humidite, DateTime.Now.ToUniversalTime());

        }
    }
}

