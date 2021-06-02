using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCKutuphanee.Models;

namespace MVCKutuphanee.Controllers
{
    public class GrafikController : Controller
    {
        // GET: Grafik
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VisualizeKitapResult()
        {
            return Json(liste());
        }

        public List<Class1> liste()
        {
            List<Class1> cs = new List<Class1>();
            cs.Add(new Class1()
            {
                yayınevi = "Güneş",
                sayi = 7,
            });
            cs.Add(new Class1()
            {
                yayınevi = "Mars",
                sayi = 4
            });
            cs.Add(new Class1()
            {
                yayınevi = "Jupiter",
                sayi = 6
            });
            return cs;

        }

    }
}