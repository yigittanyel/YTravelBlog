using EasyTrip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EasyTrip.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GirisYap(Admin a)
        {
            var bilgi = c.Admins.FirstOrDefault(x => x.Kullanici == a.Kullanici && x.Sifre == a.Sifre);
            if (bilgi != null)
            {
                FormsAuthentication.SetAuthCookie(bilgi.Kullanici,true);
                Session["Kullanıcı"] = bilgi.Kullanici.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
        public ActionResult CikisYap()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("GirisYap", "Login");
        }
    }
}