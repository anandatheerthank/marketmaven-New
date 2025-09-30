using Microsoft.EntityFrameworkCore;

namespace MarketMaven.Models
{
    public class MarketDBContext : DbContext
    {
        public MarketDBContext(DbContextOptions<MarketDBContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { set; get; }
    }
}
