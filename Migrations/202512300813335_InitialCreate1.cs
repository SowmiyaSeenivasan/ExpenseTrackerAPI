namespace ExpenseTrackerAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Expenses", "Description", c => c.String());
            AlterColumn("dbo.Expenses", "Category", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Expenses", "Category", c => c.String(nullable: false));
            AlterColumn("dbo.Expenses", "Description", c => c.String(nullable: false));
        }
    }
}
