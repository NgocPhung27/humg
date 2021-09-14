namespace VDDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_employee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "Company", c => c.String());
            AddColumn("dbo.Persons", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persons", "Discriminator");
            DropColumn("dbo.Persons", "Company");
        }
    }
}
