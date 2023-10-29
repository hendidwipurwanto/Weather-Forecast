using System.Threading.Tasks;
using WeatherForcast.Web.Models;

namespace WeatherForcast.Web.Repositories
{
    public interface IWeatherRepository
    {
       Task<WeatherView> GetWeatherByCity(string cityName);
    }
}
