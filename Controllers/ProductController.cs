using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using apajaadastore.Models;
using apajaadastore.Services;

namespace apajaadastore.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductServices _service;

        public ProductController(ProductServices service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.GetAll());
        }

        public IActionResult Tambah()
        {
            var tambah = _service.AddProduct();
            return View();
        }
    }
}