namespace TrashCollectorProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeZipToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Zip", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Zip", c => c.Int(nullable: false));
        }
    }
}
