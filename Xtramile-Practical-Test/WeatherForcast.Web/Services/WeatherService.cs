using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WeatherForcast.Web.Models;
using WeatherForcast.Web.Repositories;

namespace WeatherForcast.Web.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository _weatherRepository;
        public WeatherService(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        public double ConvertDefaultOpenWeatherTempToCelcius(double temp)
        {
            // fyi: the default is Kelvin
            // this is the formula  C = K - 273.15
                
            double celcius = Math.Ceiling( temp-273.15);
            return celcius;
        }

        public async Task<WeatherView> GetWeatherByCity(string cityName)
        {
            var result = await _weatherRepository.GetWeatherByCity(cityName);
            result.TemperaturInCelcius = ConvertDefaultOpenWeatherTempToCelcius(result.DefaultTemperature);

            return result;
        }

        
    }
}
