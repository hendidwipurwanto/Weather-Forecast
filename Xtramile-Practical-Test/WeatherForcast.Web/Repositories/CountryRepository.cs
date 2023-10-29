using System.Collections.Generic;
using WeatherForcast.Web.Models;

namespace WeatherForcast.Web.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        public List<Country> GetAllCountry()
        {
            return PopulateCountry();
        }

        private List<Country> PopulateCountry()
        {
            var response = new List<Country>();
            var countryAus = new Country() { Id = 1, Name = "Australia", CountryCode = "aus" };
            response.Add(countryAus);
            var countryIdn = new Country() { Id = 2, Name = "Indonesia", CountryCode = "idn" };
            response.Add(countryIdn);
            var countrySg = new Country() { Id = 3, Name = "Singapore", CountryCode = "sg" };
            response.Add(countrySg);
            var countryMas = new Country() { Id = 4, Name = "Malaysia", CountryCode = "mas" };
            response.Add(countryMas);
            var countryThai = new Country() { Id = 5, Name = "Thailand", CountryCode = "thai" };
            response.Add(countryThai);

            return response;
        }

        
    }
}
