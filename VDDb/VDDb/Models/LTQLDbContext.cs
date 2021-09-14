using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace VDDb.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<Person> Persons { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
             .Property(e => e.PersonID)
             .IsUnicode(true);
            modelBuilder.Entity<Person>()
            .Property(e => e.PersonName)
            .IsUnicode(true);
            modelBuilder.Entity<Person>()
           .Property(e => e.PersonAddress)
           .IsUnicode(true);
            modelBuilder.Entity<Employee>()
          .Property(e => e.Company)
          .IsUnicode(true);
        }

        public System.Data.Entity.DbSet<VDDb.Models.Employee> People { get; set; }
    }
}
