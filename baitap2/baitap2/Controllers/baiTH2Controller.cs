using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using baitap2.Models;

namespace baitap2.Controllers
{
    public class baiTH2Controller : Controller
    {
        giai_phuong_trinh gpt = new giai_phuong_trinh();
        // GET: baiTH2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GiaiPTB1()
        {
            return View();
        }
        [HttpPost]

        public ActionResult GiaiPTB1(double hesoA, double hesoB)

        {
            double x = gpt.GiaiPhuongTrinhBacNhat(hesoA, hesoB);

            ViewBag.nghiemPT=x;

            return View();

        }
    }
}