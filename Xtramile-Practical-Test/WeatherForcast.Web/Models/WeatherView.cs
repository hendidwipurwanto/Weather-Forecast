namespace WeatherForcast.Web.Models
{
    public class WeatherView
    {
        public string Location { get; set; }
        public string Time { get; set; }

        public string Wind { get; set; }
        public string Visibility { get; set; }
        public string SkyCondition { get; set; }

        public string TemperaturInFahrenheit { get; set; }
        public double TemperaturInCelcius { get; set; }
        public double DefaultTemperature { get; set; }

        public string DewPoint { get; set; }

        public string RelativeHumidity { get; set; }
        public string Pressure { get; set; }
    }
}
