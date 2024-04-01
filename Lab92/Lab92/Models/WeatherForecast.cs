using Newtonsoft.Json;

namespace Lab92.Models
{
    public class WeatherForecast
    {
        public TemperatureInfo Main { get; set; }
        public string Name { get; set; }
    }

    public class TemperatureInfo
    {
        [JsonProperty("temp")]
        public float Temp { get; set; }
    }
}
