using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LapTrinhQuanLyDb.Models;

namespace LapTrinhQuanLyDb.Controllers
{
    public class EmpNewController : Controller
    {
        LTQLDbContext db = new LTQLDbContext();
        AutoGenerateKey genKey = new AutoGenerateKey();
        // GET: EmpNew
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }
        public ActionResult Create()
        {
            var empID = "";
            var countEmployee = db.Employees.Count();
            if (countEmployee == 0)
            {
                empID = "EMP001";
            }
            else
            {
                //Lấy giá trị PersonID moi nhat
                var PersonID = db.Employees.ToList().OrderByDescending(m => m.PersonID).FirstOrDefault().PersonID;
                //sinh PersonID tự dộng
                empID = genKey.Generatekey(PersonID);
            }
            ViewBag.PersonID = empID;
                return View();
        }
        [HttpPost]
        public ActionResult Create (Employee emp)
            
        {
           var countEmployee = db.Employees.Count();
            if (countEmployee == 0)
            {
                emp.PersonID = "EMP001";
            }
            else
            {
                //Lấy giá trị PersonID moi nhat
                var PersonID = db.Employees.ToList().OrderByDescending(m => m.PersonID).FirstOrDefault().PersonID;
                //sinh PersonID tự dộng
                emp.PersonID = genKey.Generatekey(PersonID);
            }
            //luu thông tin vao database
            db.Employees.Add(emp);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}