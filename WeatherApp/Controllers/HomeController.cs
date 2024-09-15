using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceContracts;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherService _weatherService;
        public HomeController(IWeatherService weatherService){
            _weatherService = weatherService;
        }

        [Route("/")]
        public IActionResult Index()
        {
            var citiesWeathere = _weatherService.GetWeathers();
            return View(citiesWeathere);
        }
        [Route("weather/{cityCode}")]
        public IActionResult CityDetails([FromRoute] string cityCode){
            var cityWeather = _weatherService.GetWeatherById(cityCode);
            
            return View(cityWeather);
        }
    }
}