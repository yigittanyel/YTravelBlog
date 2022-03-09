using EasyTrip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTrip.Controllers
{
    public class HakkimizdaController : Controller
    {
        // GET: Hakkimizda
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Hakkimizdas.ToList();
            return View(deger);
        }
    }
}