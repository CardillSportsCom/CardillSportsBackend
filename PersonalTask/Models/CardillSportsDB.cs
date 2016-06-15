using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalTask.Models
{

    public class CardillSportsDB
    {
        private static Model db = new Model();

        //Article Code
        public static Article AddArticle()
        {
            Article newArticle = new Article();
            //newArticle.Owner = 
            newArticle.DateCreated = DateTime.Now;
            newArticle.DateUpdated = DateTime.Now;

            return newArticle;
        }

        public static Article GetArticle(int articleID)
        {
            Article article = new Article();
            article = db.Articles.Where(x => x.ID == articleID).FirstOrDefault();
            return article;
        }

        public static List<Article> GetArticles(bool getAll)
        {
            List<Article> articles = new List<Article>();
            if(getAll)
            {
                articles = db.Articles.OrderByDescending(x=>x.DateUpdated).ToList();
            }
            else
            {
                articles = db.Articles.OrderByDescending(x => x.DateUpdated).Take(10).ToList();

            }
            if (articles == null)
            {
                articles = new List<Article>();
            }
            return articles;
        }

        public static List<Article> RecentArticles()
        {
            List<Article> articles = new List<Article>();
            articles = db.Articles.OrderByDescending(x => x.DateUpdated).Take(5).ToList();
            return articles;
        }
    }
}