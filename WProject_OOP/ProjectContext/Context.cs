using Microsoft.EntityFrameworkCore;
using WProject_OOP.Entity;

namespace WProject_OOP.ProjectContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-D0C1NMR\\SQLEXPRESS;database=DbNewOopCore;integrated security=true;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
