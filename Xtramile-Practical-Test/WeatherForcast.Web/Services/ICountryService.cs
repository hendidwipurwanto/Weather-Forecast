using System.Collections.Generic;
using WeatherForcast.Web.Models;

namespace WeatherForcast.Web.Services
{
    public interface ICountryService
    {
        List<Country> GetAllCountry();
    }
}
