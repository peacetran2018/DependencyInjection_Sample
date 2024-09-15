using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceContracts;
using Services;

namespace DependencyInjection_Web.Controllers
{
    public class HomeController : Controller
    {
        //private readonly CitiesService _citiesService; 
        private readonly ICitiesService _citiesService1;
        private readonly ICitiesService _citiesService2;
        private readonly ICitiesService _citiesService3;
        //in case this service is not develop yet then controller need to wait

        //contructor
        public HomeController(ICitiesService citiesService1,ICitiesService citiesService2,ICitiesService citiesService3){
            //create object of citiesservice class
            _citiesService1 = citiesService1;//new CitiesService();
            _citiesService2 = citiesService2;
            _citiesService3 = citiesService3;
        }    
        
        [Route("/")]
        public IActionResult Index()
        {
            List<string> cities = _citiesService1.GetCities();
            ViewBag.InstanceId_CitiesService1 = _citiesService1.ServiceInstance;
            ViewBag.InstanceId_CitiesService2 = _citiesService2.ServiceInstance;
            ViewBag.InstanceId_CitiesService3 = _citiesService3.ServiceInstance;
            return View(cities);
        }
    }
}