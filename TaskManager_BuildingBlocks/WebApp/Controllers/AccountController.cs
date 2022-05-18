using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataLayer;
using BusinessLayer;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("isAdmin") != null)
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register() 
        {
            if (HttpContext.Session.GetInt32("isAdmin") != null && HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                return View();
            }
            return RedirectToAction("Index", "Account");
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel user)
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
    }
}
