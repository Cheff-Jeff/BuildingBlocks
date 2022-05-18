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
        public IActionResult Login(LoginViewModel user)
        {
            if (ModelState.IsValid)
            {
                Login handler = new Login(new LoginDAL());
                Login loginData = new Login(user.Email);
                if (handler.LoginUserCheck(loginData))
                {
                    Login loginData1 = new Login(user.Email);
                    handler.GetUserByEmail(loginData1);
                    bool loginChecker = handler.VerifyPassword(user.Password, Login.usersalt, Login.userpassword);
                    if (!loginChecker)
                    {
                        ViewBag.error = "You're password or email was incorrect.";
                        return View();
                    }
                    else
                    {
                        HttpContext.Session.SetInt32("isAdmin", 1);
                        return RedirectToAction("Privacy", "Home");
                    }
                }
                else 
                {
                    ViewBag.error = "There is no user with this email.";
                    return View();
                }
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
