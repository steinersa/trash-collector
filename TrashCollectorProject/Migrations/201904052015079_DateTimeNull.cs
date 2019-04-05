namespace TrashCollectorProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimeNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "ExtraPickup", c => c.DateTime());
            AlterColumn("dbo.Customers", "TempSuspendStart", c => c.DateTime());
            AlterColumn("dbo.Customers", "TempSuspendEnd", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "TempSuspendEnd", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "TempSuspendStart", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "ExtraPickup", c => c.DateTime(nullable: false));
        }
    }
}
