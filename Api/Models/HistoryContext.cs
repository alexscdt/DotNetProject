using Microsoft.EntityFrameworkCore;

namespace ProjectDotNet.Models
{
    public class HistoryContext : DbContext
    {
        public HistoryContext(DbContextOptions<HistoryContext> options)
            : base(options)
        {
        }

        public DbSet<History> TodoItems { get; set; }
    }
}