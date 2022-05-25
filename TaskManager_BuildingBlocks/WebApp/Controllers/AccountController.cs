using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataLayer;
using BusinessLayer;
using WebApp.Models;
using System;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("isAdmin") != null)
            {
                ViewBag.succes = TempData["seccesss"];
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetInt32("isAdmin") != null)
            {
                HttpContext.Session.Remove("isAdmin");
                return RedirectToAction("Index", "Account");
            }
            return RedirectToAction("Index", "Account");
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
                UserContainer userContainer = new UserContainer(new UserDAL());

                byte[] salt = userContainer.AddSalt();
                string Email = user.Email.ToLower();
                var Password = userContainer.hash(user.Password, salt);

                if (!userContainer.CheckUserExists(user.Email.ToLower()))
                {
                    userContainer.UserRegister(new User(Convert.ToBase64String(salt), user.Email, Password, user.IsAdmin));
                    TempData["seccesss"] = "New user has been added.";
                    return RedirectToAction("Index", "Account");
                }
                else
                {
                    ViewBag.error = "There already exists a user with this email.";
                    return View();
                }
            }
            return View();
        }
    }
}
