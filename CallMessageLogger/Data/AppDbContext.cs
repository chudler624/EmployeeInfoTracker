using CallMessageLogger.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CallMessageLogger.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
