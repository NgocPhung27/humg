using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LapTrinhQuanLyDb.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<person> Persons { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<person>()
              .Property(e => e.PersonID)
              .IsUnicode(true);
            modelBuilder.Entity<person>()
            .Property(e => e.PersonName)
            .IsUnicode(true);
            modelBuilder.Entity<person>()
           .Property(e => e.PersonAddress)
           .IsUnicode(true);

        }*/
    }
}
