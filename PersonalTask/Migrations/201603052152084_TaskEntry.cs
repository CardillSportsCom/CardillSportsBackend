namespace PersonalTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaskEntry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaskEntries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        description = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        task_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tasks", t => t.task_ID)
                .Index(t => t.task_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskEntries", "task_ID", "dbo.Tasks");
            DropIndex("dbo.TaskEntries", new[] { "task_ID" });
            DropTable("dbo.TaskEntries");
        }
    }
}
