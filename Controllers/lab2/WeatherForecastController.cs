using Lab1.Services.lab2;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers.lab2
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int Get(int value)
        {
            var calculateInstance = new Calculate(value);
            calculateInstance.Add(13);
            return calculateInstance.GetValue();

        }
    }
}