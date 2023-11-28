using laboratorium_3___App.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Drawing;

namespace laboratorium_3___App.Controllers
{
    //[Authorize]
    public class ContactController : Controller
    {
        
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }

        public IActionResult PagedIndex(int? page = 1, int? size = 10)
        {
         
        }

        [HttpGet]
        public IActionResult Create()
        {
            Contact model = new Contact();
            model.Organizations = _contactService
                .FindAllOrganizationsForVieModel()
                .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Name})
                .ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Contact model) 
        {
            if(ModelState.IsValid)
            {
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult CreateApi()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateApi(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Update(int id) 
        {
            return View(_contactService.FindById(id));
        }

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if(ModelState.IsValid)
            {
                _contactService.Update(model);
                return RedirectToAction("Index");
            }
            return View(_contactService.FindById(model.Id));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_contactService.FindById(id + 1));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_contactService.FindById(id));
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _contactService.Delete(id);
            return RedirectToAction("Index");
        }


    }

    
}
