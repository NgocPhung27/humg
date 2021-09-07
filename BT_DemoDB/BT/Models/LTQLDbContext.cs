using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BT.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }

        public virtual DbSet<Khachhang> KhachHangs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Khachhang>()
            .Property(e => e.MaKhachHang)
            .IsUnicode(false);
            modelBuilder.Entity<Khachhang>()
           .Property(e => e.TenKhachHang)
           .IsUnicode(false);
            modelBuilder.Entity<Khachhang>()
           .Property(e => e.SoDienThoai)
           .IsUnicode(false);
        }
    }
}
