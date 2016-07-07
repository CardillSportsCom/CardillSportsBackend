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
        public ActionResult Index(bool json=false)
        {
            List<Article> model = new List<Article>();
            model = CardillSportsDB.RecentArticles();
            if (json)
            {
                List<ArticleJson> sendData = new List<ArticleJson>();
                if (model.Count > 0)
                {
                    foreach (Article a in model)
                    {
                        sendData.Add(new ArticleJson(a));
                    }
                }
                return Json(new
                {
                    articleList = sendData
                }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Articles()
        {
            var model = new List<Article>();
            model = CardillSportsDB.GetArticles(true);
            List<ArticleJson> sendData = new List<ArticleJson>();
            if (model.Count > 0)
            {
                foreach (Article a in model)
                {
                    sendData.Add(new ArticleJson(a));
                }
            }
            return Json(new
            {
                articleList = sendData
            }, JsonRequestBehavior.AllowGet);
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