using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface ICitiesService
    {
        Guid ServiceInstance {get;}
        List<string> GetCities();
    }
}