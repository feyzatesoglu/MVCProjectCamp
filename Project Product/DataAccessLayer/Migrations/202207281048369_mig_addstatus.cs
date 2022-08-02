namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_addstatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.writers", "WriterStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.writers", "WriterStatus");
        }
    }
}
