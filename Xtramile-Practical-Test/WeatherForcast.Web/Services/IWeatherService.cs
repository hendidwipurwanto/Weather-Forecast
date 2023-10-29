using System.Threading.Tasks;
using WeatherForcast.Web.Models;

namespace WeatherForcast.Web.Services
{
    public interface IWeatherService
    {
        Task<WeatherView> GetWeatherByCity(string cityName);
        double ConvertDefaultOpenWeatherTempToCelcius(double temp);
        
    }
}
