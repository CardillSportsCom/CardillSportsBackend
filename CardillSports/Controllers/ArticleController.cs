using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalTask.Models;
using Newtonsoft.Json;

namespace PersonalTask.Controllers
{
    public class ArticleController : Controller
    {

        [HttpGet]
        public ActionResult ViewArticle(int articleID = 0)
        {
            var model = new Article();
            var targetURL = "articlePage";
            model = CardillSportsDB.GetArticle(articleID);
            if (model == null)
            {
                targetURL = "homePage";
                model = new Article();
                return Json(new
                {
                    targetURL = targetURL
                }, JsonRequestBehavior.AllowGet);
            }
            return Json(new
            {
                articleData = new ArticleJson(model),
                targetURL = targetURL
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddArticle()
        {
            var model = new Article();
            return View();

        }
    }
}