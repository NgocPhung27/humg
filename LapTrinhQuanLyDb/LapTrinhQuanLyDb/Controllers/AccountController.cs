using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using LapTrinhQuanLyDb.Models;

namespace LapTrinhQuanLyDb.Controllers
{
    public class AccountController : Controller
    {
        Encrytion encry = new Encrytion();
        LTQLDbContext db = new LTQLDbContext();
        AutoGenerateKey strPro = new AutoGenerateKey();
        // GET: Accont
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Register(Account acc)
        {
            if (ModelState.IsValid)
            {
                //mã hóa mật khẩu trước khi lưu vào database
                acc.Password = encry.PasswordEncrytion(acc.Password);
                db.Accounts.Add(acc);
                db.SaveChanges();
                return RedirectToAction("Login", "Account");
            }
            return View(acc);
        }
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            if (CheckSesion() == 1)
            {
                return RedirectToAction("Index", "Home_Ad", new { Are = "Admins" });
            }
            else if (CheckSesion() == 2)
            {
                return RedirectToAction("Index", "Home_Le", new { Are = "SVs" });
            }
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(Account acc, string returnUrl)
        {
            try
            {
                if (!string.IsNullOrEmpty(acc.UserName) && !string.IsNullOrEmpty(acc.Password))
                {
                    using (var db = new LTQLDbContext()) ;
                    {
                        var passToMD5 =strPro.GetMD5(acc.Password);
                        var account = db.Accounts.Where(m => m.UserName.Equals(acc.UserName) && m.Password.Equals(passToMD5)).Count();
                        if (account == 1)
                        {
                            FormsAuthentication.SetAuthCookie(acc.UserName, false);
                            Session["idUser"] = acc.UserName;
                            Session["roleUser"] = acc.RoleID;
                            return RedirectToLocal(returnUrl);
                        }
                        ModelState.AddModelError("", "thông tin đăng nhập chưa chính xác");
                    }
                }
                ModelState.AddModelError("", "UserName hoặc Password chưa chính xác");
            }
            catch
            {
                ModelState.AddModelError("", "hệ thống đnag bảo trì, vui lòng liên hệ với quản trị viên");
            }
            return View(acc);
        } 
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        //kiểm tra ng dùng đăng nhập với quyền là gì
     private int CheckSesion()
        {
            using(var db = new LTQLDbContext())
            {
                var user = HttpContext.Session["idUser"];
                if ( user != null)
                {
                    var role = db.Accounts.Find(user.ToString()).RoleID;
                    if( role != null)
                    {
                        if (role.ToString() == "Admin") 
                        {
                            return 1;
                        } 
                        else if (role.ToString() == "SV")
                        {
                            return 2;
                        }                                                      
                    }    
                }    

            }
            return 0;           
        }
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (string.IsNullOrEmpty(returnUrl) || returnUrl == "/")
            {

                if (CheckSesion() == 1)
                {
                    return RedirectToAction("Index", "Home_Ad", new { Areas = "Admins" });
                }
                else if (CheckSesion() == 2)
                {
                    return RedirectToAction("Index", "Home_Ad", new { Areas = "SVs" });
                }
            }

            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home_Ad");
            }
        }
    }
}
    