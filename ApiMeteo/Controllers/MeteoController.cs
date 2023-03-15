using ApiMeteo.Models.Business;
using Microsoft.AspNetCore.Mvc;

namespace ApiMeteo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeteoController : ControllerBase
    {
        private readonly MeteoBL _demoBl;
        public MeteoController(MeteoBL demoBL)
        {
            _demoBl = demoBL;
        }

        //Requête Get qui va récupérer et afficher les différentes sondes
        [HttpGet]
        [Route("sonde/{id}")]
        public IActionResult GetSonde(int id)
        {
            var sonde = _demoBl.GetSonde(id);

            return Ok(sonde);
        }

        //Requête Get qui va récupérer et afficher les différentes données météorologiques
        [HttpGet]
        [Route("meteo/{id}")]
        public IActionResult GetMeteo(int id)
        {
            var meteo = _demoBl.GetMeteo(id);

            return Ok(meteo);
        }

        //Requête Put qui va mettre à jour les différentes données météorologiques dans le Pi Pico W
        [HttpPut]
        [Route("meteo/{id}")]
        public IActionResult UpdateMeteo(int id, float temperature, float pression, float humidite)
        {
          _demoBl.UpdateMeteo(id, temperature, pression, humidite);

            return Ok();
        }
    }
}
