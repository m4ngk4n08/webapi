using System.Collections.Generic;

namespace api.Services.IServices
{
    public interface IWeatherForcastService
    {
        IEnumerable<WeatherForecast> Get();
    }
}
