﻿using BusinessLayer;
using DataLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            UserViewModel list = new UserViewModel();

            foreach (User user in userContainer.GetAllUsers())
            {
                userViewmodel = new UserViewModel(user.UserId, user.Email, user.IsAdmin);
                list.listusers.Add(userViewmodel);
            }

            userViewmodel.listusers = list.listusers;
            return View(userViewmodel);
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
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            UserViewModel userViewModel = new UserViewModel();
            try
            {
                byte[] salt = userContainer.AddSalt();

                User us = new User(salt.ToString(), userViewModel.UserId, userViewModel.Email, userViewModel.Password, userViewModel.IsAdmin);
                user.EditOneUser(us);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
