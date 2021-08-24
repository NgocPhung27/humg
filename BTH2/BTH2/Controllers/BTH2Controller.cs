using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTH2.Models;

namespace BTH2.Controllers
{
    public class BTH2Controller : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        // GET: BTTH2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GiaiPTB1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GiaiPTB1( double hesoA, double hesoB)
        {
            double x = gpt.GiaiPhuongTrinhBacNhat(hesoA, hesoB);
            ViewBag.nghiemPT = x;
            return View();

        }

    }
}