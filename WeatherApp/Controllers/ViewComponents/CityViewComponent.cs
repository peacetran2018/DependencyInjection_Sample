using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WeatherApp.Controllers.ViewComponents
{
    public class CityViewComponent : ViewComponent
    {
        public CityViewComponent(){
            
        }

        public async Task<IViewComponentResult> InvokeAsync(WeatherModel weather){
            ViewBag.CSS = GetCssClassByFahrenheit(weather.Temperature);
            return View(weather);
        }

        public string GetCssClassByFahrenheit(int fahrenheit){
            return fahrenheit switch {
                (<= 44) => "blue-back",
                (> 44) and (<= 74) => "green-back",
                (> 74) => "orange-back"
            };
        }
    }
}