using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTDb.Models
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
              .IsUnicode(false);
            modelBuilder.Entity<Person>()
            .Property(e => e.PersonName)
            .IsUnicode(false);
            modelBuilder.Entity<Person>()
           .Property(e => e.PersonAddress)
           .IsUnicode(false);
        }
    }
}
