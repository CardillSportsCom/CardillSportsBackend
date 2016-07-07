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
        public string HeadLine { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }
        public bool Deleted { get; set; }
        public int Likes { get; set; }
        public double Rating { get; set; }

        public virtual User Owner { get; set; }
        public virtual List<ArticleItem> ArticleItems { get; set; }
        public virtual List<Comment> Comments { get; set; }

    }
    public class ArticleJson
    {
        public ArticleJson()
        {

        }
        public ArticleJson(Article a)
        {
            this.ID = a.ID;
            this.Name = a.Name;
            this.ImageLink = a.ImageLink;
            this.HeadLine = a.HeadLine;
            this.DateCreated = a.DateCreated;
            this.DateUpdated = a.DateUpdated;
            this.DateDeleted = a.DateDeleted;
            this.Deleted = a.Deleted;
            this.Likes = a.Likes;
            this.Rating = a.Rating;
            this.Owner = new UserJson(a.Owner);
            this.ArticleItems = new List<ArticleItemJson>();
            if (a.ArticleItems.Count > 0)
            {
                foreach (ArticleItem aItem in a.ArticleItems)
                {
                    this.ArticleItems.Add(new ArticleItemJson(aItem));
                }
            }
            this.Comments = new List<CommentJson>();
            if (a.Comments.Count > 0)
            {
                foreach (Comment c in a.Comments)
                {
                    this.Comments.Add(new CommentJson(c));
                }
            }
        }
        public int ID;
        public string Name;
        public string ImageLink;
        public string HeadLine;
        public DateTime DateCreated;
        public DateTime DateUpdated;
        public DateTime? DateDeleted;
        public bool Deleted;
        public int Likes;
        public double Rating;
        public UserJson Owner;
        public List<ArticleItemJson> ArticleItems;
        public List<CommentJson> Comments;
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
    public class ArticleItemJson
    {
        public ArticleItemJson()
        {

        }
        public ArticleItemJson(ArticleItem a)
        {
            this.ID = a.ID;
            this.OrderNumber = a.OrderNumber;
            this.Paragraph = a.Paragraph;
            this.Link = a.Link;
            this.ArticleConnectionID = a.ArticleConnection.ID;
            this.Type = a.Type.Name;
        }
        public int ID;
        public int OrderNumber;
        public string Paragraph;
        public string Link;
        public int ArticleConnectionID;
        public string Type;
    }
    public class ArticleItemType
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class Comment
    {
        public int ID { get; set; }
        public string CommentLine { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }
        public bool Deleted { get; set; }
        public int Likes { get; set; }

        public virtual List<Comment> Replies { get; set; }
        public virtual User User { get; set; }
        public virtual Article Article { get; set; }
    }
    public class CommentJson
    {
        public CommentJson()
        {

        }
        public CommentJson(Comment c)
        {
            this.ID = c.ID;
            this.Comment = c.CommentLine;
            this.DateCreated = c.DateCreated;
            this.DateUpdated = c.DateUpdated;
            this.DateDeleted = c.DateDeleted;
            this.Deleted = c.Deleted;
            this.Likes = c.Likes;
            this.User = new UserJson(c.User);
            this.Replies = new List<CommentJson>();
            if (c.Replies.Count > 0)
            {
                foreach (Comment cJ in c.Replies)
                {
                    this.Replies.Add(new CommentJson(cJ));
                }
            }
        }
        public int ID;
        public string Comment;
        public DateTime DateCreated;
        public DateTime DateUpdated;
        public DateTime? DateDeleted;
        public bool Deleted;
        public int Likes;
        public UserJson User;
        public List<CommentJson> Replies;
    }
}