using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase2_Practica.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<WeatherForecast> ForecastList = new List<WeatherForecast>();

        private static string[] Summaries = new string[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public IEnumerable<WeatherForecast> Post(WeatherForecast weatherForecast)
        {
            ForecastList.Add(weatherForecast);
            return ForecastList;
        }

        [HttpDelete]
        public IEnumerable<WeatherForecast> Delete(DateTime weatherForecastDate)
        {
            ForecastList.RemoveAll(x => x.Date == weatherForecastDate);

            #region Opcion Legacy
            //Opcion Legacy
            //WeatherForecast itemABorrar = null;
            //foreach (var weatherForecast in ForecastList)
            //{
            //    if (weatherForecast.Date == weatherForecastDate)
            //    {
            //        itemABorrar = weatherForecast; 
            //    }
            //}
            //if (itemABorrar != null)
            //{
            //    ForecastList.Remove(itemABorrar);
            //}
            #endregion

            return ForecastList;
        }
    }
}
