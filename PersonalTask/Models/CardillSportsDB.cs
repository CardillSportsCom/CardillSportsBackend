using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalTask.Models
{
    
    public class CardillSportsDB
    {
        public static Article AddArticle()
        {
            Article newArticle = new Article();
            //newArticle.Owner = 
            newArticle.DateCreated = DateTime.Now;
            newArticle.DateUpdated = DateTime.Now;

            return newArticle;
        }
    }
}