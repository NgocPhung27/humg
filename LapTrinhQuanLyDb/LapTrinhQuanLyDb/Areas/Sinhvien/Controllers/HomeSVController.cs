using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LapTrinhQuanLyDb.Areas.Sinhvien.Controllers
{

    [Authorize(Roles = "SV")]
    public class HomeSVController : Controller
    {
        // GET: Sinhvien/HomeSV
        public ActionResult Index()
        {
            return View();
        }
    }
}