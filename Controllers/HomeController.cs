using System.Dynamic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnet_mvc_web.Models;

namespace dotnet_mvc_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            dynamic data = new ExpandoObject();
            data.Id = 1;
            data.Name = "Thanh.NTH";
            ViewBag.Data = data;
            ViewBag.Type = new BookModel() { Id = 5, Author = "Michiokaku", Title = "The world"};
            return View();
        }

        public ViewResult AboutUs() 
        {
            return View(); 
            // View() method is used when action name is equal view name
        }

        public ViewResult ContactUs()
        {
            return View();
        }

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
