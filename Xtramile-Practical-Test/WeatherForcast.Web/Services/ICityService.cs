using System.Collections.Generic;
using WeatherForcast.Web.Models;

namespace WeatherForcast.Web.Services
{
    public interface ICityService
    {
        List<City> GetAllCities();
        List<City> GetCityByCountryCode(string countryCode);
    }
}
