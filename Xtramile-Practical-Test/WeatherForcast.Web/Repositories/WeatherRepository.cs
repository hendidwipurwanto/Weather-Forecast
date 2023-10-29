using Newtonsoft.Json;
using System.Net.Http;
using System;
using WeatherForcast.Web.Models;
using System.Threading.Tasks;
using System.Linq;

namespace WeatherForcast.Web.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        public async Task<WeatherView> GetWeatherByCity(string cityName)
        {
            var responseView = new WeatherView();
            var responseResult = new ResponseWeather();
            string apiUrl = "http://api.openweathermap.org/data/2.5/weather?q="+ cityName +"&appid=1e38491ca38eb68792fcb7a94a4e727e";

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

                    responseView.Location = responseResult.name;
                    responseView.Pressure =responseResult.main.pressure.ToString();
                    responseView.Time = DateTime.Now.ToString("dd-MM-yyyy hh: mm tt");
                    responseView.Visibility= responseResult.visibility.ToString();
                    responseView.SkyCondition = responseResult.weather.FirstOrDefault().main.ToString();
                    responseView.Wind = responseResult.wind.speed.ToString();
                    responseView.RelativeHumidity = responseResult.main.humidity.ToString();
                    responseView.DefaultTemperature = Convert.ToDouble(responseResult.main.temp);
                }
                return responseView;
            }
        }
    }
}