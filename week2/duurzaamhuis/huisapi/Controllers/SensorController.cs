using Microsoft.AspNetCore.Mvc;
using huisapi.Models;

namespace huisapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SensorController : ControllerBase
{
    private readonly ILogger<SensorController> _logger;

    public SensorController(ILogger<SensorController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSensorData")]
        public SensorData Get()
        {
            return new SensorData
            {
                Ldr = 100,
                Dht = new Dht
                {
                    Temperature = 25,
                    Humidity = 11,
                    HeatIndex = 6
                }
            };
        }
    }
}
