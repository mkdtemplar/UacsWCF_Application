using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UniversityApplication.Services;

namespace UniversityApplication.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private ILoggerManager _logger;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Info");
            _logger.LogDebug("debug");
            _logger.LogWarn("warn");
            _logger.LogError("error");
            return new string[] { "value1", "value2" };
        }
    }
}