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
        public ActionResult ViewArticle(int articleID)
        {
            var model = new Article();
            return View(model);
        }

        public ActionResult AddArticle()
        {
            var model = new Article();
            return View();

        }
    }
}