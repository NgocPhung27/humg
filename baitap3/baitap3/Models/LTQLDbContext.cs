using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace baitap3.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext1")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
            .Property(e => e.StudentID)
            .IsUnicode(false);
            modelBuilder.Entity<Student>()
            .Property(e => e.StudentName)
            .IsUnicode(false);

        }
    }
}
