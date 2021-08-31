using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using baitap2.Models;

namespace baitap2.Controllers
{
    public class giaiphuongtrinhController : Controller
    {
        giai_phuong_trinh gpt = new giai_phuong_trinh();
        // GET: giaiphuongtrinh
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(double hesoA, double hesoB)
        {
            double x = gpt.GiaiPhuongTrinhBacNhat(hesoA, hesoB);
            ViewBag.nghiemPT = x;
            return View();
        }
    }
}