using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherForcast.Web.Models;

namespace WeatherForcast.Web.Repositories
{
    public class CityRepository : ICityRepository
    {
        public List<City> GetAllCity()
        {
            return PopulateCities();
        }

        public List<City> GetCityByCountryCode(string countryCode)
        {
           
            var cities = PopulateCities().Where(w=>w.CountryCode == countryCode).ToList();  
            return cities;
        }

        public async Task<string> GetWeatherByCityName(string name)
        {
            var responseResult = new ResponseWeather();
            string apiUrl = "http://api.openweathermap.org/data/2.5/weather?q=pasuruan&units=imperial&appid=1e38491ca38eb68792fcb7a94a4e727e";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();

                    responseResult = JsonConvert.DeserializeObject<ResponseWeather>(data);
                    
                }



                return null;

            }
        }

        private List<City> PopulateCities()
        {
            var response = new List<City>();

            var cityAus1 = new City() { Id = 1, CountryCode = "aus", Name = "Brisbane" };
            response.Add(cityAus1);
            var cityAus2 = new City() { Id = 2, CountryCode = "aus", Name = "Melbourne" };
            response.Add(cityAus2);
            var cityAus3 = new City() { Id = 3, CountryCode = "aus", Name = "Sydney" };
            response.Add(cityAus3);
            var cityIdn1 = new City() { Id = 1, CountryCode = "idn", Name = "Jakarta" };
            response.Add(cityIdn1);
            var cityIdn2 = new City() { Id = 2, CountryCode = "idn", Name = "Surabaya" };
            response.Add(cityIdn2);
            var cityIdn3 = new City() { Id = 3, CountryCode = "idn", Name = "Bali" };
            response.Add(cityIdn3);
            return response;
        }
    }
}
