using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalTask.Models;

namespace PersonalTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Article> model = new List<Article>();
            model = CardillSportsDB.RecentArticles();
            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Articles()
        {
            var model = new List<Article>();
            model = CardillSportsDB.GetArticles(true);
            return View(model);
        }

        public ActionResult Videos()
        {
            return View();
        }

        public ActionResult Fantasy()
        {
            return View();
        }

        public ActionResult Podcasts()
        {
            return View();
        }
    }
}