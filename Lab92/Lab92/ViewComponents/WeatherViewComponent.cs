using Lab92.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace YourAppName.ViewComponents
{
    public class WeatherViewComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public WeatherViewComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(string city)
        {
            var apiKey = "7512e2de25ebd08c7786b83dbf06fb32";
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";
            var client = _httpClientFactory.CreateClient();

            var response = await client.GetStringAsync(url);
            var weatherForecast = JsonConvert.DeserializeObject<WeatherForecast>(response);

            return View(weatherForecast);
        }
    }
}
