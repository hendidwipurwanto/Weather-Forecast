using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherForcast.Web.Models;

namespace WeatherForcast.Web.Repositories
{
    public interface ICityRepository
    {
        List<City> GetCityByCountryCode(string countryCode);
        
        List<City> GetAllCity();
        Task<string> GetWeatherByCityName(string name);
    }
}
