using ExampleApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp.Domain.Interfaces
{
    public interface IWeatherService
    {
        Task<WeatherParams> GetWeather(string city);
    }
}
