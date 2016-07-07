using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace PersonalTask.Models
{


    public class Model : DbContext
    {
        public Model()
            : base("name=EntityModel")
        {
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleItem> ArticleItems { get; set; }
        public DbSet<ArticleItemType> ArticleItemTypes { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
