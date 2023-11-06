using laboratorium_3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace laboratorium_3___App.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservations;

        public ReservationController(IReservationService reservations)
        {
            _reservations = reservations;
        }

        public IActionResult Index()
        {
            return View(_reservations.FindAll());
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
                _reservations.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_reservations.FindById(id));
        }

        [HttpPost]
        public IActionResult Update(Reservation model)
        {
            if (ModelState.IsValid)
            {
                _reservations.Update(model);               
                return RedirectToAction("Index");
            }
            return View(_reservations.FindById(model.Id));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_reservations.FindById(id));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_reservations.FindById(id));
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _reservations.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
