namespace TrashCollectorProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateZipToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Zip", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Zip", c => c.Int(nullable: false));
        }
    }
}
