using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using apajaadastore.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace apajaadastore.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApaAjaContext _context;

        public HomeController(ILogger<HomeController> logger, ApaAjaContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Authorize(Roles = "admin")]
        public IActionResult Index()
        {
            ViewData["username"] = User.FindFirst(ClaimTypes.Name).Value;
            int angka = 21;
            DateTime sekarang = DateTime.Now;

            //List<Users> users = new List<Users>
            //{
            //    new Users{ Id = new Guid(), Username = "admin", Password = "admin", Role = "admin" },
            //    new Users{ Id = new Guid(), Username = "user", Password = "user", Role = "user" }
            //};

            //foreach (var i in users)
            //{
            //    _context.Add(i);
            //}

            //_context.SaveChanges();

            return View();
        }

        [Authorize(Roles = "user")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
