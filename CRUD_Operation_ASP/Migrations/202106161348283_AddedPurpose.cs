namespace CRUD_Operation_ASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPurpose : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsBusiness", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "IsDelivery", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "IsVisiting", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "IsOther", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "MembershipType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MembershipType", c => c.String());
            DropColumn("dbo.Customers", "IsOther");
            DropColumn("dbo.Customers", "IsVisiting");
            DropColumn("dbo.Customers", "IsDelivery");
            DropColumn("dbo.Customers", "IsBusiness");
        }
    }
}
