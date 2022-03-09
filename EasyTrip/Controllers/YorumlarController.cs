using EasyTrip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTrip.Controllers
{
    public class YorumlarController : Controller
    {
        // GET: Yorumlar
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Yorumlars.OrderBy(x=>x.Blog.Baslik).ToList();
            return View(deger);
        }
        public ActionResult YorumSil(int id)
        {
            var x = c.Yorumlars.FirstOrDefault(a => a.YorumlarID == id);
            c.Yorumlars.Remove(x);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        //ID'YE GÖRE YORUM GETİRME
        public ActionResult YorumGetir(int id)
        {
            var d = c.Yorumlars.Find(id);
            return View("YorumGetir", d);
        }

        [HttpPost]
        public ActionResult YorumGuncelle(Yorumlar p)
        {
            var x = c.Yorumlars.FirstOrDefault(a => a.YorumlarID == p.YorumlarID);
            x.YorumlarID = p.YorumlarID;
            x.Kullanici = p.Kullanici;
            x.Mail = p.Mail;
            x.Yorum = p.Yorum;
            x.BlogID = p.BlogID;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}