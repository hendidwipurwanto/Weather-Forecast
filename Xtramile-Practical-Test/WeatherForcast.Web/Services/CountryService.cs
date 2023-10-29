using System.Collections.Generic;
using WeatherForcast.Web.Models;
using WeatherForcast.Web.Repositories;

namespace WeatherForcast.Web.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public List<Country> GetAllCountry()
        {
           return _countryRepository.GetAllCountry();
        }

        
    }
}
