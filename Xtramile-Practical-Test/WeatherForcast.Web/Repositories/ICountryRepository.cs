using System.Collections.Generic;
using WeatherForcast.Web.Models;

namespace WeatherForcast.Web.Repositories
{
    public interface ICountryRepository
    {
        List<Country> GetAllCountry();

    }
}
