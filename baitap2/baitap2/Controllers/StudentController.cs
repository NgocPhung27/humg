using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baitap2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetInfo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetInfo( string hoten, string tuoi, string lop)
        {
            ViewBag.hoten = hoten;
            ViewBag.tuoi = tuoi;
            ViewBag.lop = lop;
            return View();
        }
}
}