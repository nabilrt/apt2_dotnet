namespace BankApplicationDataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFKAccountCustomer : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Accounts", "CustomerId");
            AddForeignKey("dbo.Accounts", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Accounts", new[] { "CustomerId" });
        }
    }
}
