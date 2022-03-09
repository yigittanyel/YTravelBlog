using EasyTrip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTrip.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.Blogs.ToList();
            return View(deger);
        }
        public ActionResult BlogSil(int id)
        {
            var x = c.Blogs.FirstOrDefault(a => a.BlogID == id);
            c.Blogs.Remove(x);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        //ID'YE GÖRE BLOG GETİRME
        public ActionResult BlogGetir(int id)
        {
            var d = c.Blogs.Find(id);
            return View("BlogGetir", d);
        }

        [HttpPost]
        public ActionResult BlogGuncelle(Blog p)
        {
            var x = c.Blogs.FirstOrDefault(a => a.BlogID == p.BlogID);
            x.BlogID = p.BlogID;
            x.Baslik = p.Baslik;
            x.Tarih = p.Tarih;
            x.Aciklama = p.Aciklama;
            x.BlogImage = p.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YeniBlogEkle()
        {
            return View();
        }


        [HttpPost]
        public ActionResult YeniBlogEkle(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
    }
}