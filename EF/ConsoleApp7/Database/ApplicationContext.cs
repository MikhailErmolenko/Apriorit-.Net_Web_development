using ConsoleApp7.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ConsoleApp7.NEDatabase
{
    public class ApplicationContext : DbContext
    {
        static ApplicationContext()
        {
            Database.SetInitializer<ApplicationContext>(new AppContextInitializer());
        }


        public ApplicationContext() : base("DbConnection")
        {
            
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authour>()
                .HasMany(c => c.Books)
                .WithRequired(c => c.Authour);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Authour> Authors { get; set; }
    }
}
