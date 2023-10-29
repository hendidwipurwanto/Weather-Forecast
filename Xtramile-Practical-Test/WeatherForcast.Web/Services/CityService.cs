using System.Collections.Generic;
using WeatherForcast.Web.Models;
using WeatherForcast.Web.Repositories;

namespace WeatherForcast.Web.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public List<City> GetAllCities()
        {
            return _cityRepository.GetAllCity();
        }

        public List<City> GetCityByCountryCode(string countryCode)
        {
            return _cityRepository.GetCityByCountryCode(countryCode);
        }
    }
}
