using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LapTrinhQuanLyDb.Areas.Admins.Controllers
{
    public class HomeAdminController : Controller
    {
        [Authorize(Roles ="Admin")]
        // GET: Admins/HomeAdmin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}