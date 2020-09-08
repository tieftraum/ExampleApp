using ExampleApp.Domain.Interfaces;
using ExampleApp.Domain.Models;
using ExampleApp.Infrastructure.Clients;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ExampleApp.Infrastructure.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly WeatherApiClient _weatherClient;

        public WeatherService(WeatherApiClient client)
        {
            _weatherClient = client;
        }

        public async Task<WeatherParams> GetWeather(string city)
        {
            return await _weatherClient.Client.GetFromJsonAsync<WeatherParams>($"weather?q={city}&appid={_weatherClient.ApiKey}");
        }
    }
}
