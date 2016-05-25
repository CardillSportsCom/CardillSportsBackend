namespace PersonalTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Color = c.String(),
                        deleted = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        DateDeadline = c.DateTime(),
                        user_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.user_ID)
                .Index(t => t.user_ID);
            
            AddColumn("dbo.Users", "deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "DateCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "user_ID", "dbo.Users");
            DropIndex("dbo.Tasks", new[] { "user_ID" });
            DropColumn("dbo.Users", "DateCreated");
            DropColumn("dbo.Users", "deleted");
            DropTable("dbo.Tasks");
        }
    }
}
