using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using apajaadastore.Models;

namespace apajaadastore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}