using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalTask.Models;

namespace PersonalTask.Controllers
{
    public class ArticleController : Controller
    {

        [HttpGet]
        public ActionResult ViewArticle(int articleID=0)
        {
            var model = new Article();
            if (articleID == null)
            {
                return RedirectToAction("Index", "Home");
            }
            model = CardillSportsDB.GetArticle(articleID);
            if (model == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        public ActionResult AddArticle()
        {
            var model = new Article();
            return View();

        }
    }
}