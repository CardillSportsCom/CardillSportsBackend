using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalTask.Models
{
    
    public class CardillSportsDB
    {
        private static Model _db = new Model();
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
            article = _db.Articles.Where(x => x.ID == articleID).FirstOrDefault();
            return article;
        }
    }
}