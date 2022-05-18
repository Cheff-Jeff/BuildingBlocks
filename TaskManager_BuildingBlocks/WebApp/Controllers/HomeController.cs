using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.Controllers;
using BusinessLayer;
using DataLayer;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[HttpPost]
        public IActionResult Post([FromQuery] string Name, int SystemId, int Value)
        {
            //process the form data
            try
            {
                MetricContainer mc = new MetricContainer(new MetricDAL());
                mc.CreateMetric(new NewMetric(Name, SystemId, Value, DateTime.Now));
                return Ok("Added successfully");
            }
            catch
            {
                return Ok("Not Succesfull");
            }
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel user)
        {
            return View();        
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
