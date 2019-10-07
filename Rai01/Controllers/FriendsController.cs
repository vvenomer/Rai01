using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rai01.Models;

namespace Rai01.Controllers
{
    public class FriendsController : Controller
    {
        // GET: Friends
        public ActionResult Index()
        {
            try
            {
                var login = GetUser();
                var friends = GetFriends(login);
                return View(friends);
            }
            catch
            {
                return BadRequest("You hava to log in before you can access this page");
            }
        }

        public IEnumerable<string> List()
        {
            try
            {
                var login = GetUser();
                return GetFriends(login);
            }
            catch
            {
                return new List<string>();
            }
        }

        [HttpPost("Friends/Add/{login}")]
        public bool Add(string login)
        {
            try
            {
                var myLogin = GetUser();
                if (CheckIfFriend(myLogin, login))
                    throw new Exception();
                if (!Startup.userDatabase.ContainsKey(login))
                    throw new Exception();

                Startup.friendDatabase.Add(new Friend { Friend1 = myLogin, Friend2 = login });
                return true;
            }
            catch
            {
                return false;
            }
        }

        // POST: Friends/Delete/5
        [HttpPost("Friends/Del/{friendLogin}")]
        public bool Delete(string friendLogin)
        {
            try
            {
                // TODO: Add delete logic here
                var myLogin = GetUser();
                var friend = GetFriendship(myLogin, friendLogin);
                Startup.friendDatabase.Remove(friend);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public ActionResult Export()
        {
            var cd = new ContentDisposition
            {
                FileName = "friendList.json",
                Inline = false
            };
            Response.Headers.Add("Content-Disposition", cd.ToString());
            try
            {
                return Json(GetFriends(GetUser()));
            }
            catch
            {
                return Json(new List<string>());
            }
        }

        [HttpPost]
        public ActionResult Import(IFormFile file)
        {
            var friends = JsonConvert.DeserializeObject<List<string>>(new StreamReader(file.OpenReadStream()).ReadToEnd());
            try
            {
                var user = GetUser();
                GetFriendships(user).ToList().ForEach(friendship =>
                {
                    Startup.friendDatabase.Remove(friendship);
                });
                friends.ForEach(friend =>
                {
                    Startup.friendDatabase.Add(new Friend() { Friend1 = user, Friend2 = friend });
                });
            }
            catch
            {
                return View();
            }

            return RedirectToAction(nameof(Index));
        }

        private string GetUser()
        {
            if (HttpContext.Session.TryGetValue("login", out byte[] value))
                return HttpContext.Session.GetString("login");
            throw new Exception();
        }
        private bool CheckIfFriend(string login1, string login2)
        {
            if (GetFriends(login1).Contains(login2))
            {
                return true;
            }
            return false;
        }

        private IEnumerable<string> GetFriends(string login)
        {
            return Startup.friendDatabase.
                    Where(f => f.Friend1 == login).Select(f => f.Friend2).
                    Concat(
                        Startup.friendDatabase.
                        Where(f => f.Friend2 == login).Select(f => f.Friend1)
                        );
        }
        private Friend GetFriendship(string login1, string login2)
        {
            return GetFriendships(login1).
                    FirstOrDefault(f => f.Friend1 == login2 || f.Friend2 == login2);
        }
        private IEnumerable<Friend> GetFriendships(string login1)
        {
            return Startup.friendDatabase.
                    Where(f => f.Friend1 == login1).Concat(Startup.friendDatabase.
                    Where(f => f.Friend2 == login1));
        }
    }
}