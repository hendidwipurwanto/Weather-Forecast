using Microsoft.AspNetCore.Mvc;
using WeatherForcast.Web.Repositories;
using WeatherForcast.Web.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WeatherForcast.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;
        public CityController(ICityService cityService)
        {
            _cityService= cityService;
        }


        [HttpGet("GetAllCity")]
        public IActionResult GetCity()
        {
          

            return Ok(1);
        }
        [HttpGet("GetCityByCountryCode")]
        public IActionResult GetCityByCountryCode(string code)
        {
            var response = _cityService.GetCityByCountryCode(code);

            return Ok(response);
        }


        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
