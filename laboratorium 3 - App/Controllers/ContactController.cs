using laboratorium_3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace laboratorium_3___App.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        //static Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
        
        static int index = 1;
        public IActionResult Index()
        {
            return View(_contactService.FindAll());
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
                //model.Id = index++;
                //_contacts[model.Id] = model;
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        //[HttpGet]
        //public IActionResult Update(int id) 
        //{
        //    return View(_contacts[id]);
        //}

        //[HttpPost]
        //public IActionResult Update(Contact model)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        _contacts[model.Id] = model;
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult Details(int id)
        //{
        //    return View(_contacts[id]);
        //}

        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    return View(_contacts[id]);
        //}
    }

    
}
