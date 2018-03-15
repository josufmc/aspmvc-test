namespace _6.MyModelMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dataanotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Name", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "Name", c => c.String());
        }
    }
}
