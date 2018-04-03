namespace _13.EmployeesMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dataannotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Employees", "Category", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Category", c => c.String());
            AlterColumn("dbo.Employees", "Name", c => c.String());
        }
    }
}
