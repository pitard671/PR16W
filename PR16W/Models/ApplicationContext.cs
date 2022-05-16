using Microsoft.EntityFrameworkCore;

namespace PR16W.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Friend> Friends { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
