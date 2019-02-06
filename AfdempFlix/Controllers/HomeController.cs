using AfdempFlix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AfdempFlix.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext db = new MoviesContext();

        public ActionResult Index()
        {
            return View(db.MyEntities.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}