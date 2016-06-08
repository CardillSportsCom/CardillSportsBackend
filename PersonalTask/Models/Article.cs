using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalTask.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageLink { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }
        public bool Deleted { get; set; }

        public virtual User Owner { get; set; }
        public virtual List<ArticleItem> ArticleItems { get; set; }

    }
    public class ArticleItem
    {
        public int ID { get; set; }
        public int OrderNumber { get; set; }

        public string Paragraph { get; set; }
        public string Link { get; set; }

        public virtual Article ArticleConnection { get; set; }
        public virtual ArticleItemType Type { get; set; }
    }
    public class ArticleItemType
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}