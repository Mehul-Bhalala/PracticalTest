using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticalTest.Models;
using Microsoft.EntityFrameworkCore;

namespace PracticalTest.Controllers
{
    public class UserController : Controller
    {
        private readonly DataAccess _db;

        public UserController(DataAccess db)
        {
            _db = db;
        }
        // GET: User
        [Route("Users/list")]
        public ActionResult Index()
        {
            var users=_db.User.ToList();
            return View(users);
        }


        // GET: User/Create
        [Route("Users/Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            try
            {
                user.CreateDate=DateTime.Today;
                _db.Add(user);
                _db.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: User/Edit/5
        [Route("Users/{UserId:long}/Services")]
        public ActionResult Services(int UserId)
        {
            var services = _db.Service.Where(service => service.UserServices.Any(us => us.UserId == UserId)).ToList();
            return View(services);
        }

        
    }
}