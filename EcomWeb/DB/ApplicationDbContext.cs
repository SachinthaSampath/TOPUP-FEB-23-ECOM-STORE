using EcomWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace EcomWeb.DB
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Customer> customers { get; set; }
        public DbSet<Employee> employees { get; set; }

        public DbSet<Product> products { get; set; }
    }
}
