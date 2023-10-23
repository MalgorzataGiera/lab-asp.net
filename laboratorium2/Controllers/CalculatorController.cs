using laboratorium2.Models;
using Microsoft.AspNetCore.Mvc;

namespace laboratorium2.Controllers
{
    //public enum Operators
    //{
    //    ADD, SUB, MUL, DIV
    //}

    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        //public IActionResult Result([FromQuery(Name = "app-op")] Operators? op, double? x, double? y)
        //{
        //    if (x == null || y == null)
        //    {
        //        return View("Error");
        //    }
        //    switch (op)
        //    {
        //        case Operators.ADD:
        //            ViewBag.Result = x + y;
        //            break;
        //        case Operators.SUB:
        //            ViewBag.Result = x - y;
        //            break;
        //        case Operators.MUL:
        //            ViewBag.Result = x * y;
        //            break;
        //        case Operators.DIV:
        //            ViewBag.Result = x / y;
        //            break;
        //    }

        //    return View();
        //}

        [HttpPost]
        public IActionResult Result(Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
    }
}
