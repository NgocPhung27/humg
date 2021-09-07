namespace BT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_Khachhang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHáng",
                c => new
                    {
                        MaKhachHang = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenKhachHang = c.String(unicode: false),
                        SoDienThoai = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.MaKhachHang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHáng");
        }
    }
}
