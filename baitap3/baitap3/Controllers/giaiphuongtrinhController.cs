using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using baitap3.Models;

namespace baitap3.Controllers
{
    public class giaiphuongtrinhController : Controller
    {
        giaiphuongbac1 gpt = new giaiphuongbac1();
        // GET: giaiphuongtrinh
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GPT()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GPT(double hesoA, double hesoB)
        {
            double x = gpt.GiaiPhuongTrinhBacNhat(hesoA, hesoB);
            ViewBag.nghiemPT = x;
            return View();
        }
    }
}