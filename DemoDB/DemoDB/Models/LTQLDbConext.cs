using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DemoDB.Models
{
    public partial class LTQLDbConext : DbContext
    {
        public LTQLDbConext()
            : base("name=LTQLDbConext")
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
        }
    }
}
