using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace ServiceContracts
{
    public interface IWeatherService
    {
        public IEnumerable<WeatherModel> GetWeathers();
        public WeatherModel? GetWeatherById(string id);
    }
}