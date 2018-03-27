namespace _13.EmployeesMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Category : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Category");
        }
    }
}
