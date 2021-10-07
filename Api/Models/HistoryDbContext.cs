using Microsoft.EntityFrameworkCore;

namespace ProjectDotNet.Models
{
    public class HistoryDbContext : DbContext
    {
        public HistoryDbContext(DbContextOptions<HistoryDbContext> options)
            : base(options)
        {
        }

        public DbSet<History> history { get; set; }
    }
}