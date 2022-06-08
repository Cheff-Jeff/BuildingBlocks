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
        private ServerContainer serverContainer = new ServerContainer(new ServerDAL());

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            if (HttpContext.Session.GetInt32("isAdmin") != null)
            {
                return RedirectToAction("Index", "Server");
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Post([FromQuery] string Name, int SystemId, int Value)
        {
            RuleContainer ruleContainer = new RuleContainer(new RuleDal());
            AutoEmail autoEmail = new AutoEmail();
            //process the query data
            try
            {
                MetricContainer mc = new MetricContainer(new MetricDAL());
                mc.CreateMetric(new NewMetric(Name, SystemId, Value, DateTime.Now));

                Rule rule = ruleContainer.GetRuleFromSystem(SystemId);

                if((rule.Min > Value) && (Value < rule.Max))
                {
                    autoEmail.send_mail(rule.NotifyEmail, ser.ServerName, Name+" gaat " + (rule.Min - Value) + " onder minimum!");
                }
                if (rule.Max < Value)
                {
                    autoEmail.send_mail(rule.NotifyEmail, ser.ServerName, Name+" gaat " + (Value - rule.Max) + " boven maximum!");
                }
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

                    if (!loginChecker) { ViewBag.error = "Your password or email was incorrect."; return View(); }
                    else
                    {
                        User user = userContainer.GetUserByEmail(loginData.Email);
                        CurrentUser.useremail = user.Email;
                        CurrentUser.userpassword = user.Password;
                        CurrentUser.usersalt = user.Salt;
                        CurrentUser.isadmin = user.IsAdmin;
                        if (CurrentUser.isadmin)
                        {
                            HttpContext.Session.SetInt32("isAdmin", 1);
                        }
                        else
                        {
                            HttpContext.Session.SetInt32("isAdmin", 0);
                        }
                        return RedirectToAction("Home", "Home");
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
