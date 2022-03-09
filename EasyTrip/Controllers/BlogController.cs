using EasyTrip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTrip.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        public ActionResult Listele()
        {
            //var deger = c.Blogs.ToList();
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x => x.BlogID).Take(3).ToList();
            by.Deger4 = c.Yorumlars.OrderByDescending(x => x.YorumlarID).Take(3).ToList();
            return View(by);
        }
        BlogYorum by = new BlogYorum();
        public ActionResult BlogDetay(int id)
        {
            //var deger = c.Blogs.Where(x=>x.BlogID==id).ToList();

            by.Deger1 = c.Blogs.Where(x => x.BlogID == id).ToList();//blog
            by.Deger2 = c.Yorumlars.Where(x => x.BlogID == id).ToList(); //yorum
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar b)
        {
            c.Yorumlars.Add(b);
            c.SaveChanges();                    
            return PartialView();
        }
    }
}