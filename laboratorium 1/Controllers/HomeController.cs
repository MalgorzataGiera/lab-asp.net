using laboratorium_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace laboratorium_1.Controllers
{
    public class HomeController : Controller
    {
        public enum Operators
        {
            ADD, SUB, MUL, DIV
        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About([FromQuery(Name = "app-author")]string author)
        {
            //string author = Request.Query["autthor"];
            ViewBag.Author = author;
            return View();
        }

        public IActionResult Calculator([FromQuery(Name = "app-op")]Operators op, double? x, double? y)
        {
            if(x == null || y == null)
            {
                return View("Error");  
            }
            switch (op)
            {
                case Operators.ADD:
                    ViewBag.Result = x + y;
                    break;
                case Operators.SUB:
                    ViewBag.Result = x - y;
                    break;
                case Operators.MUL:
                    ViewBag.Result = x * y;
                    break;
                case Operators.DIV:
                    ViewBag.Result = x / y;
                    break;
            }
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}