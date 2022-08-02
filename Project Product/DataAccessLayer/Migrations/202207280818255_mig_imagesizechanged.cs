namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_imagesizechanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.writers", "WriterImage", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.writers", "WriterImage", c => c.String(maxLength: 100));
        }
    }
}
