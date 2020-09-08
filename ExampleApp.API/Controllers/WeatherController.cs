using ExampleApp.Domain.Interfaces;
using ExampleApp.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExampleApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _service;
        public WeatherController(IWeatherService service)
        {
            _service = service;
        }

        [HttpGet("{city}", Name = "Get Weather")]
        public async Task<ActionResult<WeatherParams>> Get(string city)
        {
            if (city == null)
            {
                return NotFound();
            }

            return await _service.GetWeather(city);
        }
    }
}
