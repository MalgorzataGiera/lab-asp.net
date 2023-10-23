using laboratorium_3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace laboratorium_3___App.Controllers
{
    public class ContactController : Controller
    {
        static Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
        static int index = 1;
        public IActionResult Index()
        {
            return View(_contacts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact model) 
        {
            if(ModelState.IsValid)
            {
                // zapisz obiekt do bazy/kolekcji albo wykonaj operację
                model.Id = index++;
                _contacts[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id) 
        {
            return View(_contacts[id]);
        }

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if(ModelState.IsValid)
            {
                _contacts[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_contacts[id]);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_contacts[id]);
        }
    }

    
}
