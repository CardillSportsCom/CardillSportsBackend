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
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Articles()
        {
            return View();
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