using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherForcast.Web.Services;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly IWeatherService _weatherService;
        public UnitTest1(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [TestMethod]
        public void Given_DefaultTemperatur_in_Kelvin_Convert_To_Celcius()
        {
            var result = _weatherService.ConvertDefaultOpenWeatherTempToCelcius(300);
            Assert.Equals(result, 26);
        }
    }
}
