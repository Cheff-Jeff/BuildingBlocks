﻿using BusinessLayer;
using DataLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        User user = new User(new UserDAL());
        UserContainer userContainer = new UserContainer(new UserDAL());

        // GET: UserController
        public ActionResult Index()
        {
            UserViewModel userViewmodel = new UserViewModel();
            ListViewModel list = new ListViewModel();

            foreach (User user in userContainer.GetAllUsers())
            {
                userViewmodel = new UserViewModel(user.UserId, user.Email, user.IsAdmin);
                list.allusers.Add(userViewmodel);
            }

            return View(list.allusers);
        }

        // POST: UserController/Create
        //[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            UserViewModel userViewModel = new UserViewModel();
            if (ModelState.IsValid)
            {
                try
                {
                    byte[] salt = userContainer.AddSalt();
                    User us = new User(salt.ToString(), userViewModel.Email, userViewModel.Password, userViewModel.IsAdmin);
                    userContainer.UserRegister(us);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            UserViewModel userViewModel = new UserViewModel();
            userViewModel = FetchById(id);
            return View(userViewModel);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, UserViewModel userViewModel)
        {
            try
            {
                if(userViewModel.RePassword != userViewModel.Password)
                {
                    TempData["UserNotEdited"] = "Passwords do not match, user not created!";

                    return View("Edit");
                }
                else
                {
                    byte[] salt = userContainer.AddSalt();
                    var password = userContainer.hash(userViewModel.Password, salt);

                    User us = new User(Convert.ToBase64String(salt), id, userViewModel.Email, password, userViewModel.IsAdmin);
                    user.EditOneUser(us);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public IActionResult Delete(int id)
        {
            User us = new User(id);
            userContainer.DeleteOneAccount(us);

            return RedirectToAction(nameof(Index));
        }

        [NonAction]
        public UserViewModel FetchById(int id)
        {
            UserViewModel userViewModel = new UserViewModel();

            User user = userContainer.GetUserById(id);
            {
                userViewModel.UserId = user.UserId;
                userViewModel.Email = user.Email;
                userViewModel.Password = user.Password;
                userViewModel.IsAdmin = user.IsAdmin;
                userViewModel.Salt = user.Salt;
            }

            return userViewModel;
        }

        public IActionResult PdfEmployeeManager()
        {
            var desktop = new HtmlToPdf();
            desktop.Options.WebPageWidth = 1920;

            var pdf = desktop.ConvertUrl("https://localhost:44368/user/index");

            var pdfBytes = pdf.Save();

            return File(pdfBytes, "Application/pdf");
        }
    }
}
