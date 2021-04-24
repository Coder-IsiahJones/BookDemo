using Microsoft.EntityFrameworkCore;

namespace BookDemo.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
    }
}