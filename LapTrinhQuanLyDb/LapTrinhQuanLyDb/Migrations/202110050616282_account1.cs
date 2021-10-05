namespace LapTrinhQuanLyDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class account1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "RoleID", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "RoleID");
        }
    }
}
