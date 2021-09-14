namespace BTDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_Person1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Persons", "PersonName", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Persons", "PersonAddress", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Persons", "PersonAddress", c => c.String(unicode: false));
            AlterColumn("dbo.Persons", "PersonName", c => c.String(unicode: false));
        }
    }
}
