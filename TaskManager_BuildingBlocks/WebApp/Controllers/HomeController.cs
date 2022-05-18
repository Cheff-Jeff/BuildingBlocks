using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using DataLayer;
using BusinessLayer;
using WebApp.Controllers;
using Microsoft.AspNetCore.Http;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UserContainer userContainer = new UserContainer(new UserDAL());

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

        [HttpPost]
        public IActionResult Post([FromQuery] string Name, int SystemId, int Value)
        {
            //process the query data
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
        public IActionResult Index(LoginViewModel loginData)
        {
            if (ModelState.IsValid)
            {
                if (userContainer.CheckUserExists(loginData.Email))
                {
                    bool loginChecker = userContainer.VerifyPassword(loginData.Email, loginData.Password);

                    if (!loginChecker) { ViewBag.error = "You're password or email was incorrect."; return View(); }
                    else
                    {
                        HttpContext.Session.SetInt32("isAdmin", 1);
                        return RedirectToAction("Privacy", "Home");
                    }
                }
                else { ViewBag.error = "There is no user with this email."; return View(); }
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
