using Domin.Entity;
using infrastructure.ViewModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Data
{
    public class FreeBookDbContext:IdentityDbContext<ApplicationUser>
    {
        public FreeBookDbContext(DbContextOptions<FreeBookDbContext> options) : base(options)
        { 

        }

        protected override void OnModelCreating(ModelBuilder builder) 
        { 

            base.OnModelCreating(builder);

        builder.Entity<Book>().Property(x=>x.Id).HasDefaultValueSql("(newid())");
        builder.Entity<Category>().Property(x=>x.Id).HasDefaultValueSql("(newid())");
        builder.Entity<LogBook>().Property(x=>x.Id).HasDefaultValueSql("(newid())");
        builder.Entity<LogCategory>().Property(x=>x.Id).HasDefaultValueSql("(newid())");
        builder.Entity<SubCategory>().Property(x=>x.Id).HasDefaultValueSql("(newid())");
        builder.Entity<SubLogCategory>().Property(x=>x.Id).HasDefaultValueSql("(newid())");

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<LogBook> LogBooks { get; set; }
        public DbSet<LogCategory> LogCategories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<SubLogCategory> SubLogCategories { get; set; }

    }
}
