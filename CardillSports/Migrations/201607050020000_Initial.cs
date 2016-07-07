namespace PersonalTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CommentLine = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                        Deleted = c.Boolean(nullable: false),
                        Likes = c.Int(nullable: false),
                        Article_ID = c.Int(),
                        Comment_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Articles", t => t.Article_ID)
                .ForeignKey("dbo.Comments", t => t.Comment_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.Article_ID)
                .Index(t => t.Comment_ID)
                .Index(t => t.User_ID);
            
            
            
        }
        
        public override void Down()
        {
        }
    }
}
