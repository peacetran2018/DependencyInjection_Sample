using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceContracts;
using Models;

namespace Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IEnumerable<WeatherModel> _Weathers;
        public WeatherService(){
            _Weathers = new List<WeatherModel>()
            {
                new WeatherModel(){ CityUniqueCode = "VN", CityName = "Vietnam", DateAndTime = DateTime.Now, Temperature= 40 },
                new WeatherModel(){ CityUniqueCode = "SG", CityName = "Singapore", DateAndTime = DateTime.Now, Temperature= 60 },
                new WeatherModel(){ CityUniqueCode = "AU", CityName = "Australia", DateAndTime = DateTime.Now, Temperature= 80 }
            };
        }

        public WeatherModel? GetWeatherById(string id)
        {
            var weather = _Weathers.FirstOrDefault(x => x.CityUniqueCode == id);
            return weather;
        }

        public IEnumerable<WeatherModel> GetWeathers()
        {
            return _Weathers;
        }
    }
}