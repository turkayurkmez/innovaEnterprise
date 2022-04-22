using CQRSPattern.CQRS.Commands;
using CQRSPattern.CQRS.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRSPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private CreateProductCommandHandler handler;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, CreateProductCommandHandler handler)
        {
            _logger = logger;
            this.handler = handler;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost]
        public IActionResult Add(CreateProductRequestCommand command)
        {
           var commandResponse =  handler.ExecuteCommand(command);
            if (commandResponse.IsSuccess)
            {
                return Created("http://myResource/created", null);
            }
            
            return BadRequest(ModelState);
        }
    }
}