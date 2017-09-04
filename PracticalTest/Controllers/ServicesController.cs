using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticalTest.Models;

namespace PracticalTest.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataAccess _db;

        public ServicesController(DataAccess db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var services = _db.Service.ToList();
            return View(services);
        }
    }
}