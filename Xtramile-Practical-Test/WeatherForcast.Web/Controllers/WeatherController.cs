using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WeatherForcast.Web.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WeatherForcast.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

    
        // GET: api/<WeatherController>
        [HttpGet("GetWeatherByCity")]
        public async Task<IActionResult> GetWeatherByCity(string cityName)
        {
            var response = await _weatherService.GetWeatherByCity(cityName);
            return Ok(response);
        }

        // GET api/<WeatherController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WeatherController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WeatherController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WeatherController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
