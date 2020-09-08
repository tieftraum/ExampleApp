using ExampleApp.Domain.Helpers.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace ExampleApp.Infrastructure.Clients
{
    public class WeatherApiClient
    {
        public readonly HttpClient Client;
        private readonly IConfiguration _configuration;
        private readonly IConfigurationSection _section;
        public string ApiKey { get; private set; }
        public WeatherApiClient(HttpClient client, IConfiguration configuration)
        {
            _configuration = configuration;
            _section = _configuration.GetSection(nameof(WeatherApi));
            Client = client;
            Client.BaseAddress = new Uri(_section[nameof(WeatherApi.BaseUrl)]);
            Client.Timeout = new TimeSpan(0, 0, 30);
            ApiKey = _section[nameof(WeatherApi.Key)];
        }
    }
}
