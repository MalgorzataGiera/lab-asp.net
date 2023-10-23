using laboratorium_3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace laboratorium_3___App.Controllers
{
    public class ReservationController : Controller
    {
        static Dictionary<int, Reservation> _reservations = new Dictionary<int, Reservation>();
        static int index = 1;
        public IActionResult Index()
        {
            return View(_reservations);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Reservation model)
        {
            if (ModelState.IsValid)
            {
                // zapisz obiekt do bazy/kolekcji albo wykonaj operację
                model.Id = index++;
                _reservations[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }

        
    }
}
