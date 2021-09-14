namespace BTDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_Person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128, unicode: false),
                        PersonName = c.String(unicode: false),
                        PersonAddress = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Persons");
        }
    }
}
