using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTDb.Models;

namespace BTDb.Controllers
{
  
    public class PersonController : Controller
    {
        LTQLDbContext db = new LTQLDbContext();

        // GET: Person
        public ActionResult Index()
        {
            var model = db.Persons.ToList(); 
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person std)
        {
            if(ModelState.IsValid)
            {
                db.Persons.Add(std);
                db.SaveChanges();
                return RedirectToAction("Index");
            }    
            return View();
        }
    }
}