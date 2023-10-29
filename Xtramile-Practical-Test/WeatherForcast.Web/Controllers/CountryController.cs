using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WeatherForcast.Web.Models;
using WeatherForcast.Web.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WeatherForcast.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;
        private readonly ICityService _cityService;
        public CountryController(ICountryService countryService, ICityService cityService)
        {
            _countryService = countryService;
            _cityService = cityService;
        }
        // GET: api/<CountryController>
        [HttpGet("GetAllCountry")]
        public async Task<IActionResult> GetAllCountry()
        {
            var response = _countryService.GetAllCountry();

                return Ok(response);
            
        }

        [HttpGet("GetCityByCountryCode")]
        public IActionResult GetCityByCountryCode(string countrycode)
        {
            var response = _cityService.GetCityByCountryCode(countrycode);
            return Ok(response);

        }

        // GET api/<CountryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CountryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CountryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CountryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
