namespace CRUD_Operation_ASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Gender", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Gender", c => c.String());
            DropColumn("dbo.Customers", "Email");
        }
    }
}
