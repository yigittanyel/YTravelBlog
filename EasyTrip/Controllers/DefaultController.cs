using EasyTrip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTrip.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Blogs.Take(10).ToList();
            return View(deger);
        }
        public ActionResult Hakkimda()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var deger = c.Blogs.OrderByDescending(x => x.BlogID).Take(2).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.Where(x => x.BlogID == 3).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.OrderByDescending(x => x.BlogID).Take(5).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.OrderByDescending(x=>x.BlogID).Take(3).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }

    }
}