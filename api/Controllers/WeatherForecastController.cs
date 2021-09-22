using api.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForcastService _weatherForcastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, 
            IWeatherForcastService weatherForcastService)
        {
            _logger = logger;
            _weatherForcastService = weatherForcastService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {

            return _weatherForcastService.Get();
        }
    }
}
