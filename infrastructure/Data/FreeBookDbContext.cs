using Domin.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Data
{
    public class FreeBookDbContext:DbContext
    {
        public FreeBookDbContext(DbContextOptions<FreeBookDbContext> options) : base(options)
        { 

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<LogBook> LogBooks { get; set; }
        public DbSet<LogCategory> LogCategories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<SubLogCategory> subLogCategories { get; set; }

    }
}
