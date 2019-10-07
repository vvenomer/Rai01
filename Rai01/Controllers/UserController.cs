﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rai01.Models;

namespace Rai01.Controllers
{
    public class UserController : Controller
    {

        public UserController()
        {
        }

        [Route("User/List")]
        public ActionResult Index()
        {
            return View(Startup.userDatabase.Select(u => u.Value));
        }

        public ActionResult Init()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Init(string users, string friends)
        {
            try
            {
                List<string> usersList = JsonConvert.DeserializeObject<List<string>>(users);
                List<Friend> friendsList = JsonConvert.DeserializeObject<List<Friend>>(friends);

                Startup.userDatabase = Startup.userDatabase.Concat(usersList.ToDictionary(
                    u => u,
                    u => new User
                    {
                        login = u,
                        createdTime = DateTime.Now
                    })).ToDictionary(u => u.Key, u => u.Value);
                Startup.friendDatabase = Startup.friendDatabase.Concat(friendsList).ToList();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

        }

        [Route("User/Add")]
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost("User/Add")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string login)
        {
            try
            {
                var user = new User
                {
                    login = login,
                    createdTime = DateTime.Now
                };
                Startup.userDatabase.Add(login, user);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(string login)
        {
            return View(Startup.userDatabase[login]);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string login)
        {
            try
            {
                Startup.userDatabase.Remove(login);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}