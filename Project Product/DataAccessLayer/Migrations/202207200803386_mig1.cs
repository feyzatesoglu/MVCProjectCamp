namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "writerID", c => c.Int());
            CreateIndex("dbo.Contents", "writerID");
            AddForeignKey("dbo.Contents", "writerID", "dbo.writers", "writerID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "writerID", "dbo.writers");
            DropIndex("dbo.Contents", new[] { "writerID" });
            DropColumn("dbo.Contents", "writerID");
        }
    }
}
